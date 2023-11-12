using company_management.View;
using company_management.View.UC;
using FullScreenAppDemo.DTO;
using LiveCharts.Configurations;
using Project_Management;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FullScreenAppDemo.DAO
{
    internal class RequestDAO
    {
        private static RequestDAO instance;
        public static RequestDAO Instance
        {
            get { if (instance == null) instance = new RequestDAO(); return RequestDAO.instance; }
            private set => RequestDAO.instance = value;
        }

        private RequestDAO() { }



        public leaveRequest GetRequestById(int id)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                return entity.leaveRequests.SingleOrDefault(l => l.id == id);
            }
        }

        public bool AddRequest(DateTime startDate, DateTime endDate, DateTime requestDate, string content)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                leaveRequest lr = new leaveRequest();
                lr.content = content;
                lr.endDate = endDate;
                lr.startDate = startDate;
                lr.requestDate = requestDate;
                lr.numberDay = (endDate - startDate).Days;
                lr.status = "Pending";
                lr.idUser = UserSession.LoggedInUser.id;
                try
                {
                    entity.leaveRequests.Add(lr);
                    entity.SaveChanges();
                    Util.Instance.Alert("Add request success", FormAlert.enmType.Success);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Util.Instance.Alert("Add request fail", FormAlert.enmType.Error);
                    return false;
                }
            }
        }
        public List<leaveRequest> GetALlRequestByPosition()
        {
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                return GetALlRequest();
            else
                return GetMyLeaveRequests();
        }

        public List<leaveRequest> GetMyLeaveRequests()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                return entity.leaveRequests.Where(s => s.idUser == UserSession.LoggedInUser.id).ToList<leaveRequest>();
            }
        }

        public List<leaveRequest> GetALlRequest()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                return entity.leaveRequests.ToList<leaveRequest>();
            }
        }
        internal List<leaveRequest> GetALlApproved()
        {

            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                return GetALlRequest().Where(r => r.status == "Approved").ToList<leaveRequest>();
            else
                return GetMyLeaveRequests().Where(r => r.status == "Approved").ToList<leaveRequest>();

        }

        internal List<leaveRequest> GetALlPending()
        {
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                return GetALlRequest().Where(r => r.status == "Pending").ToList<leaveRequest>();
            else
                return GetMyLeaveRequests().Where(r => r.status == "Pending").ToList<leaveRequest>();
        }

        internal List<leaveRequest> GetALlRefuse()
        {

            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                return GetALlRequest().Where(r => r.status == "Refused").ToList<leaveRequest>();
            else
                return GetMyLeaveRequests().Where(r => r.status == "Refused").ToList<leaveRequest>();
        }

        internal List<leaveRequest> GetALlCancelled()
        {
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                return GetALlRequest().Where(r => r.status == "Cancelled").ToList<leaveRequest>();
            else
                return GetMyLeaveRequests().Where(r => r.status == "Cancelled").ToList<leaveRequest>();
        }

        internal void DeleteRequest(int selectedId)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                leaveRequest leaveRequest = entity.leaveRequests.SingleOrDefault(lr => lr.id == selectedId);
                if (leaveRequest != null)
                {
                    entity.leaveRequests.Remove(leaveRequest);
                    entity.SaveChanges();
                    Util.Instance.Alert("Deleted successful", FormAlert.enmType.Success);
                }
                else
                {
                    Util.Instance.Alert("Deleted failed", FormAlert.enmType.Error);
                }
            }
        }

        internal void UpdateRequest(leaveRequest leaveRequest)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    entity.Entry(leaveRequest).State = EntityState.Modified;
                    entity.SaveChanges();
                    Util.Instance.Alert(leaveRequest.status, FormAlert.enmType.Success);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                    Util.Instance.Alert("Update request fail", FormAlert.enmType.Error);
                }
            }
        }
        public int CountTotalRequests()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                {
                    return GetALlRequest().Count;
                }
                else
                {
                    return GetMyLeaveRequests().Count;
                }
            }
        }

    }
}
