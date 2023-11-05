using FullScreenAppDemo.DAO;
using FullScreenAppDemo.DTO;
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

namespace FullScreenAppDemo
{
    public partial class FormAddTask : Form
    {
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
        
        private void GetDataToCombobox(ComboBox assignees)
        {
            List<team> list = TeamDAO.Instance.GetTeamByID();
            assignees.DataSource = list;
            assignees.DisplayMember = "name";
            assignees.SelectedIndex = 0;

            
        }

        private void CheckControlStatusForEmployee()
        {
            UserDAO.Instance.CheckEmployeeIsReadOnlyStatus(textBox_Bonus);
        }
        private void Load()
        {
            txtBox_cretor.Text = UserSession.LoggedInUser.fullName;
            GetDataToCombobox(combbox_Assignee);
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
                int idAssigee = (combbox_Assignee.SelectedItem as team).id;
                int idproject = (combbox_Project.SelectedItem as project).id;
                float bonus = (float)Convert.ToInt32(textBox_Bonus.Text);
                TaskDAO.Instance.AddTask(txtbox_taskName.Text, txtbox_Desciption.Text,
                                              dateTime_deadline.Value, idAssigee, idproject,bonus );
                ClearFields();
            }
        }

        private void combbox_Assignee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (combbox_Assignee.SelectedItem as team).id;
            List<project> list = ProjectDAO.Instance.GetProjectByTeam(id);

            combbox_Project.DataSource = list;
            combbox_Project.DisplayMember = "name";
            combbox_Project.SelectedIndex = 0;

        }
    }
}
