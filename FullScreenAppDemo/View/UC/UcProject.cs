
using Project_Management;
using Project_Management.DAO;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Project_Management.View.UC
{
    public partial class UcProject : UserControl
    {
        private int selectedIndex;
        private int _selectedId;
        public UcProject()
        {
            InitializeComponent();
            Check();
            LoadCB();
            LoadProgressChart();
        }
        private void LoadProgressChart()
        {
            List<project> projects = ProjectDAO.Instance.GetListProjectByPosition();
            Util.Instance.LoadProgressChart(chart_projectProgress, label_todoProject, label_inprogressProject, label_doneProject, projects);
        }
        void Check()
        {
            if (UserDAO.Instance.IsEmployee()|| UserDAO.Instance.IsLeader())
            {
                buttonAdd.Visible = false;
                button_remove.Visible = false;
            }
        }
        private void LoadCB()
        {
            combobox_progressFilter.Items.Add("All project");
            combobox_progressFilter.Items.Add("To Do");
            combobox_progressFilter.Items.Add("Progressing");
            combobox_progressFilter.Items.Add("Done");
            combobox_progressFilter.SelectedIndex = 0;
            _selectedId = 0;

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddProject addProject = new FormAddProject();
            addProject.ShowDialog();
        }

        private void dataGridView_Project_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                object value = dataGridView_Project.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    _selectedId = Convert.ToInt32(value);
                }
            }
        }
        private void LoadDataGridview()
        {
            List<project> pj = new List<project>();
            switch (selectedIndex)
            {
                case 0:
                    pj = ProjectDAO.Instance.GetListProjectByPosition();
                    break;
                case 1:
                    pj = ProjectDAO.Instance.GetToDoProject();
                    break;
                case 2:
                    pj = ProjectDAO.Instance.GetInprogressProjects();
                    break;
                case 3:
                    pj = ProjectDAO.Instance.GetDoneProjects();
                    break;
                default:
                    pj = null;
                    break;
            }

            dataGridView_Project.ColumnCount = 8;
            dataGridView_Project.Columns[0].Name = "Id";
            dataGridView_Project.Columns[0].Visible = false;
            dataGridView_Project.Columns[1].Name = "Project Name";
            dataGridView_Project.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_Project.Columns[2].Name = "From";
            dataGridView_Project.Columns[3].Name = "To";
            dataGridView_Project.Columns[4].Name = "Progress";
            dataGridView_Project.Columns[5].Name = "Assignee";
            dataGridView_Project.Columns[6].Name = "Assignee Team";
            dataGridView_Project.Columns[7].Name = "Bonus";
            dataGridView_Project.Rows.Clear();

            foreach (project p in pj)
            {
                string assignee = UserDAO.Instance.GetUserByID((int)p.idAssignee).fullName;
                string team = TeamDAO.Instance.GetTeamByIdTeam((int)p.idTeam).name;

                dataGridView_Project.Rows.Add(p.id, p.name,((DateTime)p.startDate).ToString("d/M/yyyy"),
                    ((DateTime)p.endDate).ToString("d/M/yyyy"), p.progress + " %", assignee, team, ((float)p.bonus).ToString("C"));
            }
        }
        private void combobox_progressFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = combobox_progressFilter.SelectedIndex;
            LoadDataGridview();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (_selectedId != 0)
            {
                DialogResult result = MessageBox.Show("Confirm project deletion? Warning: All tasks assigned to projects will be deleted!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DialogResult result2 = MessageBox.Show("Confirm project deletion?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    {
                        TaskDAO.Instance.DeleteTasksByProject(_selectedId);
                        ProjectDAO.Instance.DeleteProject(_selectedId);
                    }
                }
            }
            else MessageBox.Show("Please select a project!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGridview();
            LoadProgressChart();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (_selectedId != 0)
            {
                FormViewOrUpdateProject formProject = new FormViewOrUpdateProject();
                formProject.SelectedId = _selectedId;
                formProject.ShowDialog();
            }
            else MessageBox.Show("Select a project to view", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
