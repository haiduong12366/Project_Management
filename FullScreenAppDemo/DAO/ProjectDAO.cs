using FullScreenAppDemo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public int AddProject(int idCreator, int idAssignee, string name, string description,
            DateTime startDate, DateTime endDate, int progress, int idTeam, float bonus)
        {
            string sql = "USP_AddProject @idCreator , @idAssignee , @name , @description , @startDate , @endDate , @progress , @idTeam , @bonus ";
            try
            {
                int count = DBConnection.Instance.ExecuteNonQuery(sql, new object[] {idCreator, idAssignee,name, description,
            startDate, endDate, progress, idTeam, bonus});
                return count;
            }
            catch { return 0; }
           
            }
            public void LoadTeamToCombobox(ComboBox comboBox)
            {
                List<Team> list = TeamDAO.Instance.GetAllTeams();

                comboBox.DataSource = list;
                comboBox.DisplayMember = "name";
                comboBox.ValueMember = "id";
                comboBox.SelectedIndex = 0;
            }
        }
    }
