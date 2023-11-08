using company_management.View;
using FullScreenAppDemo.DTO;
using Guna.UI2.WinForms;
using LiveCharts.Configurations;
using Project_Management;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;

namespace FullScreenAppDemo.DAO
{
    internal class UserDAO
    {

        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            private set => UserDAO.instance = value;
        }

        private UserDAO() { }

        public List<user> GetALlUser()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                return entity.users.ToList<user>();
            }
        }
        public void DeleteUser(user user)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    // Delete all foreign key
                    team team1 = entity.teams.SingleOrDefault(t => t.idLeader == user.id);
                    if (team1 != null)
                    {
                        team1.idLeader = null;
                        entity.Entry(team1).State = EntityState.Modified;
                        entity.SaveChanges();
                    }
                    List<checkin_checkout> cc = (from cc1 in entity.checkin_checkout where cc1.idUser == user.id select cc1).ToList<checkin_checkout>();
                    foreach (checkin_checkout sa in cc)
                    {
                        entity.checkin_checkout.Remove(sa);
                        entity.SaveChanges();
                    }

                    List<leaveRequest> lrequest = (from lr2 in entity.leaveRequests where lr2.idApprover == user.id select lr2).ToList<leaveRequest>();
                    foreach (leaveRequest sa in lrequest)
                    {
                        sa.idApprover = null;
                        entity.Entry(sa).State = EntityState.Modified;
                        entity.SaveChanges();
                    }
                    List<leaveRequest> lr = (from lr1 in entity.leaveRequests where lr1.idUser == user.id select lr1).ToList<leaveRequest>();
                    foreach (leaveRequest sa in lr)
                    {
                        entity.leaveRequests.Remove(sa);
                        entity.SaveChanges();
                    }
                    List<project> projects = (from pj in entity.projects where pj.idAssignee == user.id select pj).ToList<project>();
                    foreach (project pj in projects)
                    {
                        pj.idAssignee = null;
                        entity.Entry(pj).State = EntityState.Modified;
                        entity.SaveChanges();
                    }
                    List<salary> salary = (from sa in entity.salaries where sa.idUser == user.id select sa).ToList<salary>();
                    foreach (salary sa in salary)
                    {
                        entity.salaries.Remove(sa);
                        entity.SaveChanges();
                    }

                    List<task> task2 = (from tk2 in entity.tasks where tk2.idAssignee == user.id select tk2).ToList<task>();
                    foreach (task tk in task2)
                    {
                        tk.idAssignee = null;
                        entity.Entry(tk).State = EntityState.Modified;
                        entity.SaveChanges();
                    }

                    List<user_team> ut = (from team in entity.user_team where team.idUser == user.id select team).ToList<user_team>();
                    foreach (user_team user_Team in ut)
                    {
                        entity.user_team.Remove(user_Team);
                        entity.SaveChanges();
                    }
                    List<user_salary> us = (from sy in entity.user_salary where sy.idUser == user.id select sy).ToList<user_salary>();
                    foreach (user_salary user_salary in us)
                    {
                        entity.user_salary.Remove(user_salary);
                        entity.SaveChanges();
                    }
                    //////////////////////////////////////
                    var entry = entity.Entry(user);
                    if (entry.State == EntityState.Detached)
                    {
                        entity.users.Attach(user);
                        entity.users.Remove(user);
                        entity.SaveChanges();
                    }
                    Util.Instance.Alert("Delete user success", FormAlert.enmType.Error);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Util.Instance.Alert("Delete user fail", FormAlert.enmType.Error);
                }

            }
        }
        public user GetUserByUserName(string userName)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                user user = entity.users.SingleOrDefault(u => u.username.Equals(userName));
                return user;
            }

        }
        public user GetUserByID(int id)
        {

            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    user user = entity.users.SingleOrDefault(u => u.id.Equals(id));
                    return user;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
        public void CheckEmployeeIsReadOnlyStatus(Guna2TextBox txt)
        {
            int idPos = (int)UserSession.LoggedInUser.idPosition;
            if (idPos == 3)
                txt.ReadOnly = true;
            else txt.ReadOnly = false;
        }

        public bool IsEmployee()
        {
            int positionId = (int)UserSession.LoggedInUser.idPosition;
            return positionId == 3;
        }

        public bool IsManager()
        {
            int positionId = (int)UserSession.LoggedInUser.idPosition;
            return positionId == 1;
        }

        public bool IsHumanResources()
        {
            int positionId = (int)UserSession.LoggedInUser.idPosition;
            return positionId == 4;
        }

        public bool IsLeader()
        {
            int positionId = (int)UserSession.LoggedInUser.idPosition;
            return positionId == 2;
        }

        public string IdPositionToString(int id)
        {
            if (id == 1)
            {
                return "manager";
            }
            else if (id == 2)
            {
                return "leader";
            }
            else if (id == 3)
            {
                return "employee";
            }
            else { return "HumanResources"; }
        }
        public user GetUserByIdAndPassWord(string password)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                user user = entity.users.SingleOrDefault(u => u.id == UserSession.LoggedInUser.id && u.password == password);
                return user;
            }
        }
        public void UpdateUser(user user)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    entity.Entry(user).State = EntityState.Modified;
                    entity.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                    Util.Instance.Alert("Update user fail", FormAlert.enmType.Error);
                }
            }
        }

        public void AddUser(user user)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    entity.users.Add(user);
                    entity.SaveChanges();
                    Util.Instance.Alert("Add user success", FormAlert.enmType.Success);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Util.Instance.Alert("Add user fail", FormAlert.enmType.Error);
                }
            }
        }

        public List<user> SearchUsers(string keyword)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                List<user> userList = entity.users
                .Where(u => u.username.Contains(keyword) || u.fullName.Contains(keyword) ||
                            u.email.Contains(keyword) || u.address.Contains(keyword) ||
                            u.phoneNumber.Contains(keyword)).ToList<user>();
                return userList;
            }
        }

    }
}
