using FullScreenAppDemo.DAO;
using FullScreenAppDemo.DTO;
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
            LoadCB();
        }
        void LoadCB()
        {
            ProjectDAO.Instance.LoadTeamToCombobox(cb_AssigneeTeam);
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
                int IdAssignee = (cb_AssigneeTeam.SelectedItem as Team).IdLeader;
                string name = tb_projectName.Text;
                string desc = tb_Desciption.Text;
                int progress = 0;
                int idteam = (cb_AssigneeTeam.SelectedItem as Team).Id;
                float bonus = (float)Convert.ToInt32(tb_Bonus.Text);
                int count = ProjectDAO.Instance.AddProject(idCreator, IdAssignee, name, desc, dt_startDate.Value, dt_endDate.Value, progress, idteam, bonus);
                if (count > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }


            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

