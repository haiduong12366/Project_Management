using FullScreenAppDemo.DTO;
using Guna.UI2.WinForms;
using Project_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
                user user = entity.users.SingleOrDefault(u => u.id.Equals(id));
                return user;
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
                entity.Entry(user).State = EntityState.Modified;
                entity.SaveChanges();
            }
        }
        public List<user_team> GetTeamByID(int id)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                var team = from t in entity.user_team where t.idUser == id select t;
                return team.ToList<user_team>();
            }
        }
    }
}
