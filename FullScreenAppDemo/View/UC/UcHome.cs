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
            DisplayTotalCounts();
        }
        private void DisplayTotalCounts()
        {
            try
            {
                int totalProjects = UserDAO.Instance.CountTotalProjects();
                int totalTasks = UserDAO.Instance.CountTotalTasks();
                int totalTeams = UserDAO.Instance.CountTotalTeams();
                int totalRequests = UserDAO.Instance.CountTotalRequests();

                // Hiển thị số lượng tổng trong các Label hoặc các điều khiển khác tùy thuộc vào cách bạn thiết kế giao diện
                label_project.Text = $"{totalProjects}";
                label_task.Text = $"{totalTasks}";
                label_team.Text = $"{totalTeams}";
                label_request.Text = $"{totalRequests}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                // Xử lý nếu có lỗi khi lấy dữ liệu
                MessageBox.Show("Error loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
