using Project_Management.View;
using Project_Management.DTO;
using Project_Management;
using Project_Management.DAO;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography.Xml;

using System.Windows.Media;


namespace Project_Management.DAO
{
    internal class TeamDAO
    {
        company_management_Entities entity = new company_management_Entities();
        private static TeamDAO instance;
        public event Action TeamDataChanged; // Event to notify changes
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
        public List<team> GetTeamByLeader(int idLeader)
        {
            var query = from item in entity.teams where item.idLeader == idLeader select item;

            return query.ToList<team>();

        }

        public List<team> GetTeamByManagerOrLeader()
        {
            List<team> teams = new List<team>();
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
            {
                teams = TeamDAO.Instance.GetAllTeams();
            }
            else if(UserDAO.Instance.IsLeader())
            {
                teams = GetTeamByLeader(UserSession.LoggedInUser.id);
            }
            return teams;
        }
        public List<team> GetTeamByIDUser()
        {
            List<team> teams = new List<team>();
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
            {
                teams = TeamDAO.Instance.GetAllTeams();
            }
            else
            {
                teams = User_teamDAO.Instance.GetTeamByID();
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

        internal team GetTeamByIdTeam(int id)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                team team = entity.teams.SingleOrDefault(u => u.id == id);
                return team;
            }
        }
        public void AddTeam(string name, string description, int idLeader, byte[] avatar)
        {
            try
            {
                // Determine the next available ID
                int nextId = entity.teams.Any() ? entity.teams.Max(t => t.id) + 1 : 1;

                // Create a new team with the next available ID
                team newTeam = new team
                {
                    id = nextId,
                    name = name,
                    description = description,
                    idLeader = idLeader,
                    avatar = avatar
                };
                // Add the new team to the entity
                entity.teams.Add(newTeam);

                // Save changes to the database
                entity.SaveChanges();

                // Notify subscribers about the change
                TeamDataChanged?.Invoke();

                Util.Instance.Alert("Add team success", FormAlert.enmType.Success);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Util.Instance.Alert("Add team fail", FormAlert.enmType.Error);
            }
        }
        public void UpdateTeam(int id, string name, string description, int idLeader, byte[] avatar)
        {
            try
            {
                team existingTeam = entity.teams.SingleOrDefault(t => t.id == id);

                if (existingTeam != null)
                {
                    existingTeam.name = name;
                    existingTeam.description = description;
                    existingTeam.idLeader = idLeader;
                    existingTeam.avatar = avatar;

                    entity.Entry(existingTeam).State = EntityState.Modified;
                    entity.SaveChanges();
                    Util.Instance.Alert("Update team success", FormAlert.enmType.Success);
                }
                else
                {
                    Util.Instance.Alert("Team not found", FormAlert.enmType.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Util.Instance.Alert("Update team fail", FormAlert.enmType.Error);
            }
        }
        public void DeleteTeam(int id)
        {
            try
            {
                team teamToDelete = entity.teams.SingleOrDefault(t => t.id == id);

                if (teamToDelete != null)
                {
                    entity.teams.Remove(teamToDelete);
                    entity.SaveChanges();
                    Util.Instance.Alert("Delete team success", FormAlert.enmType.Success);
                }
                else
                {
                    Util.Instance.Alert("Team not found", FormAlert.enmType.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Util.Instance.Alert("Delete team fail", FormAlert.enmType.Error);
            }
        }
        public int GetTeamMemberCount(int teamId)
        {
            try
            {
                // Retrieve the team members using the teamId
                var teamMembersCount = entity.user_team.Where(ut => ut.idTeam == teamId).Count();

                return teamMembersCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                // Handle exception (you may want to throw or return a default value)
                return -1;
            }
        }
        public int GetTeamProjectCount(int teamId)
        {
            try
            {
                // Retrieve the project count using the teamId
                var projectCount = entity.projects.Where(p => p.idTeam == teamId).Count();

                return projectCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                // Handle exception (you may want to throw or return a default value)
                return -1;
            }
        }
        public int GetTeamTaskCount(int teamId)
        {
            try
            {
                // Retrieve the task count using the teamId
                var taskCount = entity.tasks.Where(t => t.idTeam == teamId).Count();

                return taskCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                // Handle exception (you may want to throw or return a default value)
                return -1;
            }
        }
        public int CountTotalTeams()
        {
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
            {
                return GetAllTeams().Count;
            }
            else if (UserDAO.Instance.IsLeader())
            {
                return GetTeamByLeader(UserSession.LoggedInUser.id).Count;
            }
            else if (UserDAO.Instance.IsEmployee())
            {
                return GetTeamByIDUser().Count;
            }

            return 0;
        }

    }
}
