using Project_Management.View;
using Project_Management.DTO;
using Project_Management;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.Xml;

namespace Project_Management.DAO
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

        public TeamDAO() { }

        public List<team> GetAllTeams()
        {
            List<team> list = entity.teams.ToList<team>();
            return list;
        }

        public List<team> GetTeamByLeader(int idLeader)
        {
            var query = from item in entity.teams where item.idLeader == idLeader select item;
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

        public team GetTeamByID(int idTeam)
        {
            var team = entity.teams.Where(t => t.id == idTeam).FirstOrDefault();
            return team;
        }

        public int GetLeaderIDByTeamID(int teamID)
        {
            var idLeader = entity.teams.Where(t => t.id == teamID).Select(t => t.idLeader).FirstOrDefault();
            if (idLeader != null)
            {
                return (int)idLeader;
            }
            else
            {
                return -1;
            }
        }

        public int GetIDTeamByUserID(int userId)
        {
            var result = (from user in entity.users
                          join userTeam in entity.user_team on user.id equals userTeam.idUser
                          join team in entity.teams on userTeam.idTeam equals team.id
                          where user.id == userId
                          select team.id).SingleOrDefault();

            return result;
        }

        public String GetNameTeamByID(int idteam)
        {
            var result = entity.teams.Find(idteam);
            return result.name;
        }

        public string idTeamToString(int id)
        {
            var team = from t in entity.teams where t.id == id select t.name;
            string name = team.ToString();
            return name;
        }

        public void UpdateLeader(int id, string username)
        {
            try
            {
                team team = entity.teams.SingleOrDefault(t => t.id == id);
                user user = UserDAO.Instance.GetUserByUserName(username);
                team.idLeader = user.id;
                entity.Entry(team).State = EntityState.Modified;
                entity.SaveChanges();
                Util.Instance.Alert("Update leader success", FormAlert.enmType.Success);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Util.Instance.Alert("Update leader fail", FormAlert.enmType.Error);
            }
        }
    }
}
