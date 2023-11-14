using Project_Management.View.UC;
using Project_Management.DAO;
using Project_Management.DTO;
using Project_Management;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


// ReSharper disable All

namespace Project_Management.View
{
    public partial class FormViewOrUpdateRequest : Form
    {
        private leaveRequest _leaveRequest;

        public FormViewOrUpdateRequest(int id)
        {
            InitializeComponent();
            _leaveRequest = RequestDAO.Instance.GetRequestById(id);
            Load();
        }

        void Load()
        {
            LoadCB();
            LoadData();
        }
        void LoadCB()
        {
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
            {
                if (_leaveRequest.status == "Pending")
                {
                    combobox_status.Items.Add("Approve");
                    combobox_status.Items.Add("Refuse");
                }
                else
                {
                    label_approved.Visible = false;
                    combobox_status.Visible = false;
                    button_save.Text = "Exit";
                    datetime_endDate.Enabled = false;
                    datetime_startDate.Enabled = false;
                    datetime_requestDate.Enabled = false;
                    if (_leaveRequest.status == "Cancelled")
                        button_Cancel.Visible = false;
                }
            }
            else
            {
                label_approved.Visible = false;
                combobox_status.Visible = false;
                if (_leaveRequest.status == "Pending")
                    button_save.Text = "Update";
                else
                    button_save.Text = "Exit";
                button_Cancel.Visible = false;
                datetime_requestDate.Enabled = false;
            }
        }

        void LoadData()
        {
            user user = UserDAO.Instance.GetUserByID((int)_leaveRequest.idUser);
            picturebox_writer.Image = ByteArrayToImage(user.avatar);
            txtbox_content.Text = _leaveRequest.content;
            datetime_requestDate.Value = (DateTime)_leaveRequest.requestDate;
            datetime_startDate.Value = (DateTime)_leaveRequest.startDate;
            datetime_endDate.Value = (DateTime)_leaveRequest.endDate;
            label_numberDay.Text = _leaveRequest.numberDay.ToString();
            label_status.Text = _leaveRequest.status;

            if (_leaveRequest.status != "Pending" && (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager()))
            {
                try
                {
                    user user1 = UserDAO.Instance.GetUserByID((int)_leaveRequest.idApprover);
                    picturebox_approver.Image = ByteArrayToImage(user1.avatar);
                    label_approver.Text = "Approved by " + user1.fullName;
                }
                catch { }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (button_save.Text == "Approve")
            {
                String status = "Pending";
                switch (combobox_status.SelectedIndex)
                {
                    case 0:
                        status = "Approved";
                        break;
                    case 1:
                        status = "Refused";
                        break;

                }
                _leaveRequest.idApprover = UserSession.LoggedInUser.id;
                _leaveRequest.status = status;
                RequestDAO.Instance.UpdateRequest(_leaveRequest);
                Load();
            }
            else if(button_save.Text == "Update")
            {
                _leaveRequest.requestDate = DateTime.Now;
                _leaveRequest.startDate = datetime_startDate.Value;
                _leaveRequest.endDate = datetime_endDate.Value;
                _leaveRequest.content = txtbox_content.Text;
                _leaveRequest.numberDay = (datetime_endDate.Value - datetime_startDate.Value).Days;
                RequestDAO.Instance.UpdateRequest(_leaveRequest);
                Load();
            }    
            else
            {
                this.Close();
            }
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

        private void combobox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            user user = UserDAO.Instance.GetUserByID(UserSession.LoggedInUser.id);
            picturebox_approver.Image = ByteArrayToImage(user.avatar);

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            _leaveRequest.status = "Cancelled";
            _leaveRequest.idApprover = UserSession.LoggedInUser.id;
            RequestDAO.Instance.UpdateRequest(_leaveRequest);
        }

        private void datetime_startDate_ValueChanged(object sender, EventArgs e)
        {
            label_numberDay.Text = (datetime_endDate.Value - datetime_startDate.Value).Days.ToString();
        }

        private void datetime_endDate_ValueChanged(object sender, EventArgs e)
        {
            label_numberDay.Text = (datetime_endDate.Value - datetime_startDate.Value).Days.ToString();
        }
    }
}