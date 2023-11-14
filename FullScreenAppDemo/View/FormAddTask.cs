using Project_Management.DAO;
using Project_Management.DTO;
using Project_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Management.Utils;
using Project_Management.View.UC;

namespace Project_Management.view
{
    public partial class FormAddTask : Form
    {

        private int idTask = 0;
        private UserDAO _userDAO = new UserDAO();
        public FormAddTask()
        {
            InitializeComponent();
            Load();
        }

        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_taskName.Text))
            {
                MessageBox.Show(@"Task name must not be empty!!!!");
                return false;
            }
            if (string.IsNullOrEmpty(txtbox_Desciption.Text))
            {
                MessageBox.Show(@"Task description must not be empty!!!!");
                return false;
            }
            try
            {
                float bonus = (float)Convert.ToDouble(textBox_Bonus.Text);
                if(bonus < 0)
                {
                    MessageBox.Show(@"Bonus cannot be less than 0!!!");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show(@"Bonus must be a numeric value!!!");
                return false;
            }
            if (dateTime_deadline.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show(@"The chosen dealine is not suitable!!!");
                return false;
            }

            return true;
        }
        private void ClearFields()
        {
            txtbox_taskName.Clear();
            txtbox_Desciption.Clear();
        }
        
        private void GetDataToCombobox(ComboBox assignees, int selected)
        {
            List<team> list = TeamDAO.Instance.GetTeamByManagerOrLeader();
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

        private void CheckControlStatusForEmployee()
        {
            UserDAO.Instance.CheckEmployeeIsReadOnlyStatus(textBox_Bonus);
        }
        private void Load()
        {

            if (!_userDAO.IsLeader())
            {
                labAssigneesUser.Visible = false; 
                combbox_UserOfTeam.Visible = false;
            }
            GetDataToCombobox(combbox_Assignee, -1);

            CheckControlStatusForEmployee();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                TeamDAO _teamDao = new TeamDAO();
                int idTeam = (combbox_Assignee.SelectedItem as team).id;

                int idAssigee;
                if (!_userDAO.IsLeader())
                {
                    idAssigee = _teamDao.GetLeaderIDByTeamID(idTeam);
                }
                else
                {
                    idAssigee = (combbox_UserOfTeam.SelectedItem as user).id;
                }

                int idproject = (combbox_Project.SelectedItem as project).id;
                double bonus = Math.Round((double)Convert.ToDouble(textBox_Bonus.Text), 3);

                TaskDAO.Instance.AddTask(txtbox_taskName.Text, txtbox_Desciption.Text,
                                              dateTime_deadline.Value, idTeam, idAssigee, idproject, bonus);

                ClearFields();
                StackForm.FormMain.ChildForm.AddUc(new UcTask());
            }

        }

        private void combbox_Assignee_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idTeam = (combbox_Assignee.SelectedItem as team).id;
            List<project> list = ProjectDAO.Instance.GetProjectByTeam(idTeam);

            combbox_Project.DataSource = list;
            combbox_Project.DisplayMember = "name";
            if (combbox_Project.Items.Count > 0)
            {
                combbox_Project.SelectedIndex = 0;
            }
            if (_userDAO.IsLeader())
            {
                List<user> listUser = UserDAO.Instance.GetUsersByTeamID(idTeam);
                combbox_UserOfTeam.DataSource = listUser;
                combbox_UserOfTeam.DisplayMember = "fullName";
                combbox_UserOfTeam.SelectedIndex = 0;
            }      
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            StackForm.FormMain.ChildForm.AddUc(new UcTask());
        }

        private void combbox_UserOfTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
