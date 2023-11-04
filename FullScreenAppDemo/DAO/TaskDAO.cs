using FullScreenAppDemo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace FullScreenAppDemo.DAO
{
    internal class TaskDAO
    {
        company_management_Entities entity = new company_management_Entities();
        private static TaskDAO instance;
        public static TaskDAO Instance
        {
            get { if (instance == null) instance = new TaskDAO(); return TaskDAO.instance; }
            private set => TaskDAO.instance = value;
        }

        private TaskDAO() { }
        public List<task> GetALlTask()
        {
            return entity.tasks.ToList<task>();
        }

        public void AddTask(string taskName, string description, DateTime deadline,
            int idAssignee, int idProject, float bonus)
        {
            task task = new task();
            task.idCreator = UserSession.LoggedInUser.id;
            task.taskName = taskName;
            task.description = description;
            task.deadline = deadline;
            task.idAssignee = idAssignee;
            task.idProject = idProject;
            task.bonus = bonus;
            task.progress = 0;
            
                entity.tasks.Add(task);
                entity.SaveChanges();
                MessageBox.Show("Thêm thành công");
            

        }
    }
}
