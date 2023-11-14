
using Project_Management.DAO;
using System;
using System.Collections.Generic;
using Project_Management;
using Project_Management.DTO;
using Project_Management.Utils;
using Project_Management.view;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Globalization;
using System.Drawing;

namespace Project_Management.View.UC
{
    public partial class UcTask : UserControl
    {
        private readonly Lazy<TaskDAO> _taskDao;
        private readonly Lazy<TeamDAO> _teamDao;
        private readonly Lazy<UserDAO> _userDao;
        private readonly Lazy<ProjectDAO> _projectDao;
        private static task infoTask;
        private int _selectedId;

        public UcTask()
        {
            InitializeComponent();
            _taskDao = new Lazy<TaskDAO>(() => new TaskDAO());
            _teamDao = new Lazy<TeamDAO>(() => new TeamDAO());
            _userDao = new Lazy<UserDAO>(() => new UserDAO());
            _projectDao = new Lazy<ProjectDAO> (() => new ProjectDAO());
        }
        
        private void UC_Task_Load(object sender, EventArgs e)
        {
            LoadData(GetData());
        }

        private void LoadData(List<task> taskTable)
        {
            LoadDataGridview(taskTable, dataGridView_Task);
        }

        private List<task> GetData()
        {
            return _taskDao.Value.GetListTaskByPosition();
        }

        public void LoadDataGridview(List<task> listTask, DataGridView dataGridView)
        {
            var userDao = _userDao.Value;
            var teamDao = _teamDao.Value;
            var projectDao = _projectDao.Value;


            dataGridView.ColumnCount = 7;
            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Task Name";
            dataGridView.Columns[1].Width = 275;
            dataGridView.Columns[2].Name = "Deadline";
            dataGridView.Columns[3].Name = "Progress";
            dataGridView.Columns[4].Name = "Assigneed Person";
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[5].Name = "Assigneed Team";
            dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[6].Name = "Project Name";
            dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Rows.Clear();

            if (listTask != null)
            {
                listTask.Sort((x, y) =>
                {
                    if (x.deadline == null && y.deadline == null)
                        return 0;
                    else if (x.deadline == null)
                        return 1;
                    else if (y.deadline == null)
                        return -1;
                    else
                        return DateTime.Compare(x.deadline.Value, y.deadline.Value);
                });

                foreach (var t in listTask)
                {
                    string assignee = "";
                    string teamName = "";
                    string projectName = "";

                    if (t.idAssignee != null)
                    {
                        assignee = userDao.GetUserByID((int)t.idAssignee).fullName;
                    }

                    if (t.idTeam != null)
                    {
                        teamName = teamDao.GetNameTeamByID((int)t.idTeam);
                    }

                    if(t.idProject != null)
                    {
                        projectName = projectDao.GetNameProjectByID((int)t.idProject);
                    }

                    dataGridView.Rows.Add(t.id, t.taskName, (t.deadline != null ? t.deadline?.ToString("dd/MM/yyyy") : ""), t.progress + " %", assignee, teamName, projectName);
                }
                LoadProgressChart(false);
            }
            else
            {
                LoadProgressChart(true);
            }
        }

        public void LoadProgressChart(Boolean isNull)
        {
            String todoPercent;
            String inProgressPercent;
            String donePrecent;

            if(!isNull)
            {
                double todo = 0;
                double inProgress = 0;
                double done = 0;


                foreach (DataGridViewRow row in dataGridView_Task.Rows)
                {
                    if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                    {
                        int progress = int.TryParse(row.Cells[3].Value.ToString().Replace("%", "").Trim(), out int result) ? result : 0;


                        if (progress == 0)
                        {
                            todo++;
                            continue;
                        }
                        if (progress == 100)
                        {
                            done++;
                            continue;
                        }
                        inProgress++;
                    }
                }


                double total = todo + inProgress + done;
                todoPercent = ((todo / total) * 100).ToString("0.00");
                inProgressPercent = ((inProgress / total) * 100).ToString("0.00");
                donePrecent = ((done / total) * 100).ToString("0.00");

                if(todoPercent == "NaN" || inProgressPercent == "NaN" || donePrecent == "NaN")
                {
                    EmptyProgressChart();
                    return;
                }

                chart_taskProgress.Series["SeriesProgress"].Points.Clear();
                chart_taskProgress.Series["SeriesProgress"].Points.AddXY("", todoPercent);
                chart_taskProgress.Series["SeriesProgress"].Points.AddXY("", inProgressPercent);
                chart_taskProgress.Series["SeriesProgress"].Points.AddXY("", donePrecent);

                //chart_taskProgress.Series["SeriesProgress"].IsValueShownAsLabel = false;

                chart_taskProgress.Legends.Clear();

                chart_taskProgress.Series["SeriesProgress"].Points[0].Color = Color.FromArgb(214, 40, 40);
                chart_taskProgress.Series["SeriesProgress"].Points[1].Color = Color.FromArgb(0, 255, 0);
                chart_taskProgress.Series["SeriesProgress"].Points[2].Color = Color.FromArgb(67, 97, 238);

                label_todoTask.Text = todoPercent + "%";
                label_inprogressTask.Text = inProgressPercent + "%";
                label_doneTask.Text = donePrecent + "%";
            }
            else
            {
                EmptyProgressChart();
            }
        }

