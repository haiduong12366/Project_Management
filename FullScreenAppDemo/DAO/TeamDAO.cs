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
    }
}
