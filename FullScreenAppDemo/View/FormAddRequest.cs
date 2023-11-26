using Project_Management.DAO;
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
    public partial class FormAddRequest : Form
    {
        public FormAddRequest()
        {
            InitializeComponent();
            LoadTimeNow();
        }

        private void ClearFields()
        {
            txtbox_content.Clear();
        }
        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(txtbox_content.Text))
            {
                MessageBox.Show("Please fill out all text!");
                return false;
            }
            return true;
        }
        private void LoadTimeNow()
        {
            datetime_startDate.Value = DateTime.Now.Date;
            datetime_requestDate.Value = DateTime.Now.Date;
            datetime_endDate.Value = DateTime.Now.AddDays(1);
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                int check = (datetime_endDate.Value - datetime_startDate.Value).Days;
                if(check <0)
                {
                    MessageBox.Show("Invalid date", "Error");
                    return;
                }
                if (RequestDAO.Instance.AddRequest(datetime_startDate.Value, datetime_endDate.Value, datetime_requestDate.Value, txtbox_content.Text))
                {
                    ClearFields();
                    this.Close();
                }
                
            }
            
        }


    }
}
