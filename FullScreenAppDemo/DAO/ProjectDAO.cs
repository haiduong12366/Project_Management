
using FullScreenAppDemo.DTO;
using Project_Management;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullScreenAppDemo.DAO
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

        private ProjectDAO() { }

        public List<project> GetALlProject()
        {
            return entity.projects.ToList<project>();
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
                MessageBox.Show("Add project success","Message");
            }
            catch { MessageBox.Show("Add project fail", "Message"); }

        }

        public List<project> GetProjectByTeam(int id)
        {
            var query = from item in entity.projects where item.idTeam == id select item;
            return query.ToList<project>();
        }



    }
}
