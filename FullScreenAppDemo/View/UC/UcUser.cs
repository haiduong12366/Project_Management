using FullScreenAppDemo;
using FullScreenAppDemo.DAO;
using Project_Management;
using System;
using System.Collections.Generic;
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
            dataGridView_User.Columns[0].Name = "Mã";
            dataGridView_User.Columns[0].Visible = false;
            dataGridView_User.Columns[1].Name = "Tên tài khoản";
            dataGridView_User.Columns[2].Name = "Họ và tên";
            dataGridView_User.Columns[3].Name = "Email";
            dataGridView_User.Columns[4].Name = "Số điện thoại";
            dataGridView_User.Columns[5].Name = "Địa chỉ";
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
    }
}