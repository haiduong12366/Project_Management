using Project_Management.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project_Management.Utils;
using System.Globalization;
using System.Text;
using System.Windows.Media.TextFormatting;

// ReSharper disable All

namespace Project_Management.View.UC
{
    public partial class UcSalary : UserControl
    {
        private readonly Lazy<SalaryDAO> _salaryDao;
        private readonly Lazy<UserDAO> _userDao;
        private salary selectedSalary = null;
        private List<salary> listSalary = null;

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
            List<salary> listSalary = GetData();
            SortListSalaryByLatest(listSalary);

            if (_userDao.Value.IsHumanResources())
            {
                btn_caculateSalary.Visible = true;
                btn_showAllSalariesOf.Visible = true;
            }
            else
            {
                btn_caculateSalary.Visible = false;
                btn_showAllSalariesOf.Visible = false;
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
            dataGridView.Columns[8].Name = "Tax";
            dataGridView.Columns[9].Name = "Insurance";
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

            ShowStatisticsData();
        }

        public string RemoveNonNumericCharacters(string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        private void ShowStatisticsData()
        {
            int countRow = datagridview_salary.RowCount;
            double totalHours = 0;
            double totalAllowances = 0;
            double totalInsurances = 0;
            double totalTaxs = 0;
            double totalSalares = 0;
            if(countRow > 0)
            {
                foreach (DataGridViewRow row in datagridview_salary.Rows)
                {
                    double temp = 0;
                    
                    if(row.Cells[3].Value != null)
                    {
                        temp = double.Parse(RemoveNonNumericCharacters(row.Cells[3].Value.ToString()));
                        totalHours += temp;
                        temp = 0;
                    }
                    if (row.Cells[7].Value != null)
                    {
                        temp = double.Parse(RemoveNonNumericCharacters(row.Cells[7].Value.ToString()));
                        totalAllowances += temp;
                        temp = 0;
                    }
                    if (row.Cells[9].Value != null)
                    {
                        temp = double.Parse(RemoveNonNumericCharacters(row.Cells[9].Value.ToString()));
                        totalInsurances += temp;
                        temp = 0;
                    }
                    if (row.Cells[8].Value != null)
                    {
                        temp = double.Parse(RemoveNonNumericCharacters(row.Cells[8].Value.ToString()));
                        totalTaxs += temp;
                        temp = 0;
                    }
                    if (row.Cells[10].Value != null)
                    {
                        temp = double.Parse(RemoveNonNumericCharacters(row.Cells[10].Value.ToString()));
                        totalSalares += temp;
                        temp = 0;
                    }
                }
            }
            label_totalHours.Text = totalHours.ToString() + "h";
            label_totalAllowance.Text = "$" + totalAllowances.ToString();
            label_totalInsurance.Text = "$" + totalInsurances.ToString();
            label_totalTax.Text = "$" + totalTaxs.ToString();
            label_totalFinalSalary.Text = "$" + totalSalares.ToString();
        }

        private void btn_caculateSalary_Click(object sender, EventArgs e)
        {
            StackForm.FormMain.ChildForm.Open(new FormCaculateSalary());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            combobox_month.SelectedIndex = 0;
            combobox_year.SelectedIndex = 0;

            List<salary> listSalary = GetData();
            SortListSalaryByLatest(listSalary);
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
                        List<salary> listSalary = GetData();
                        SortListSalaryByLatest(listSalary);
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
            combobox_month.SelectedIndex = 0;
            combobox_year.SelectedIndex = 0;

            List<salary> listSalary = GetData();
            SortListSalaryByLatest(listSalary);
        }

        private void combobox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combobox_year.SelectedIndex != 0 && combobox_month.SelectedIndex != 0)
            {
                int month = int.Parse(combobox_month.SelectedItem.ToString());
                int year  = int.Parse(combobox_year.SelectedItem.ToString());
                List<salary> listSalary = _salaryDao.Value.GetListSalaryByMonthOfYear(month, year);
                SortListSalaryByLatest(listSalary);
            } 
        }

        private void combobox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_year.SelectedIndex != 0 && combobox_month.SelectedIndex != 0)
            {
                int month = int.Parse(combobox_month.SelectedItem.ToString());
                int year = int.Parse(combobox_year.SelectedItem.ToString());
                List<salary> listSalary = _salaryDao.Value.GetListSalaryByMonthOfYear(month, year);
                SortListSalaryByLatest(listSalary);
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

        private void SortListSalaryByLatest(List<salary> listSalary)
        {
            if(listSalary != null)
            {
                listSalary.Sort((x, y) =>
                {
                    if (x.fromDate == null && y.fromDate == null)
                        return 0;
                    else if (x.fromDate == null)
                        return 1;
                    else if (y.fromDate == null)
                        return -1;
                    else
                        return DateTime.Compare(y.fromDate.Date, x.fromDate.Date);
                });
                this.listSalary = listSalary;

                combobox_sortByDate.SelectedIndex = 0;
                LoadDataToDataGirdView(this.listSalary, datagridview_salary);
            }
        }

        private void SortListSalaryByOldest(List<salary> listSalary)
        {
            if (listSalary != null)
            {
                listSalary.Sort((x, y) =>
                {
                    if (x.fromDate == null && y.fromDate == null)
                        return 0;
                    else if (x.fromDate == null)
                        return 1;
                    else if (y.fromDate == null)
                        return -1;
                    else
                        return DateTime.Compare(x.fromDate.Date, y.fromDate.Date);
                });
                this.listSalary = listSalary;

                LoadDataToDataGirdView(this.listSalary, datagridview_salary);
            }
        }

        private void combobox_sortByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = combobox_sortByDate.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    SortListSalaryByLatest(this.listSalary);
                    break;
                case 1:
                    SortListSalaryByOldest(this.listSalary);
                    break;
                default:
                    SortListSalaryByLatest(this.listSalary);
                    break;
            }
        }

        private void btn_showAllSalariesOf_Click(object sender, EventArgs e)
        {
            if (selectedSalary != null)
            {
                List<salary> listSalary = _salaryDao.Value.GetSalariesOfUserByID(selectedSalary.idUser);
                SortListSalaryByLatest(listSalary);
            }
            else MessageBox.Show("You haven't selected a task!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}