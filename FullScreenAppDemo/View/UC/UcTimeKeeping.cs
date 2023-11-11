using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Project_Management.View.UC
{
    public partial class UcTimeKeeping : UserControl
    {

        public static int LastCheckinCheckoutId;

        public UcTimeKeeping()
        {
            InitializeComponent();
 
        }

        private void UCTimeKeeping_Load(object sender, EventArgs e)
        {

        }




        
        private void LoadTimeNow()
        {
            datetime_date.Value = DateTime.Now.Date;
            datetime_Checkin.Value = DateTime.Now;
            datetime_Checkout.Value = DateTime.Now;

            toggle_checkout.Checked = false;
        }


        
        private void ClearAll()
        {
            LastCheckinCheckoutId = 0;
            txtBox_fullName.Clear();
            txtBox_totalHours.Clear();
            toggle_checkin.Checked = false;
            toggle_checkout.Checked = false;
            toggle_checkin.Enabled = true;
            toggle_checkout.Enabled = true;
            LoadTimeNow();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void toggle_checkin_Click(object sender, EventArgs e)
        {
            
        }

        private void toggle_checkout_Click(object sender, EventArgs e)
        {

           
        }

        private void datagridview_timeKeeping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
