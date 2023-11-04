using FullScreenAppDemo.DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FullScreenAppDemo.DAO
{
    internal class UserDAO
    {

        company_management_Entities entity = new company_management_Entities();
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            private set => UserDAO.instance = value;
        }

        private UserDAO() { }

        public List<user> GetALlUser()
        {
            return entity.users.ToList<user>();
        }

        public user GetUserByUserName(string userName)
        {
            user user = entity.users.SingleOrDefault(u => u.username.Equals(userName));
            return user;
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
    }
}
