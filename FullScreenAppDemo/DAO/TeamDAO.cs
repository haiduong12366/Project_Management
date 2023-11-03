using FullScreenAppDemo.DTO;
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
        private static TeamDAO instance;
        public static TeamDAO Instance
        {
            get { if (instance == null) instance = new TeamDAO(); return TeamDAO.instance; }
            private set => TeamDAO.instance = value;
        }

        private TeamDAO() { }

        public List<Team> GetAllTeams() { 
            List<Team> list = new List<Team>();
            string sql = "select * from teams";
            DataTable dt = DBConnection.Instance.ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                Team team = new Team(row);
                list.Add(team);
            }
            return list;
        }
    }
}
