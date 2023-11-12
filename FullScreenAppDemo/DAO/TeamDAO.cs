using company_management.View;
using FullScreenAppDemo.DTO;
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
using System.Windows.Media;

namespace FullScreenAppDemo.DAO
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

        private TeamDAO() { }

        public List<team> GetAllTeams()
        {
            List<team> list = entity.teams.ToList<team>();
            return list;
        }

        public List<team> GetTeamByLeader(int id)
        {
            var query = from item in entity.teams where item.idLeader == id select item;
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
    }
}
