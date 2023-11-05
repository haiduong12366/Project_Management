using FullScreenAppDemo.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_Management.DAO
{
    internal class User_teamDAO
    {
        private static User_teamDAO instance;
        public static User_teamDAO Instance
        {
            get { if (instance == null) instance = new User_teamDAO(); return User_teamDAO.instance; }
            private set => User_teamDAO.instance = value;
        }

        private User_teamDAO() { }

        public void AddUser_Team(string username, int idteam)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    user_team ut = new user_team();
                    user user = UserDAO.Instance.GetUserByUserName(username);
                    ut.idUser = user.id;
                    ut.idTeam = idteam;
                    entity.user_team.Add(ut);
                    entity.SaveChanges();
                    MessageBox.Show("Add User of team success", "Message");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add User of team fail", "Message");
                }
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
