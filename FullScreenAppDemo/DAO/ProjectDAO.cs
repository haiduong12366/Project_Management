
using company_management.DTO;
using company_management.View;
using FullScreenAppDemo.DTO;
using Project_Management;
using Project_Management.DAO;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace FullScreenAppDemo.DAO
{
    internal class ProjectDAO
    {

        private static ProjectDAO instance;
        public static ProjectDAO Instance
        {
            get { if (instance == null) instance = new ProjectDAO(); return ProjectDAO.instance; }
            private set => ProjectDAO.instance = value;
        }

        private ProjectDAO() { }


        public void AddProject(int idAssignee, string name, string description,
            DateTime startDate, DateTime endDate, int progress, int idTeam, float bonus)
        {
            using (company_management_Entities entity = new company_management_Entities())
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
        }

        public List<project> GetProjectByTeam(int id)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                var query = from item in entity.projects where item.idTeam == id select item;
                return query.ToList<project>();
            }
        }

        public List<project> GetALlProject()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                return entity.projects.ToList<project>();
            }
        }
        public List<project> GetMyProject()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                List<team> team = TeamDAO.Instance.GetTeamByIDUser();
                List<project> list = new List<project>();
                foreach (team idTeam in team)
                {
                    List<project> pj = entity.projects.Where(s => s.idTeam == idTeam.id).ToList<project>();
                    foreach(project project in pj)
                        list.Add(project);
                }
                return list;
            }
        }

        internal List<project> GetListProjectByPosition()
        {
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                return GetALlProject();
            else
                return GetMyProject();
        }

        internal List<project> GetToDoProject()
        {
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                return GetALlProject().Where(r => r.progress == 0).ToList<project>();
            else
                return GetMyProject().Where(r => r.progress == 0).ToList<project>();
        }

        internal List<project> GetInprogressProjects()
        {
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                return GetALlProject().Where(r => r.progress > 0 && r.progress < 100).ToList<project>();
            else
                return GetMyProject().Where(r => r.progress > 0 && r.progress < 100).ToList<project>();
        }

        internal List<project> GetDoneProjects()
        {
            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                return GetALlProject().Where(r => r.progress == 100).ToList<project>();
            else
                return GetMyProject().Where(r => r.progress == 100).ToList<project>();
        }

        internal void DeleteProject(int id)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    var projectToDelete = entity.projects.FirstOrDefault(p => p.id == id);
                    if (projectToDelete != null)
                    {
                        entity.projects.Remove(projectToDelete);
                        entity.SaveChanges();
                        Util.Instance.Alert("Delete project success", FormAlert.enmType.Success);
                    }
                    else
                    {
                        Util.Instance.Alert("Not found project!", FormAlert.enmType.Warning);
                    }
                }
                catch (Exception)
                {
                    Util.Instance.Alert("Delete project fail!", FormAlert.enmType.Error);
                }
            }
        }

        internal project GetProjectById(int id)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                return entity.projects.SingleOrDefault(p => p.id.Equals(id));
            }
        }

        internal void UpdateProject(project project)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    entity.Entry(project).State = EntityState.Modified;
                    entity.SaveChanges();
                    Util.Instance.Alert("update project success", FormAlert.enmType.Success);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Util.Instance.Alert("Update request fail", FormAlert.enmType.Error);
                }
            }
        }

        internal TaskStatusPercentage GetProjectStatusPercentage(List<project> projects)
        {
            TaskStatusPercentage projectStatus = new TaskStatusPercentage(0, 0, 0);

            if (projects.Count > 0)
            {
                double totalTasks = projects.Count;
                double todoCount = projects.Count(p => p.progress == 0);
                double inprogressCount = projects.Count(p => p.progress > 0 && p.progress < 100);
                double doneCount = projects.Count(p => p.progress == 100);

                projectStatus.TodoPercent = (todoCount / totalTasks) * 100;
                projectStatus.InprogressPercent = (inprogressCount / totalTasks) * 100;
                projectStatus.DonePercent = (doneCount / totalTasks) * 100;
            }

            return projectStatus;
        }
    }
}