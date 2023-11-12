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
using System.Web.UI.WebControls;

namespace Project_Management.View
{
    public partial class FormViewOrUpdateTask: Form
    {
        private int idTask = 0;
        private Boolean isView = false;

        private TeamDAO _teamDao = new TeamDAO();
        private UserDAO _userDao = new UserDAO();
        private ImageDAO _imageDAO = new ImageDAO();
        private ProjectDAO _projectDao = new ProjectDAO();



        public FormViewOrUpdateTask()
        {
            InitializeComponent();
        }

        public FormViewOrUpdateTask(task infoTask, Boolean isView)
        {
            this.isView = isView;
            this.idTask = infoTask.id;
            InitializeComponent();
            BindingImageToFields(infoTask);

            if (isView)
            {

                gboxTask.Text = "View Task";

                txtbox_Taskname.Text = infoTask.taskName;
                txtbox_Desciption.Text = infoTask.description;

                if (infoTask.idTeam != null)
                {
                    combbox_AssigneeTeam.Items.Add(_teamDao.GetNameTeamByID((int)infoTask.idTeam));
                    combbox_AssigneeTeam.SelectedIndex = 0;
                }

                if (infoTask.idProject != null)
                {
                    combbox_Project.Items.Add(_projectDao.GetNameProjectByID((int)infoTask.idProject));
                    combbox_Project.SelectedIndex = 0;
                }

                if(infoTask.idAssignee != null)
                {
                    combbox_AssigneePerson.Items.Add(_userDao.GetUserByID((int)infoTask.idAssignee));
                    combbox_AssigneePerson.DisplayMember = "fullName";
                    combbox_AssigneePerson.SelectedIndex = 0;
                }

                int index = combobox_progress.FindStringExact(infoTask.progress.ToString());
                if (index != -1)
                {
                    combobox_progress.SelectedIndex = index;
                }

                dateTime_deadline.Value = (DateTime)infoTask.deadline;

                if (infoTask.bonus != null)
                {
                    textBox_Bonus.Text = ((float)infoTask.bonus).ToString("C");
                }

                combobox_progress.Items.Clear();
                combobox_progress.Items.Add(infoTask.progress.ToString());
                combobox_progress.SelectedIndex = 0;  

                circleProgressBar.Value = (int)infoTask.progress;
                progressValue.Text = infoTask.progress + @"%";

                txtbox_Taskname.ReadOnly = true;
                txtbox_Desciption.ReadOnly = true;
                textBox_Bonus.ReadOnly = true;
                dateTime_deadline.MinDate = dateTime_deadline.Value;
                dateTime_deadline.MaxDate = dateTime_deadline.Value;
                dateTime_deadline.ShowUpDown = true;

                btnSave.Hide();
            }
            else
            {
                Load(infoTask);
                this.idTask = infoTask.id;
                ProjectDAO _projectDao = new ProjectDAO();

                gboxTask.Text = "Update Task";

                txtbox_Taskname.Text = infoTask.taskName;
                txtbox_Desciption.Text = infoTask.description;

                string nameTeam = _teamDao.GetNameTeamByID((int)infoTask.idTeam);

                if (infoTask.idTeam != null)
                {
                    GetDataToCombobox(combbox_AssigneeTeam, (int)infoTask.idTeam);
                }
                else
                {
                    GetDataToCombobox(combbox_AssigneeTeam, -1);
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

                index = combbox_Project.FindStringExact(_projectDao.GetNameProjectByID((int)infoTask.idProject));
                if (index != -1)
                {
                    combbox_Project.SelectedIndex = index;
                }

                index = combbox_AssigneePerson.FindStringExact(_userDao.GetUserByID((int)infoTask.idAssignee).fullName.ToString());
                if (index != -1)
                {
                    combbox_AssigneePerson.SelectedIndex = index;
                }

                circleProgressBar.Value = (int)infoTask.progress;
                progressValue.Text = infoTask.progress + @"%";

            }
        }

        private void Load(task infoTask)
        {
            GetDataToCombobox(combbox_AssigneeTeam, -1);
            BindingImageToFields(infoTask);
        }

        private void BindingImageToFields(task infoTask)
        {
            if(infoTask.idTeam != null)
            {
                team assigneeTeam = _teamDao.GetTeamByID((int)infoTask.idTeam);
                _imageDAO.ShowImageInPictureBox(assigneeTeam.avatar, picturebox_teamAvatar);
            }
            if(infoTask.idAssignee != null)
            {
                user assigneeUser = _userDao.GetUserByID((int)infoTask.idAssignee);
                _imageDAO.ShowImageInPictureBox(assigneeUser.avatar, picturebox_userAvatar);
            }
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
                int idTeam = (combbox_AssigneeTeam.SelectedItem as team).id;
                List<project> list = ProjectDAO.Instance.GetProjectByTeam(idTeam);

                combbox_Project.DataSource = list;
                combbox_Project.DisplayMember = "name";
                if (combbox_Project.Items.Count > 0)
                {
                    combbox_Project.SelectedIndex = 0;
                }

                List<user> listUser = UserDAO.Instance.GetUsersByTeamID(idTeam);
                combbox_AssigneePerson.DataSource = listUser;
                combbox_AssigneePerson.DisplayMember = "fullName";
                combbox_AssigneePerson.SelectedIndex = 0;
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
                int idTeam = (combbox_AssigneeTeam.SelectedItem as team).id;

                int idAssigee;
                idAssigee = (combbox_AssigneePerson.SelectedItem as user).id;

                int idproject = (combbox_Project.SelectedItem as project).id;
                double bonus = Math.Round((double)Convert.ToDouble(textBox_Bonus.Text), 3);
                int progress = int.Parse(combobox_progress.SelectedItem.ToString());

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
            try
            {
                float bonus = (float)Convert.ToDouble(textBox_Bonus.Text);
                if (bonus < 0)
                {
                    MessageBox.Show(@"Bonus nhỏ hơn 0???");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show(@"Bonus không phải giá trị số!!!");
                return false;
            }
            if (dateTime_deadline.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show(@"Deadling bạn chọn không phù hợp!!!");
                return false;
            }
            return true;
        }

        private void combbox_AssigneePerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idUser = (combbox_AssigneePerson.SelectedItem as user).id;
            user assigneeUser = _userDao.GetUserByID(idUser);
            _imageDAO.ShowImageInPictureBox(assigneeUser.avatar, picturebox_userAvatar);
        }
    }
}
