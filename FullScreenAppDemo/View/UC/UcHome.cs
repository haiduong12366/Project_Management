using System;
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

        }

        private void UcHome_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
