
using company_management.View;
using FullScreenAppDemo.DAO;
using FullScreenAppDemo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullScreenAppDemo
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
                MessageBox.Show(@"Tên đăng nhập hoặc mật khẩu không được để trống!");
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

                    // Lấy thông tin người dùng đăng nhập
                    //loginUser = _userDao.GetUserByUsername("edalziell2"); // manager
                    //loginUser = _userDao.GetUserByUsername("chhinhua"); // manager


                    // Human Resources
                    loginUser = UserDAO.Instance.GetUserByUserName(username);


                    UserSession.LoginUser(loginUser);

                    FormAddRequest main = new FormAddRequest();
                    this.Hide();
                    main.ShowDialog();
                    
                    this.Show();
                    
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");

                }
            }

        }
    }
}
