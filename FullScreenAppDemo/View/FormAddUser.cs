using FullScreenAppDemo.DAO;
using FullScreenAppDemo.DTO;
using Project_Management;
using Project_Management.DAO;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullScreenAppDemo
{
    public partial class FormAddUser : Form
    {
        byte[] pic = null;
        public FormAddUser()
        {
            InitializeComponent();
            Load();
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        private bool CheckDataInput()
        {
            if (CheckEmptyInput())
            {

                if (Util.Instance.IsValidEmail(tbEmail.Text))
                {
                    if (Util.Instance.IsPhoneNumber(tbPhone.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(@"Invalid phone number!", @"Message");
                    }
                }
                else
                {
                    MessageBox.Show(@"Invalid email!", @"Message");
                }
            }
            else
            {
                MessageBox.Show(@"Required fields Empty. Please fill in all fields!", @"Message");
            }

            return false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckEmptyInput()
        {
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbFullname.Text) ||
                string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbPhone.Text) ||
                string.IsNullOrEmpty(tbAddress.Text) || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbRePassword.Text))
            {
                return false;
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (tbRePassword.Text != tbPassword.Text)
                    MessageBox.Show("Repassword not equal password");
                else
                {
                    user user = new user();
                    user.username = tbUsername.Text;
                    user.email = tbEmail.Text;
                    user.address = tbAddress.Text;
                    user.fullName = tbFullname.Text;
                    user.phoneNumber = tbPhone.Text;
                    user.avatar = pic;
                    user.password = tbPassword.Text;
                    user.idPosition = (cbRole.SelectedItem as position).id;
                    if (user.idPosition == 1)
                    {
                        UserDAO.Instance.AddUser(user);
                        MessageBox.Show("Add manager success", "Message");
                    }
                    else if (user.idPosition == 4)
                    {
                        UserDAO.Instance.AddUser(user);
                        MessageBox.Show("Add HR success", "Message");
                    }
                    else if (user.idPosition == 3)
                    {
                        int idteam = (cb_team.SelectedItem as team).id;

                        UserDAO.Instance.AddUser(user);
                        User_teamDAO.Instance.AddUser_Team(user.username, idteam);

                        MessageBox.Show("Add employee success", "Message");
                    }
                    else
                    {
                        int idteam = (cb_team.SelectedItem as team).id;

                        UserDAO.Instance.AddUser(user);
                        User_teamDAO.Instance.AddUser_Team(user.username, idteam);
                        TeamDAO.Instance.UpdateLeader(idteam, user.username);
                        MessageBox.Show("Add leader success", "Message");
                    }

                }
            }

        }
        void Load()
        {
            LoadComboBox();
        }
        void LoadComboBox()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                cbRole.DataSource = entity.positions.ToList<position>();
                cbRole.DisplayMember = "name";
                cbRole.SelectedIndex = 0;
            }
        }
        private void btnUpdateAvatar_Click(object sender, EventArgs e)
        {
            ODL.Title = "Image";
            ODL.Filter = "Image|*.png;*.jpg;*.gif";
            if (ODL.ShowDialog() == DialogResult.OK)
            {
                pic = ImageToByteArray(Image.FromFile(ODL.FileName));
                PbAvatar.Image = ByteArrayToImage(pic);
                ODL.Dispose();//thu hồi bộ nhớ
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                int idRole = (cbRole.SelectedItem as position).id;
                if (idRole == 1 || idRole == 4)
                {
                    lbTeam.Visible = false;
                    cb_team.Visible = false;
                }
                else
                {
                    cb_team.DataSource = entity.teams.ToList<team>();
                    cb_team.DisplayMember = "name";
                    lbTeam.Visible = true;
                    cb_team.Visible = true;
                }
            }
        }


    }
}
