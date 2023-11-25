using Project_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management.View.Crystal_Report
{
    public partial class Form1 : Form
    {
        public Form1(bool iS)
        {
            InitializeComponent();

            using (company_management_Entities entity = new company_management_Entities())
            {
                if (!iS)
                {
                    string sql = string.Format("select fromDate,toDate,users.fullName as UserName , finalSalary from salary left outer join users on salary.idUser = users.id where salary.idUser = {0}", UserSession.LoggedInUser.id);
                    DataTable query = DBConnection.Instance.ExecuteQuery(sql);
                    CrystalReport1 crystalReport1 = new CrystalReport1();
                    crystalReport1.SetDataSource(query);
                    crystalReportViewer1.ReportSource = crystalReport1;
                }
                else
                {
                    string sql = string.Format("select fromDate,toDate,users.fullName as UserName , finalSalary from salary left outer join users on salary.idUser = users.id");
                    DataTable query = DBConnection.Instance.ExecuteQuery(sql);
                    CrystalReport1 crystalReport1 = new CrystalReport1();
                    crystalReport1.SetDataSource(query);
                    crystalReportViewer1.ReportSource = crystalReport1;
                }
            }
        }
    }
}
