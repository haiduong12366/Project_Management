
using Project_Management.View;
using Project_Management.DAO;
using Project_Management.DTO;
using Project_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(@"Username and password not allow empty!");
                return false;
            }
            return true;
        }

        private bool ValidateLogin(string username, string password)
        {
            // Kiểm tra thông tin đăng nhập ở đây
            user loginUser = UserDAO.Instance.GetUserByUserName(username);
            if (loginUser == null)
                return false;
            else if (loginUser.password.Equals(password))
                return true;
            else
                return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Kiểm tra thông tin đăng nhập
                if (ValidateLogin(username, password))
                {
                    user loginUser;
                    loginUser = UserDAO.Instance.GetUserByUserName(username);


                    UserSession.LoginUser(loginUser);

                    FormMain main = new FormMain();
                    this.Hide();
                    main.ShowDialog();
                    this.Show();

                    
                }
                else
                {
                    MessageBox.Show("Incorrect username!");

                }
            }

        }

        private void lbForgotPass_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            this.Hide();
            formForgotPassword.ShowDialog();
            this.Show();
        }
    }
}
