using Project_Management.View.UC;
using Project_Management.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Project_Management.Utils;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Project_Management.DTO;
using System.Windows.Controls;
using System.Runtime.Remoting.Contexts;

namespace Project_Management.DAO
{
    public class SalaryDAO
    {
        private readonly company_management_Entities entity;
        private readonly Lazy<CheckIn_CheckOutDAO> _cicoDao;
        private readonly Lazy<TaskDAO> _taskDao;
        private readonly Lazy<UserDAO> _userDao;
        private Lazy<Util> _util;

        public SalaryDAO()
        {
            entity = new company_management_Entities();
            _cicoDao = new Lazy<CheckIn_CheckOutDAO>(() => new CheckIn_CheckOutDAO());
            _taskDao = new Lazy<TaskDAO>(() => new TaskDAO());
            _userDao = new Lazy<UserDAO>(() => new UserDAO());
            _util = new Lazy<Util>(() => new Util());
        }

        public List<salary> GetAllSalary()
        {
            return entity.salaries.ToList();
        }

        public List<salary> GetMySalary(int idUser)
        {
            return GetAllSalary().Where(s => s.idUser == idUser).ToList();
        }

        public List<salary> GetListSalaryByPosition()
        {
            if(_userDao.Value.IsManager() || _userDao.Value.IsHumanResources())
            {
                return GetAllSalary();
            }
            else
            {
                return GetMySalary(UserSession.LoggedInUser.id);
            }
        }

        public List<salary> GetListSalaryByMonthOfYear(int month, int year)
        {
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            DateTime lastDayOfMonth = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            var listSalary = GetListSalaryByPosition().Where(t => t.fromDate == firstDayOfMonth && t.toDate == lastDayOfMonth).ToList();

            return listSalary;
        }

        private user_salary SetBasicInfoOfSalary(int idUser)
        {
            return entity.user_salary.Find(idUser);
        }

        private salary CalculateSalaryForEmployee(int idUser, DateTime fromDate, DateTime toDate)
        {
            user_salary userBasicSalary = SetBasicInfoOfSalary(idUser);
            if(userBasicSalary == null)
            {
                return null;
            }

            double totalHours;
            double overtimeHours;
            double leaveHours;
            double bonus;

            bonus = _taskDao.Value.CalculateBonusForEmployee(idUser, fromDate, toDate);
            totalHours = _cicoDao.Value.GetTotalHours(idUser, fromDate, toDate);
            overtimeHours = _cicoDao.Value.GetOvertimeHours(idUser, fromDate, toDate);
            leaveHours = _cicoDao.Value.GetLeaveHours(idUser, fromDate, toDate);

            double hourlyRate = userBasicSalary.basicSalary;
            double hourlyPay = (totalHours - overtimeHours) * hourlyRate;
            double overtimePay = overtimeHours * 1.5 * hourlyRate;
            double leavePay = leaveHours * hourlyRate;
            double allowance = (userBasicSalary.allowance == null) ? 0 : (double)userBasicSalary.allowance;
            double tax = (userBasicSalary.tax == null) ? 0 : (double) userBasicSalary.tax;
            double insurance = (userBasicSalary.insurance == null) ? 0 : (double)userBasicSalary.insurance;

            double finalSalary = hourlyPay + overtimePay + bonus + allowance - leavePay - tax - insurance;

            salary newSalaryOfUser = new salary();
            newSalaryOfUser.idUser = idUser;
            newSalaryOfUser.basicSalary = hourlyRate;
            newSalaryOfUser.totalHours = totalHours;
            newSalaryOfUser.overtimeHours = overtimeHours;
            newSalaryOfUser.leaveHours = leaveHours; 
            newSalaryOfUser.bonus = bonus;
            newSalaryOfUser.tax = tax;
            newSalaryOfUser.allowance = allowance;
            newSalaryOfUser.insurance = insurance;
            newSalaryOfUser.finalSalary = finalSalary;
            newSalaryOfUser.fromDate = fromDate;
            newSalaryOfUser.toDate = toDate;

            return newSalaryOfUser;
        }

        private List<int> GetUserIdList(DateTime fromDate, DateTime toDate)
        {
            List<int> listIdUser = (from c in entity.checkin_checkout
                        where c.date >= fromDate && c.date <= toDate
                        select c.idUser).ToList();

            return listIdUser;
        }

        public void CalculateAndSaveSalaryForAllEmployees(DateTime fromDate, DateTime toDate)
        {
            List<int> userIds = GetUserIdList(fromDate, toDate);

            if(userIds.Count() <= 0)
            {
                _util.Value.Alert("No check-in data for this!!!", FormAlert.enmType.Error);
                return;
            }

            foreach (int idUser in userIds)
            {
                salary salary = CalculateSalaryForEmployee(idUser, fromDate, toDate);
                if (salary != null)
                {
                    entity.salaries.Add(salary);
                    entity.SaveChanges();
                }
            }

            _util.Value.Alert("Calculate successful", FormAlert.enmType.Success);
        }

        public salary GetSalaryForUser(int idUser,  DateTime fromDate, DateTime toDate)
        {
            var result = GetAllSalary().Where(t => t.idUser == idUser && t.fromDate == fromDate && t.toDate == toDate);
            return result != null ? result.FirstOrDefault() : null;
        }

        public List<salary> GetSalariesOfUserByID(int idUser)
        {
            return GetListSalaryByPosition().Where(t => t.idUser ==  (int)idUser).ToList();
        }

        public void DeleteAllSalary(salary salaryDelete)
        {
            try
            {
                entity.salaries.Remove(salaryDelete);
                entity.SaveChanges();
                _util.Value.Alert("Deleted salary successful", FormAlert.enmType.Success);
            }
            catch
            {
                _util.Value.Alert("Deleted salary failed", FormAlert.enmType.Error);
            }
        }

        public void DeleteAllSalaryOfMonth( DateTime fromDate, DateTime toDate)
        {
            var rowDelete = entity.salaries.Where(t => t.fromDate == fromDate && t.toDate == toDate).ToList();
            entity.salaries.RemoveRange(rowDelete);
            entity.SaveChanges();

            rowDelete = entity.salaries.Where(t => t.fromDate == fromDate && t.toDate == toDate).ToList();
            entity.salaries.RemoveRange(rowDelete);
            entity.SaveChanges();
        }
}
}
