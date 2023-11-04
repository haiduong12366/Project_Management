using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace company_management.View.UC
{
    public partial class UcUser : UserControl
    {

        private int _selectedUserId;


        public UcUser()
        {
            InitializeComponent();

        }

        private void UcUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void LoadData()
        {
            LoadDataGridview();
            CheckControlStatus();
        }

        private void LoadDataGridview()
        {

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

        private void ClearAll()
        {
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
        }

        private void CheckSaveButton()
        {
            
        }

        private void CheckControlStatus()
        {
            
        }

        // TextBox changed and leaved event
        private void txtbox_email_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_username_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_fullname_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_phoneNumber_TextChanged(object sender, EventArgs e) => CheckSaveButton();

        private void txtbox_address_TextChanged(object sender, EventArgs e) => CheckSaveButton();
    }
}