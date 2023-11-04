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
    }
}
