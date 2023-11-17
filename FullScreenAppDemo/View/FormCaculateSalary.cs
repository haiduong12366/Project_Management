using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Management.View.UC;
using Project_Management.DAO;

namespace Project_Management.View
{
    public partial class FormCaculateSalary : Form
    {
        private readonly Lazy<SalaryDAO> _salaryDao;
        public FormCaculateSalary()
        {
            InitializeComponent();
            _salaryDao = new Lazy<SalaryDAO>(() => new SalaryDAO());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StackForm.FormMain.ChildForm.AddUc(new UcSalary());
        }

        private void Button_calculateByMonth_Click(object sender, EventArgs e)
        {
            SalaryDAO _salaryDao = new SalaryDAO();
            int month = DateTimePicker_calculateByMonth.Value.Month;
            int year = DateTimePicker_calculateByMonth.Value.Year;

            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            DateTime lastDayOfMonth = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            try
            {
                _salaryDao.CalculateAndSaveSalaryForAllEmployees(firstDayOfMonth, lastDayOfMonth);
            }
            catch
            {
                string[] months = new string[]
                {
                    null,
                    "January",
                    "February",
                    "March",
                    "April",
                    "May",
                    "June",
                    "July",
                    "August", 
                    "September",
                    "October", 
                    "November",
                    "December"
                };
                
                DialogResult result = MessageBox.Show("The salary for " + months[month] + ", " + year + " has been calculated!!!\n\nDo you want to recalculate?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _salaryDao.DeleteAllSalaryOfMonth(firstDayOfMonth, lastDayOfMonth);
                    _salaryDao.CalculateAndSaveSalaryForAllEmployees(firstDayOfMonth, lastDayOfMonth);
                }
            }
            StackForm.FormMain.ChildForm.AddUc(new UcSalary());
        }
    }
}
