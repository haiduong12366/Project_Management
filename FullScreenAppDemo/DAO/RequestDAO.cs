using FullScreenAppDemo.DTO;
using LiveCharts.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FullScreenAppDemo.DAO
{
    internal class RequestDAO
    {
        company_management_Entities entity = new company_management_Entities();
        private static RequestDAO instance;
        public static RequestDAO Instance
        {
            get { if (instance == null) instance = new RequestDAO(); return RequestDAO.instance; }
            private set => RequestDAO.instance = value;
        }

        private RequestDAO() { }

        public bool AddRequest(DateTime startDate, DateTime endDate, DateTime requestDate,string content)
        {
            leaveRequest lr = new leaveRequest();
            lr.content = content;
            lr.endDate = endDate;
            lr.startDate = startDate;
            lr.requestDate = requestDate;
            lr.idUser = UserSession.LoggedInUser.id;
            try
            {
                entity.leaveRequests.Add(lr);
                entity.SaveChanges();
                MessageBox.Show("Thêm thành công");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("Thêm thất bại");
                return false;
            }
        }
    }
}
