using FullScreenAppDemo;
using FullScreenAppDemo.DAO;
using Project_Management;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Data;
using System.Windows.Forms;


namespace company_management.View.UC
{
    public partial class UcLeaveRequest : UserControl
    {
        private int _selectedId;
        private int selectedIndex;
        public UcLeaveRequest()
        {

            InitializeComponent();
            Check();
            LoadCB();
            Load();

        }
        void Load()
        {
            LoadRequestsStatistics();
            LoadDataGridview();
        }
        void Check()
        {
            if(UserDAO.Instance.IsEmployee() || UserDAO.Instance.IsLeader())
            {
                buttonRemove.Visible = false;
            }
        }
        private void LoadCB()
        {
            combobox_requestStatusFilter.Items.Add("All");
            combobox_requestStatusFilter.Items.Add("Approved");
            combobox_requestStatusFilter.Items.Add("Pending");
            combobox_requestStatusFilter.Items.Add("Refused");
            combobox_requestStatusFilter.Items.Add("Cancelled");
            combobox_requestStatusFilter.SelectedIndex = 0;
            _selectedId = 0;

        }
        private void LoadRequestsStatistics()
        {
            label_allCount.Text = RequestDAO.Instance.GetALlRequestByPosition().Count.ToString();
            label_approved.Text = RequestDAO.Instance.GetALlApproved().Count.ToString();
            label_rejected.Text = RequestDAO.Instance.GetALlRefuse().Count.ToString();
            label_pending.Text = RequestDAO.Instance.GetALlPending().Count.ToString();
            label_cancelled.Text = RequestDAO.Instance.GetALlCancelled().Count.ToString();
        }
        private void LoadDataGridview()
        {
            List<leaveRequest> lr = new List<leaveRequest>();
            switch (selectedIndex)
            {
                case 0:
                    lr = RequestDAO.Instance.GetALlRequestByPosition();
                    break;
                case 1:
                    lr = RequestDAO.Instance.GetALlApproved();
                    break;
                case 2:
                    lr = RequestDAO.Instance.GetALlPending();
                    break;
                case 3:
                    lr = RequestDAO.Instance.GetALlRefuse();
                    break;
                case 4:
                    lr = RequestDAO.Instance.GetALlCancelled();
                    break;
                default:
                    lr = null;
                    break;
            }

            datagridview_leaveRequest.ColumnCount = 8;
            datagridview_leaveRequest.Columns[0].Name = "Id";
            datagridview_leaveRequest.Columns[0].Visible = false;
            datagridview_leaveRequest.Columns[1].Name = "Fullname";
            datagridview_leaveRequest.Columns[2].Name = "Day create";
            datagridview_leaveRequest.Columns[3].Name = "From day";
            datagridview_leaveRequest.Columns[4].Name = "To day";
            datagridview_leaveRequest.Columns[5].Name = "Total Day";
            datagridview_leaveRequest.Columns[6].Name = "Status";
            datagridview_leaveRequest.Columns[7].Name = "Approver";
            datagridview_leaveRequest.Rows.Clear();


            foreach (leaveRequest rq in lr)
            {
                String approver;
                try
                {
                    user user = UserDAO.Instance.GetUserByID((int)rq.idApprover);
                    approver = user.fullName;
                }
                catch
                {
                    approver = "N/A";
                }

                String writer = UserDAO.Instance.GetUserByID((int)rq.idUser).fullName;
                datagridview_leaveRequest.Rows.Add(rq.id, writer, ((DateTime)rq.requestDate).ToString("d/M/yyyy"),
                   ((DateTime)rq.startDate).ToString("d/M/yyyy"), ((DateTime)rq.endDate).ToString("d/M/yyyy"), rq.numberDay, rq.status,
                   approver);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddRequest requestForm = new FormAddRequest();
            requestForm.ShowDialog();
            Load();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (_selectedId != 0)
            {
                FormViewOrUpdateRequest formRequest = new FormViewOrUpdateRequest(_selectedId);
                formRequest.ShowDialog();
                Load();
            }
            else MessageBox.Show("Choose 1 to edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void datagridview_leaveRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                object value = datagridview_leaveRequest.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    _selectedId = Convert.ToInt32(value);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (_selectedId != 0)
            {
                if (MessageBox.Show(@"Do you want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RequestDAO.Instance.DeleteRequest(_selectedId);
                    Load();
                }
            }
            else MessageBox.Show(@"Please, choose 1 to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void combobox_requestStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            selectedIndex = combobox_requestStatusFilter.SelectedIndex;
            
            LoadDataGridview();
        }
    }
}
