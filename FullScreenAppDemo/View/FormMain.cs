using company_management.View.UC;
using FullScreenAppDemo;
using FullScreenAppDemo.DTO;
using FullScreenAppDemo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Management.View
{
    public partial class FormMain : Form
    {


        public FormMain()
        {
            InitializeComponent();

        }

        private void AddUc(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;

            pn_main.Controls.Clear();
            pn_main.Controls.Add(uc);

            uc.BringToFront();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnTask.Location.X, btnTask.Location.Y);
            UcTask uCTask = new UcTask();
            AddUc(uCTask);
        }

        private void btnLeaveRequest_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnLeaveRequest.Location.X, btnLeaveRequest.Location.Y);
            UcLeaveRequest request = new UcLeaveRequest();
            AddUc(request);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnSalary.Location.X, btnSalary.Location.Y);
            UcSalary uCSalary = new UcSalary();
            AddUc(uCSalary);
        }

        private void btnTimekeeping_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnTimekeeping.Location.X, btnTimekeeping.Location.Y);
            UcTimeKeeping timeKeeping = new UcTimeKeeping();
            AddUc(timeKeeping);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnUser.Location.X, btnUser.Location.Y);
            UcUser userManagementUC = new UcUser();
            AddUc(userManagementUC);
        }

        public void LoadUserControl()
        {
            this.lb_menu_active.Location = new Point(btnUser.Location.X, btnUser.Location.Y);
            UcTask uCTask = new UcTask();
            AddUc(uCTask);
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnTeam.Location.X, btnTeam.Location.Y);
            UcTeam uC_Team = new UcTeam();
            AddUc(uC_Team);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Teal;
            this.lb_menu_active.Location = new Point(btnHome.Location.X, btnHome.Location.Y);
            UcHome uCHome = new UcHome();
            AddUc(uCHome);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            this.lb_menu_active.Location = new Point(btnProject.Location.X, btnProject.Location.Y);
            UcProject uC_Project = new UcProject();
            AddUc(uC_Project);
        }



        private void combobox_user_action_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = combobox_user_action.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    FormViewProfile viewProfile = new FormViewProfile();
                    viewProfile.ShowDialog();
                    break;
                case 1:
                   
                    break;
                case 2:
                   
                    break;
                case 3:
                    this.Hide();
                    FormLogin login = new FormLogin();
                    login.Show();
                    
                    UserSession.LogoutUser();
                    break;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UcHome uCHome = new UcHome();
            AddUc(uCHome);
        }
    }
}
