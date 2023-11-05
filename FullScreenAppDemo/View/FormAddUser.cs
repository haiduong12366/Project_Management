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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        void Load()
        {
            tbUsername.Text = UserSession.LoggedInUser.username;
            tbEmail.Text = UserSession.LoggedInUser.email;
        }
    }
}
