﻿using Project_Management.View;
using Project_Management.DAO;
using Project_Management.DTO;
using Project_Management.Utils;
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
    public partial class FormChangePasswordByEmail : Form
    {
        public FormChangePasswordByEmail()
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


        private void btnChange_Click_1(object sender, EventArgs e)
        {
            user user = UserDAO.Instance.GetUserByUserName(UserSession.LoggedInUser.username);
            if (user != null)
            {
                if (CheckPasswordInput())
                {
                    user.password = tbNewpass.Text;
                    UserDAO.Instance.UpdateUser(user);
                    Util.Instance.Alert("Change password success", FormAlert.enmType.Success);
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
