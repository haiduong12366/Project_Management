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
            LoadData();
        }
        private void LoadData()
        {
            // Assuming you have DAO methods to get counts
            int projectCount = ProjectDAO.Instance.GetTotalProjectCount();
            int teamCount = TeamDAO.Instance.GetTotalTeamCount();
            int taskCount = TaskDAO.Instance.GetTotalTaskCount();
            int leaveRequestCount = RequestDAO.Instance.GetTotalRequestCount();

            // Update labels with the counts
            label_project.Text = $"{projectCount}";
            label_team.Text = $"{teamCount}";
            label_task.Text = $"{taskCount}";
            label_request.Text = $"{leaveRequestCount}";
        }
    }
}
