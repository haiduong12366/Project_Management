using FullScreenAppDemo.DAO;
using Project_Management;
using System;
using System.Linq;
using System.Windows.Forms;

namespace company_management.View.UC
{
    public partial class UcHome : UserControl
    {

        public UcHome()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            LoadHomeStatistics();
        }

        private void LoadHomeStatistics()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {

            }
        }

        private void UcHome_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
