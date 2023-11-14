
﻿using Project_Management.View;
using Project_Management.DAO;
using Project_Management.DTO;

﻿using company_management.DTO;
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


namespace Project_Management.DAO
{
    internal class TaskDAO
    {
        company_management_Entities entity = new company_management_Entities();
        private readonly UserDAO _userDao = new UserDAO();
        private readonly TeamDAO _teamDao = new TeamDAO();
        private static TaskDAO instance;

        public static TaskDAO Instance
        {
            get { if (instance == null) instance = new TaskDAO(); return TaskDAO.instance; }
            private set => TaskDAO.instance = value;
        }

        public TaskDAO() { }

        public List<task> GetAllTask()
        {
            var result = entity.tasks.ToList();
            return result;

        }

        public List<task> GetListTaskByPosition()
        {
            int idPosition;
            int idUser = UserSession.LoggedInUser.id;

            if (UserSession.LoggedInUser.idPosition != null)
            {
                idPosition = (int)UserSession.LoggedInUser.idPosition;
            }
            else
            {
                idPosition = 3;
            }

            List<task> result = new List<task>();

            if (_userDao.IsManager() || _userDao.IsHumanResources())
            {
                result = GetAllTask();
            }
            else if (_userDao.IsLeader())
            {
                var teams = _teamDao.GetTeamByLeader(idUser);
                foreach (var team in teams)
                {
                    var listTaskOfTeam = GetTasksByIDTeam(team.id);
                    foreach (var taskOfTeam in listTaskOfTeam)
                    {
                        result.Add(taskOfTeam);
                    }
                }
            }
            else
            {
                result = GetTasksAssignedByCurrentUser(idUser);
            }
            return result;
        }

        public List<task> GetTodoTasks()
        {
            return GetListTaskByPosition().Where(t => t.progress == 0).ToList();   
        }

        public List<task> GetInprogressTasks()
        {
            return GetListTaskByPosition().Where(t => t.progress != 0 && t.progress != 100).ToList();
        }

        public List<task> GetDoneTasks()
        {
            return GetListTaskByPosition().Where(t => t.progress == 100).ToList();
        }

        public List<task> GetTasksByIDTeam(int idTeam)
        {
            var result = from t in entity.tasks where t.idTeam == idTeam select t;
            return result.ToList();
        }

        public List<task> GetTasksAssignedByCurrentUser(int idUser)
        {
            var result = GetAllTask().Where(t => t.idAssignee == idUser).ToList();
            return result;
        }

        public List<task> GetMyTask()
        {
            var result = GetListTaskByPosition().Where(t => t.idAssignee == UserSession.LoggedInUser.id).ToList();
            return result;
        }

        public task GetTaskByTaskID(int taskID)
        {
            var result = entity.tasks.Find(taskID);
            return result;
        }

        public void AddTask(string taskName, string description, DateTime deadline, int idTeam,
            int idAssignee, int idProject, double bonus)
        {
            try
            {
                task task = new task();
                task.taskName = taskName;
                task.description = description;
                task.deadline = deadline;
                task.idTeam = idTeam;
                if(idAssignee == -1)
                {
                    task.idAssignee = null;
                }
                else
                {
                    task.idAssignee = idAssignee;
                }
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

        public void UpdateTask(int taskId, string taskName, string description, DateTime deadline, int idTeam,
    int idAssignee, int progress, int idProject, double bonus)
        {
            try
            {
                task existingTask = entity.tasks.FirstOrDefault(t => t.id == taskId);

                if (existingTask != null)
                {
                    existingTask.taskName = taskName;
                    existingTask.description = description;
                    existingTask.progress = progress;
                    existingTask.deadline = deadline;
                    existingTask.idTeam = idTeam;

                    if (idAssignee == -1)
                    {
                        existingTask.idAssignee = null;
                    }
                    else
                    {
                        existingTask.idAssignee = idAssignee;
                    }

                    existingTask.idProject = idProject;
                    existingTask.bonus = bonus;

                    entity.SaveChanges();

                    Util.Instance.Alert("Update task success", FormAlert.enmType.Success);
                }
                else
                {
                    Util.Instance.Alert("Task not found", FormAlert.enmType.Error);
                }
            }
            catch (Exception ex)
            {
                Util.Instance.Alert("Update task fail", FormAlert.enmType.Error);
            }
        }

        public void DeleteTask(int taskId)
        {
            try
            {
                task taskToDelete = entity.tasks.FirstOrDefault(t => t.id == taskId);

                if (taskToDelete != null)
                {
                    entity.tasks.Remove(taskToDelete);
                    entity.SaveChanges();

                    Util.Instance.Alert("Delete task success!!!", FormAlert.enmType.Success);
                }
            }
            catch (Exception ex)
            {
                Util.Instance.Alert("Delete task fail!!!", FormAlert.enmType.Error);
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

        private List<task> GetTaskByIdUser(int id)
        {
            return entity.tasks.Where(t => t.idAssignee == id).ToList<task>();
        }
        public int CountTotalTasks()
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
                {
                    return GetALlTask().Count;
                }
                else
                {
                    return GetTaskByIdUser(UserSession.LoggedInUser.id).Count;
                }


                return 0;
            }
        }


    }
}
