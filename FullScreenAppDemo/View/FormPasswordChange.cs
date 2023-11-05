using FullScreenAppDemo.DAO;
using FullScreenAppDemo.DTO;
using Project_Management;
using System;
using System.Windows.Forms;
// ReSharper disable All

namespace company_management.View
{
    public partial class FormPasswordChange : Form
    {
        public FormPasswordChange()
        {
            InitializeComponent();
        }

        private bool CheckPasswordInput()
        {
            if (!string.IsNullOrEmpty(tbNewpass.Text) && !string.IsNullOrEmpty(tbConfirmpass.Text))
            {
                if (tbNewpass.Text.Equals(tbConfirmpass.Text))
                {
                    return true;
                }
                MessageBox.Show("Password and repassword is not equal!");
            }
            MessageBox.Show("Password and repassword is not empty!");

            return false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            user user = UserDAO.Instance.GetUserByIdAndPassWord(tbOldPass.Text);
            if (user != null)
            {
                if (CheckPasswordInput())
                {
                    user.password = tbNewpass.Text;
                    UserDAO.Instance.UpdateUser(user);
                    MessageBox.Show("Change password success");
                    UserSession.LogoutUser();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }
    }
}
