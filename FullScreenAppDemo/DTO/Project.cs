using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Linq;

namespace FullScreenAppDemo.DTO
{
    internal class Project
    {
        public int Id { get; set; }
        public int IdCreator { get; set; }
        public int IdAssignee { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Progress { get; set; }
        public int IdTeam { get; set; }
        public float Bonus { get; set; }

        public Project() { }

        public Project(int idCreator, int idAssignee, string name, string description,
            DateTime startDate, DateTime endDate, int progress, int idTeam, float bonus)
        {
            IdCreator = idCreator;
            IdAssignee = idAssignee;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Progress = progress;
            IdTeam = idTeam;
            Bonus = bonus;
        }

    }
}
