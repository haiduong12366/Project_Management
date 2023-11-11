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
        public FormAddTask()
        {
            InitializeComponent();
            Load();
        }

        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_taskName.Text) || string.IsNullOrEmpty(txtbox_Desciption.Text))
            {
                MessageBox.Show(@"Các trường bắt buộc chưa được điền. Vui lòng điền đầy đủ thông tin!");
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

        private void CheckControlStatusForEmployee()
        {
            UserDAO.Instance.CheckEmployeeIsReadOnlyStatus(textBox_Bonus);
        }
        private void Load()
        {
            txtBox_cretor.Text = UserSession.LoggedInUser.fullName;
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
                int idTeam = (combbox_Assignee.SelectedItem as team).id;
                TeamDAO _teamDao = new TeamDAO();
                int idAssigee = _teamDao.GetLeaderIDByTeamID(idTeam);
                int idproject = (combbox_Project.SelectedItem as project).id;
                float bonus = (float)Convert.ToInt32(textBox_Bonus.Text);
                TaskDAO.Instance.AddTask(txtbox_taskName.Text, txtbox_Desciption.Text,
                                              dateTime_deadline.Value, idTeam, idAssigee, idproject, bonus);

                ClearFields();
            }
            StackForm.FormMain.ChildForm.AddUc(new UcTask());

        }

        private void combbox_Assignee_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            StackForm.FormMain.ChildForm.AddUc(new UcTask());
        }
    }
}
