using Project_Management;
using Project_Management.DAO;
using Project_Management.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Project_Management.View.UC
{
    public partial class UcTimeKeeping : UserControl
    {
        private int LastCheckinCheckoutId;
        private int selectindex;
        checkin_checkout cico;
        private int selectindexthang;

        public Color DeepSkyBlue { get; private set; }

        public UcTimeKeeping()
        {
            InitializeComponent();
            LoadCB();
            check();
            LoadTimeNow();


        }
        void Load()
        {
            LoadData();
            LoadTimeWorking();
        }
        private void LoadTimeNow()
        {
            datetime_date.Value = DateTime.Now.Date;
            datetime_Checkin.Value = DateTime.Now;
            datetime_Checkout.Value = DateTime.Now;
            datetime_date.Enabled = false;
            datetime_Checkin.Enabled = false;
            datetime_Checkout.Enabled = false;
        }

        void LoadTimeWorking()
        {
            List<checkin_checkout> listCiCo = CheckIn_CheckOutDAO.Instance.GetCICOByIDUser(UserSession.LoggedInUser.id, selectindexthang);
            if (listCiCo != null)
            {
                label_totalDate.Text = listCiCo.Count.ToString();
                float totaltime = 0;
                float timeleave = 0;
                float ot = 0;
                foreach (checkin_checkout c in listCiCo)
                {
                    if (c.totalHours != null)
                    {
                        totaltime += (float)c.totalHours;
                        if (c.totalHours < 8)
                            timeleave += (8 - (float)c.totalHours);
                        else
                        {
                            ot += ((float)c.totalHours - 8);
                        }
                    }
                }
                label_totalHours.Text = totaltime.ToString();
                label_leaveHours.Text = timeleave.ToString();
                label_overtimeHours.Text = ot.ToString();
            }
        }
        void LoadCB()
        {
            for (int i = 1; i <= 12; i++)
                CbThang.Items.Add(i);
            CbThang.SelectedIndex = DateTime.Now.Month - 1;


            List<user> user = UserDAO.Instance.GetAllUser();
            cb_changeUser.Items.Add("All user");
            foreach (user u in user)
                cb_changeUser.Items.Add(u);
            cb_changeUser.DisplayMember = "fullname";
            cb_changeUser.SelectedIndex = 0;
        }
        void check()
        {
            cico = CheckIn_CheckOutDAO.Instance.GetCICOByDate(DateTime.Now);
            if (cico != null)
            {
                btnCheckIn.Text = "Check out";
                btnCheckIn.FillColor = Color.DarkRed;

            }
        }
        void LoadData()
        {

            List<checkin_checkout> listCiCo = new List<checkin_checkout>();
            if (UserDAO.Instance.IsHumanResources())
            {
                switch (selectindex)
                {
                    case 0:
                        listCiCo = CheckIn_CheckOutDAO.Instance.GetAllCICO(selectindexthang);
                        break;
                    default:
                        listCiCo = CheckIn_CheckOutDAO.Instance.GetCICOByIDUser((cb_changeUser.SelectedItem as user).id, selectindexthang);
                        break;
                }
            }
            else
            {
                buttonRemove.Visible = false;
                cb_changeUser.Visible = false;
                listCiCo = CheckIn_CheckOutDAO.Instance.GetCICOByIDUser(UserSession.LoggedInUser.id, selectindexthang);
            }
            datagridview_timeKeeping.ColumnCount = 6;
            datagridview_timeKeeping.Columns[0].Name = "ID";
            datagridview_timeKeeping.Columns[0].Visible = false;
            datagridview_timeKeeping.Columns[1].Name = "Fullname";
            datagridview_timeKeeping.Columns[2].Name = "Checkin Time";
            datagridview_timeKeeping.Columns[3].Name = "Checkout Time";
            datagridview_timeKeeping.Columns[3].DefaultCellStyle.NullValue = "";
            datagridview_timeKeeping.Columns[4].Name = "Total time";
            datagridview_timeKeeping.Columns[5].Name = "Date";
            datagridview_timeKeeping.Rows.Clear();


            foreach (checkin_checkout c in listCiCo)
            {
                string fullName = UserDAO.Instance.GetUserByID(c.idUser).fullName;

                var checkoutTime = c.checkoutTime != null ? ((DateTime)c.checkoutTime).ToString("HH:mm:ss") : "N/A";

                datagridview_timeKeeping.Rows.Add(c.id, fullName, c.checkinTime.ToString("HH:mm:ss"), checkoutTime, c.totalHours,
                    ((DateTime)c.date).ToString("yyyy/MM/dd"));
            }
        }

        private void datagridview_timeKeeping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = datagridview_timeKeeping.Rows[e.RowIndex];
                LastCheckinCheckoutId = (int)selectedRow.Cells[0].Value;


                checkin_checkout cico = CheckIn_CheckOutDAO.Instance.GetCICOByID(LastCheckinCheckoutId);

                user user = UserDAO.Instance.GetUserByID(cico.idUser);
                txtBox_fullName.Text = user.fullName;
                txtBox_totalHours.Text = cico.totalHours.ToString() + " h";
                datetime_date.Value = (DateTime)cico.date;
                datetime_Checkin.Value = (DateTime)cico.checkinTime;
                if (cico.checkoutTime != default)
                    datetime_Checkout.Value = (DateTime)cico.checkoutTime;
                else
                    datetime_Checkout.Value = DateTime.Now;
                // Bấm vào một hàng là mặc định giờ checkin được chọn


                // Check xem có checkout hay chưa (giá trị mặc định là DateTime.MinVal)

            }
        }

        private void cb_changeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectindex = cb_changeUser.SelectedIndex;
            Load();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (btnCheckIn.Text == "Check in")
            {
                checkin_checkout ci = new checkin_checkout();
                ci.date = DateTime.Now;
                ci.checkinTime = DateTime.Now;
                ci.idUser = UserSession.LoggedInUser.id;
                CheckIn_CheckOutDAO.Instance.AddCICO(ci);
                check();
            }
            else
            {
                if (MessageBox.Show("Do you want to checkout?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cico.checkoutTime = DateTime.Now;
                    DateTime d1 = (DateTime)cico.checkoutTime;
                    DateTime d2 = cico.checkinTime;
                    cico.totalHours = Math.Round((d1 - d2).TotalHours, 2);
                    CheckIn_CheckOutDAO.Instance.UpdateCICO(cico);
                }
            }
            Load();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (LastCheckinCheckoutId != 0)
            {
                DialogResult result = MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CheckIn_CheckOutDAO.Instance.DeleteCheckinCo(LastCheckinCheckoutId);
                    LoadData();
                }
            }
            else MessageBox.Show("Choose 1 cho delete!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectindexthang = CbThang.SelectedIndex + 1;
            Load();
        }

    }
}
