﻿
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

namespace Project_Management.View.UC
{
    public partial class UcTask : UserControl
    {
        private readonly Lazy<TaskDAO> _taskDao;
        private readonly Lazy<TeamDAO> _teamDao;
        private readonly Lazy<UserDAO> _userDao;
        private static task infoTask;
        private int _selectedId;

        public UcTask()
        {
            InitializeComponent();
            _taskDao = new Lazy<TaskDAO>(() => new TaskDAO());
            _teamDao = new Lazy<TeamDAO>(() => new TeamDAO());
            _userDao = new Lazy<UserDAO>(() => new UserDAO());
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


            dataGridView.ColumnCount = 7;
            dataGridView.Columns[0].Name = "Mã";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Tên task";
            dataGridView.Columns[1].Width = 275;
            dataGridView.Columns[2].Name = "Deadline";
            dataGridView.Columns[3].Name = "Tiến độ";
            dataGridView.Columns[4].Name = "Người được giao";
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[5].Name = "Team được giao";
            dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

                    if (t.idAssignee != null)
                    {
                        assignee = userDao.GetUserByID((int)t.idAssignee).fullName;
                    }

                    if (t.idTeam != null)
                    {
                        teamName = teamDao.GetNameTeamByID((int)t.idTeam);
                    }

                    dataGridView.Rows.Add(t.id, t.taskName, (t.deadline != null ? t.deadline?.ToString("dd/MM/yyyy") : ""), t.progress + " %", assignee, teamName);
                }
            } 
        }







        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if(_userDao.Value.IsManager() || _userDao.Value.IsHumanResources())
            {
                StackForm.FormMain.ChildForm.Open(new FormAddTask());
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền hạn để truy cập chức năng này!!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if(_userDao.Value.IsManager() || _userDao.Value.IsHumanResources())
            {
                if (_selectedId != 0)
                {
                    DialogResult result = MessageBox.Show("Delete task?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _taskDao.Value.DeleteTask(infoTask.id);
                        LoadData(GetData());
                    }
                }
                else MessageBox.Show("Bọn chưa chọn Task nào!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền hạn để truy cập chức năng này!!!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnViewTask_Click(object sender, EventArgs e)
        {
            if (_selectedId != 0)
            {
                StackForm.FormMain.ChildForm.Open(new FormViewOrUpdateTask(infoTask, true));
            }
            else MessageBox.Show("Bọn chưa chọn Task nào!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (_userDao.Value.IsManager() || _userDao.Value.IsHumanResources() || _userDao.Value.IsLeader())
            {
                if (_selectedId != 0)
                {
                    StackForm.FormMain.ChildForm.Open(new FormViewOrUpdateTask(infoTask, false));
                }
                else MessageBox.Show("Bọn chưa chọn Task nào!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền hạn để truy cập chức năng này!!!", "Thông báo", MessageBoxButtons.OK);
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
                    tasks = null;
                    break;
                default:
                    tasks = _taskDao.Value.GetMyTask();
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
                    tasks = _taskDao.Value.GetListTaskByPosition();
                    break;
                case 2:
                    tasks = _taskDao.Value.GetTodoTasks();
                    break;
                case 3:
                    tasks = _taskDao.Value.GetInprogressTasks();
                    break;
                case 4:
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
