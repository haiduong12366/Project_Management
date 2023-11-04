using FullScreenAppDemo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullScreenAppDemo
{
    public partial class FormAddProject : Form
    {
        public FormAddProject()
        {
            InitializeComponent();
            Load();
        }


        void Load()
        {
            LoadTeamToCombobox(cb_AssigneeTeam);
        }
        public void LoadTeamToCombobox(ComboBox comboBox)
        {
            List<team> list = TeamDAO.Instance.GetAllTeams();

            comboBox.DataSource = list;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
            comboBox.SelectedIndex = 0;
        }

        private void ClearFields()
        {
            tb_projectName.Clear();
            tb_Desciption.Clear();
        }

        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(tb_projectName.Text) || string.IsNullOrEmpty(tb_Desciption.Text))
            {
                MessageBox.Show("Các trường bắt buộc chưa được điền. Vui lòng điền đầy đủ thông tin!");
                return false;
            }
            return true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                int idCreator = 1;
                //int idCreator = UserSession.LoggedInUser.Id;
                int IdAssignee = (int)(cb_AssigneeTeam.SelectedItem as team).idLeader;
                string name = tb_projectName.Text;
                string desc = tb_Desciption.Text;
                int progress = 0;
                int idteam = (cb_AssigneeTeam.SelectedItem as team).id;
                float bonus = (float)Convert.ToInt32(tb_Bonus.Text);
                ProjectDAO.Instance.AddProject(idCreator, IdAssignee, name, desc, dt_startDate.Value, dt_endDate.Value, progress, idteam, bonus);
                ClearFields();


            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

