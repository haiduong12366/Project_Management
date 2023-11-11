using Project_Management.DAO;
using Project_Management.DTO;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Management.View.UC;

namespace Project_Management.View
{
    public partial class FormViewOrUpdateTask: Form
    {
        private Boolean isView = false;
        private int idTask = 0;
        private int idTeam = 0;

        private TeamDAO _teamDao = new TeamDAO();

        public FormViewOrUpdateTask()
        {
            InitializeComponent();
        }

        public FormViewOrUpdateTask(task infoTask, Boolean isView)
        {
            this.isView = isView;
            this.idTask = infoTask.id;
            this.idTeam = (int)infoTask.idTeam;
            InitializeComponent();
            BindingImageToFields();

            if (isView)
            {
                ProjectDAO _projectDao = new ProjectDAO();

                gboxTask.Text = "View Task";

                txtbox_Taskname.Text = infoTask.taskName;

                txtbox_Desciption.Text = infoTask.description;

                if (infoTask.idTeam != null)
                {
                    string nameTeam = _teamDao.GetNameTeamByID((int)infoTask.idTeam);
                    label_assigneedTeam.Text = nameTeam;
                    combbox_Assignee.Items.Add(nameTeam);
                    combbox_Assignee.SelectedIndex = 0;
                }

                if (infoTask.idProject != null)
                {
                    combbox_Project.Items.Add(_projectDao.GetNameProjectByID((int)infoTask.idProject));
                    combbox_Project.SelectedIndex = 0;
                }

                int index = combobox_progress.FindStringExact(infoTask.progress.ToString());
                if (index != -1)
                {
                    combobox_progress.SelectedIndex = index;
                }

                dateTime_deadline.Value = (DateTime)infoTask.deadline;

                if (infoTask.bonus != null)
                {
                    textBox_Bonus.Text = infoTask.bonus.ToString();
                }

                circleProgressBar.Value = (int)infoTask.progress;
                progressValue.Text = infoTask.progress + @"%";

                txtbox_Taskname.Enabled = false;
                txtbox_Desciption.Enabled = false;
                textBox_Bonus.Enabled = false;
                combbox_Assignee.Enabled = false;
                combbox_Project.Enabled = false;
                dateTime_deadline.Enabled = false;

                btnSave.Hide();
            }
            else
            {
                Load();
                this.idTask = infoTask.id;
                ProjectDAO _projectDao = new ProjectDAO();

                gboxTask.Text = "Update Task";
                txtbox_Taskname.Text = infoTask.taskName;

                txtbox_Desciption.Text = infoTask.description;

                string nameTeam = _teamDao.GetNameTeamByID((int)infoTask.idTeam);
                label_assigneedTeam.Text = nameTeam;

                if (infoTask.idTeam != null)
                {
                    GetDataToCombobox(combbox_Assignee, (int)infoTask.idTeam);
                }
                else
                {
                    GetDataToCombobox(combbox_Assignee, -1);
                }

                dateTime_deadline.Value = (DateTime)infoTask.deadline;

                if (infoTask.bonus != null)
                {
                    textBox_Bonus.Text = infoTask.bonus.ToString();
                }

                int index = combobox_progress.FindStringExact(infoTask.progress.ToString());
                if (index != -1)
                {
                    combobox_progress.SelectedIndex = index;
                }

                UserDAO _userDao = new UserDAO();
                if (_userDao.IsLeader())
                {
                    txtbox_Taskname.Enabled = false;
                    txtbox_Desciption.Enabled = false;
                    textBox_Bonus.Enabled = false;
                    combbox_Assignee.Enabled = false;
                    combbox_Project.Enabled = false;
                    dateTime_deadline.Enabled = false;
                }

                circleProgressBar.Value = (int)infoTask.progress;
                progressValue.Text = infoTask.progress + @"%";

            }
        }

        private void Load()
        {
            GetDataToCombobox(combbox_Assignee, -1);
            BindingImageToFields();
        }

        private void BindingImageToFields()
        {
            team assigneeTeam = _teamDao.GetTeamByID(idTeam);

            ImageDAO _imageDAO = new ImageDAO();
            _imageDAO.ShowImageInPictureBox(assigneeTeam.avatar, picturebox_teamAvatar);

        }

        private void GetDataToCombobox(ComboBox assignees, int selected)
        {
            List<team> list = TeamDAO.Instance.GetTeamByID();
            assignees.DataSource = list;
            assignees.DisplayMember = "name";
            assignees.ValueMember = "id";
            if (selected == -1)
            {
                assignees.SelectedIndex = 0;
            }
            else
            {
                assignees.SelectedValue = selected;
            }
        }

        private void combbox_Assignee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isView)
            {
                int id = (combbox_Assignee.SelectedItem as team).id;
                List<project> list = ProjectDAO.Instance.GetProjectByTeam(id);

                combbox_Project.DataSource = list;
                combbox_Project.DisplayMember = "name";
                if (combbox_Project.Items.Count > 0)
                {
                    combbox_Project.SelectedIndex = 0;
                }
            }
        }

        private void combobox_progress_SelectedIndexChanged(object sender, EventArgs e)
        {
            int progress = Convert.ToInt32(combobox_progress.SelectedItem);
            circleProgressBar.Value = progress;
            progressValue.Text = progress + @"%";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                TeamDAO _teamDao = new TeamDAO();

                int idTeam = (combbox_Assignee.SelectedItem as team).id;
                int idAssigee = _teamDao.GetLeaderIDByTeamID(idTeam);
                int idproject = (combbox_Project.SelectedItem as project).id;
                int progress = int.Parse(combobox_progress.SelectedItem.ToString());
                float bonus = (float)Convert.ToInt32(textBox_Bonus.Text);

                TaskDAO.Instance.UpdateTask(this.idTask, txtbox_Taskname.Text, txtbox_Desciption.Text,
                                              dateTime_deadline.Value, idTeam, idAssigee, progress, idproject, bonus);

                StackForm.FormMain.ChildForm.AddUc(new UcTask());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            StackForm.FormMain.ChildForm.AddUc(new UcTask());
        }

        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_Taskname.Text) || string.IsNullOrEmpty(txtbox_Desciption.Text))
            {
                MessageBox.Show(@"Các trường bắt buộc chưa được điền. Vui lòng điền đầy đủ thông tin!");
                return false;
            }
            return true;
        }
    }
}