        public void EmptyProgressChart()
        {
            chart_taskProgress.Series["SeriesProgress"].Points.Clear();
            chart_taskProgress.Series["SeriesProgress"].Points.AddXY("", "100");
            chart_taskProgress.Legends.Clear();
            chart_taskProgress.Series["SeriesProgress"].Points[0].Color = Color.FromArgb(228, 228, 228);

            label_todoTask.Text = "0%";
            label_inprogressTask.Text = "0%";
            label_doneTask.Text = "0%";
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if(_userDao.Value.IsManager() || _userDao.Value.IsHumanResources() || _userDao.Value.IsLeader())
            {
                StackForm.FormMain.ChildForm.Open(new FormAddTask());
            }
            else
            {
                MessageBox.Show("Access denied!!! Insufficient permissions to access feature.", "Message", MessageBoxButtons.OK);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if(_userDao.Value.IsManager() || _userDao.Value.IsHumanResources() || _userDao.Value.IsLeader())
            {
                if (_selectedId != 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete task?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _taskDao.Value.DeleteTask(infoTask.id);
                        LoadData(GetData());
                    }
                }
                else MessageBox.Show("You haven't selected a task!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Access denied!!! Insufficient permissions to access feature.", "Message", MessageBoxButtons.OK);
            }

        }

        private void btnViewTask_Click(object sender, EventArgs e)
        {
            if (_selectedId != 0)
            {
                StackForm.FormMain.ChildForm.Open(new FormViewOrUpdateTask(infoTask, true));
            }
            else MessageBox.Show("You haven't selected a task!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (_userDao.Value.IsManager() || _userDao.Value.IsHumanResources() || _userDao.Value.IsLeader())
            {
                if (_selectedId != 0)
                {
                    StackForm.FormMain.ChildForm.Open(new FormViewOrUpdateTask(infoTask, false));
                }
                else MessageBox.Show("You haven't selected a task!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Access denied!! Insufficient permissions to access feature.", "Message", MessageBoxButtons.OK);
            }
        }

        private void dataGridView_Task_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                object value = dataGridView_Task.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    _selectedId = Convert.ToInt32(value);
                    infoTask = _taskDao.Value.GetTaskByTaskID(_selectedId);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData(GetData());
        }

        private void combobox_taskStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<task> tasks = null;
            int selectedIndex = combobox_taskStatusFilter.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    tasks = _taskDao.Value.GetListTaskByPosition();
                    break;
                case 1:
                    tasks = _taskDao.Value.GetMyTask();
                    break;
                default:
                    tasks = _taskDao.Value.GetListTaskByPosition();
                    break;
            }

            LoadDataGridview(tasks, dataGridView_Task);
        }
        
        private void combobox_taskProgressFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<task> tasks = null;
            int selectedIndex = combobox_taskProgressFilter.SelectedIndex;
            switch (selectedIndex)
            {
                case 1:
                    tasks = _taskDao.Value.GetTodoTasks();
                    break;
                case 2:
                    tasks = _taskDao.Value.GetInprogressTasks();
                    break;
                case 3:
                    tasks = _taskDao.Value.GetDoneTasks();
                    break;
                default:
                    tasks = _taskDao.Value.GetListTaskByPosition();
                    break;
            }

            LoadDataGridview(tasks, dataGridView_Task);
        }
    }
}
