using Project_Management.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project_Management.Utils;
using System.Globalization;

// ReSharper disable All

namespace Project_Management.View.UC
{
    public partial class UcSalary : UserControl
    {
        private readonly Lazy<SalaryDAO> _salaryDao;
        private readonly Lazy<UserDAO> _userDao;
        private salary selectedSalary = null;

        public UcSalary()
        {
            InitializeComponent();
            _salaryDao = new Lazy<SalaryDAO>(() => new SalaryDAO());
            _userDao = new Lazy<UserDAO>(() => new UserDAO());
            combobox_month.SelectedIndex = 0;
            combobox_year.SelectedIndex = 0;
        }

        private void UCSalary_Load(object sender, EventArgs e)
        {
            LoadDataToDataGirdView(GetData(), datagridview_salary);
            if (_userDao.Value.IsHumanResources())
            {
                btn_caculateSalary.Visible = true;
            }
            else
            {
                btn_caculateSalary.Visible = false;
            }
        }

        private List<salary> GetData()
        {
            return _salaryDao.Value.GetListSalaryByPosition();
        }

        private void LoadDataToDataGirdView(List<salary> salaryList, DataGridView dataGridView) 
        {
            dataGridView.ColumnCount = 13;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Name = "Full name";
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].Name = "Basic salary";
            dataGridView.Columns[3].Name = "Total hours";
            dataGridView.Columns[4].Name = "Overtime";
            dataGridView.Columns[5].Name = "Leave";
            dataGridView.Columns[6].Name = "Bonus";
            dataGridView.Columns[7].Name = "Allowance";
            dataGridView.Columns[9].Name = "Tax";
            dataGridView.Columns[8].Name = "Insurance";
            dataGridView.Columns[10].Name = "Final salary";
            dataGridView.Columns[11].Name = "From day";
            dataGridView.Columns[12].Name = "To day";
            for (int i = 1; i < 13; i++) { dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
            for (int i = 6; i < 11; i++) { dataGridView.Columns[i].DefaultCellStyle.Format = "C"; }
            dataGridView.Rows.Clear();

            foreach (var s in salaryList)
            {
                string fullName = _userDao.Value.GetUserByID(s.idUser).fullName;
                dataGridView.Rows.Add(s.idUser, fullName, s.basicSalary?.ToString("$0.00/h"),
                    s.totalHours?.ToString("0.0'h'"), s.overtimeHours?.ToString("0.0'h'"), s.leaveHours?.ToString("0.0'h'"), s.bonus, s.allowance,
                    s.tax, s.insurance, s.finalSalary, s.fromDate.ToString("dd/MM/yyyy"), s.toDate.ToString("dd/MM/yyyy"));
            }
        }

        private void btn_caculateSalary_Click(object sender, EventArgs e)
        {
            StackForm.FormMain.ChildForm.Open(new FormCaculateSalary());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataToDataGirdView(GetData(), datagridview_salary);
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (_userDao.Value.IsHumanResources())
            {
                if (selectedSalary != null)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _salaryDao.Value.DeleteAllSalary(selectedSalary);
                        selectedSalary = null;
                        LoadDataToDataGirdView(GetData(), datagridview_salary);
                    }
                }
                else MessageBox.Show("You haven't selected a task!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Access denied!!! Insufficient permissions to access feature.", "Message", MessageBoxButtons.OK);
            }
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            LoadDataToDataGirdView(GetData(), datagridview_salary);
        }

        private void combobox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combobox_year.SelectedIndex != 0 && combobox_month.SelectedIndex != 0)
            {
                int month = int.Parse(combobox_month.SelectedItem.ToString());
                int year  = int.Parse(combobox_year.SelectedItem.ToString());
                List<salary> listSalary = _salaryDao.Value.GetListSalaryByMonthOfYear(month, year);
                LoadDataToDataGirdView(listSalary, datagridview_salary);
            } 
        }

        private void combobox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_year.SelectedIndex != 0 && combobox_month.SelectedIndex != 0)
            {
                int month = int.Parse(combobox_month.SelectedItem.ToString());
                int year = int.Parse(combobox_year.SelectedItem.ToString());
                List<salary> listSalary = _salaryDao.Value.GetListSalaryByMonthOfYear(month, year);
                LoadDataToDataGirdView(listSalary, datagridview_salary);
            }
        }

        private void datagridview_salary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                object value = datagridview_salary.Rows[e.RowIndex].Cells[0].Value;
                if (value != DBNull.Value)
                {
                    int idUser = Convert.ToInt32(value);
                    string dateString = datagridview_salary.Rows[e.RowIndex].Cells[11].Value.ToString();
                    string dateString2 = datagridview_salary.Rows[e.RowIndex].Cells[12].Value.ToString();

                    DateTime fromDate;
                    DateTime toDate;

                    DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fromDate);
                    DateTime.TryParseExact(dateString2, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out toDate);
           
                    selectedSalary = _salaryDao.Value.GetSalaryForUser(idUser, fromDate, toDate);
                }
            }
        }
    }
}