
using Project_Management.View;
using Project_Management.DTO;
using Project_Management;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management.DAO
{
    internal class ProjectDAO
    {

        company_management_Entities entity = new company_management_Entities();
        private static ProjectDAO instance;
        public static ProjectDAO Instance
        {
            get { if (instance == null) instance = new ProjectDAO(); return ProjectDAO.instance; }
            private set => ProjectDAO.instance = value;
        }

        public ProjectDAO() { }

        public List<project> GetAllProject()
        {
            return entity.projects.ToList<project>();
        }

        public String GetNameProjectByID(int idProject)
        {
            var result = entity.projects.Find(idProject);
            return result.name;
        }

        public void AddProject(int idAssignee, string name, string description,
            DateTime startDate, DateTime endDate, int progress, int idTeam, float bonus)
        {


            try
            {
                project pj = new project();
                pj.idAssignee = idAssignee;
                pj.name = name;
                pj.description = description;
                pj.startDate = startDate;
                pj.endDate = endDate;
                pj.progress = progress;
                pj.idTeam = idTeam;
                pj.bonus = bonus;
                entity.projects.Add(pj);
                entity.SaveChanges();
                Util.Instance.Alert("Add project success", FormAlert.enmType.Success);

            }
            catch { Util.Instance.Alert("Add project fail", FormAlert.enmType.Error); }

        }

        public List<project> GetProjectByTeam(int id)
        {
            var query = from item in entity.projects where item.idTeam == id select item;
            return query.ToList<project>();
        }



    }
}
