using FullScreenAppDemo;
using FullScreenAppDemo.DAO;
using Project_Management;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;


namespace company_management.View.UC
{
    public partial class UcUser : UserControl
    {

        private int _selectedUserId;
        private user _user;

        public UcUser()
        {
            InitializeComponent();
            LoadData();

        }
        private void ClearAll()
        {
            _user = null;
            txtbox_username.Clear();
            txtbox_fullname.Clear();
            txtbox_email.Clear();
            txtbox_phoneNumber.Clear();
            txtbox_address.Clear();
            btn_Save.Enabled = false;
        }
        private void LoadData()
        {
            LoadDataGridview();
            CheckControlStatus();

        }

        private void LoadDataGridview()
        {
            dataGridView_User.ColumnCount = 6;
            dataGridView_User.Columns[0].Name = "ID";
            dataGridView_User.Columns[0].Visible = false;
            dataGridView_User.Columns[1].Name = "Username";
            dataGridView_User.Columns[2].Name = "Full Name";
            dataGridView_User.Columns[3].Name = "Email";
            dataGridView_User.Columns[4].Name = "PhoneNumber";
            dataGridView_User.Columns[5].Name = "Address";
            dataGridView_User.Rows.Clear();
            List<user> users = UserDAO.Instance.GetALlUser();
            foreach (var x in users)
            {
                dataGridView_User.Rows.Add(x.id, x.username, x.fullName, x.email, x.phoneNumber, x.address);
            }
        }
        private void CheckControlStatus()
        {
            if(UserDAO.Instance.IsManager() || UserDAO.Instance.IsManager())
            {
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btn_Save.Visible = true;
            }
            else
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btn_Save.Visible = false;
            }
        }

        private bool CheckEmptyInput()
        {
            if (string.IsNullOrEmpty(txtbox_username.Text) || string.IsNullOrEmpty(txtbox_fullname.Text) ||
                string.IsNullOrEmpty(txtbox_email.Text) || string.IsNullOrEmpty(txtbox_phoneNumber.Text) ||
                string.IsNullOrEmpty(txtbox_address.Text))
            {
                return false;
            }

            return true;
        }



 

        private void CheckSaveButton()
        {
            if (_user != null)
            {
                if (_user.id != 0)
                {
                    // Và đã có sự thay đổi so với dữ liệu ban đầu thì enable nút Lưu
                    if (txtbox_username.Text != _user.username
                        || txtbox_email.Text != _user.email
                        || txtbox_phoneNumber.Text != _user.phoneNumber
                        || txtbox_fullname.Text != _user.fullName
                        || txtbox_address.Text != _user.address)
                    {
                        btn_Save.Enabled = true;
                    }
                    else
                    {
                        btn_Save.Enabled = false;
                    }
                }
                else if (txtbox_username.Text != ""
                         || txtbox_email.Text != ""
                         || txtbox_phoneNumber.Text != ""
                         || txtbox_fullname.Text != ""
                         || txtbox_address.Text != "")
                {
                    btn_Save.Enabled = true;
                }
                else
                {
                    btn_Save.Enabled = false;
                }
            }
            else
            {
                if (txtbox_username.Text != ""
                    || txtbox_email.Text != ""
                    || txtbox_phoneNumber.Text != ""
                    || txtbox_fullname.Text != ""
                    || txtbox_address.Text != "")
                {
                    btn_Save.Enabled = true;
                }
                else
                {
                    btn_Save.Enabled = false;
                }
            }
        }


        // TextBox changed and leaved event
        private void txtbox_email_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_username_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_fullname_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_phoneNumber_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_address_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        

        private void dataGridView_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridView_User.Rows[e.RowIndex];
                _selectedUserId = (int)selectedRow.Cells[0].Value;
                _user = UserDAO.Instance.GetUserByID(_selectedUserId);
                btn_Save.Enabled = false;

                object value = dataGridView_User.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    DataGridViewRow row = dataGridView_User.Rows[e.RowIndex];

                    // Hiển thị dữ liệu lên các đối tượng TextBox
                    txtbox_username.Text = row.Cells[1].Value.ToString();
                    txtbox_fullname.Text = row.Cells[2].Value.ToString();
                    txtbox_email.Text = row.Cells[3].Value.ToString();
                    txtbox_phoneNumber.Text = row.Cells[4].Value.ToString();
                    txtbox_address.Text = row.Cells[5].Value.ToString();
                }
            }
        }
        private bool CheckDataInput()
        {
            if (CheckEmptyInput())
            {

                if (Util.Instance.IsValidEmail(txtbox_email.Text))
                {
                    if (Util.Instance.IsPhoneNumber(txtbox_phoneNumber.Text))
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
        private void btn_Save_Click(object sender, EventArgs e)
        {

            user user = UserDAO.Instance.GetUserByUserName(txtbox_username.Text);
            if (user != null)
            {
                if (CheckDataInput())
                {
                    user.email = txtbox_email.Text;
                    user.address = txtbox_address.Text;
                    user.fullName = txtbox_fullname.Text;
                    user.phoneNumber = txtbox_phoneNumber.Text;

                    try
                    {
                        UserDAO.Instance.UpdateUser(user);
                        MessageBox.Show("Save user success", @"Message");
                        LoadData();
                    }
                    catch
                    {

                        MessageBox.Show("Save user fail", @"Message");

                    }
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();
            formAddUser.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUserId != 0)
            {
                if (MessageBox.Show(@"Delete user?", @"Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    user user = UserDAO.Instance.GetUserByUserName(txtbox_username.Text);
                    if (user != null)
                    {
                        UserDAO.Instance.DeleteUser(user);
                        MessageBox.Show(@"Delete user success", @"Message");
                        LoadData();
                    }
                    
                }
            }
            else MessageBox.Show(@"User not selected!", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //hello
            string keyword = txtSearch.Text;

            List<user> listUser = UserDAO.Instance.SearchUsers(keyword);
            dataGridView_User.ColumnCount = 6;
            dataGridView_User.Columns[0].Name = "ID";
            dataGridView_User.Columns[0].Visible = false;
            dataGridView_User.Columns[1].Name = "Username";
            dataGridView_User.Columns[2].Name = "Full Name";
            dataGridView_User.Columns[3].Name = "Email";
            dataGridView_User.Columns[4].Name = "PhoneNumber";
            dataGridView_User.Columns[5].Name = "Address";
            dataGridView_User.Rows.Clear();
            foreach (var x in listUser)
            {
                dataGridView_User.Rows.Add(x.id, x.username, x.fullName, x.email, x.phoneNumber, x.address);
            }
        }
    }
}