
﻿using Project_Management.View;
using Project_Management.DAO;

﻿using company_management.View;
using FullScreenAppDemo.DAO;
using FullScreenAppDemo.DTO;

using Project_Management.Utils;
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

        public User_teamDAO() { }

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
                    Util.Instance.Alert("Add User of team success", FormAlert.enmType.Success);
                }
                catch (Exception ex)
                {
                    Util.Instance.Alert("Add User of team fail", FormAlert.enmType.Error);
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

        public List<team> GetTeamByID()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                List<team> teams = new List<team>();
                var team = from t in entity.user_team where t.idUser == UserSession.LoggedInUser.id select t;
                foreach (var t in team)
                {
                    team team1 = TeamDAO.Instance.GetTeamByIdTeam((int)t.idTeam);
                    teams.Add(team1);
                }    
                return teams;
            }
        }
    }
}
