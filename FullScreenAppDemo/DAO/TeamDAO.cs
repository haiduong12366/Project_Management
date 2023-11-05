using FullScreenAppDemo.DTO;
using Project_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.DAO
{
    internal class TeamDAO
    {
        company_management_Entities entity = new company_management_Entities();
        private static TeamDAO instance;
        public static TeamDAO Instance
        {
            get { if (instance == null) instance = new TeamDAO(); return TeamDAO.instance; }
            private set => TeamDAO.instance = value;
        }

        private TeamDAO() { }

        public List<team> GetAllTeams() { 
            List<team> list = entity.teams.ToList<team>();
            return list;
        }

        public List<team> GetTeamByLeader(int idteam)
        {
            var query = from item in entity.teams where item.id == idteam select item;
            return query.ToList<team>();

        }
        public List<team> GetTeamByID()
        {
            List<team> teams = new List<team>();


            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
            {
                teams = TeamDAO.instance.GetAllTeams();
            }
            else if (UserDAO.Instance.IsLeader())
            {
                teams = TeamDAO.instance.GetTeamByLeader(UserSession.LoggedInUser.id);
            }

            return teams;
        }

        public string idTeamToString(int id)
        {
            var team = from t in entity.teams where t.id == id select t.name;
            string name = team.ToString();
            return name;
        }
    }
}
