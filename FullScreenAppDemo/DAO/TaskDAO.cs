using company_management.DTO;
using company_management.View;
using FullScreenAppDemo.DTO;
using Project_Management;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


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
            try
            {
                task task = new task();
                task.taskName = taskName;
                task.description = description;
                task.deadline = deadline;
                task.idAssignee = idAssignee;
                task.idProject = idProject;
                task.bonus = bonus;
                task.progress = 0;

                entity.tasks.Add(task);
                entity.SaveChanges();
                Util.Instance.Alert("Add task success", FormAlert.enmType.Success);
            }
            catch (Exception ex)
            {

                Util.Instance.Alert("Add task fail", FormAlert.enmType.Error);
            }


        }

        internal void DeleteTasksByProject(int projectId)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    var tasksToDelete = entity.tasks.Where(t => t.idProject == projectId);
                    if (tasksToDelete.Any())
                    {
                        entity.tasks.RemoveRange(tasksToDelete);
                        entity.SaveChanges();
                        Util.Instance.Alert("Delete task success", FormAlert.enmType.Success);
                    }
                    else
                    {
                        Util.Instance.Alert("Not found task!", FormAlert.enmType.Warning);
                    }
                }
                catch (Exception)
                {
                    Util.Instance.Alert("Delete task fail!", FormAlert.enmType.Error);
                }
            }
        }

        internal TaskStatusPercentage GetTaskStatusPercentage(List<task> taskList)
        {
            TaskStatusPercentage taskStatus = new TaskStatusPercentage(0, 0, 0);

            if (taskList.Count > 0)
            {
                double totalTasks = taskList.Count;
                double todoCount = taskList.Count(task => task.progress == 0);
                double inprogressCount = taskList.Count(task => task.progress > 0 && task.progress < 100);
                double doneCount = taskList.Count(task => task.progress == 100);

                taskStatus.TodoPercent = (todoCount / totalTasks) * 100;
                taskStatus.InprogressPercent = (inprogressCount / totalTasks) * 100;
                taskStatus.DonePercent = (doneCount / totalTasks) * 100;
            }

            return taskStatus;
        }
    }
}
