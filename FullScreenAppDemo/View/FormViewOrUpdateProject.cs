using FullScreenAppDemo.DAO;
using Project_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management
{

    public partial class FormViewOrUpdateProject : Form
    {
        private int _selectedId;
        public int SelectedId { get => _selectedId; set => _selectedId = value; }
        public FormViewOrUpdateProject()
        {
            InitializeComponent();
        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        void LoadCB()
        {
            for (int i = 0; i <= 10; i++)
                combobox2_progress.Items.Add((i * 10).ToString());
        }
        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(textbox_projectName.Text) || string.IsNullOrEmpty(textbox_Desciption.Text))
            {
                MessageBox.Show(@"Please fill out all text again!");
                return false;
            }
            return true;
        }
        void LoadData()
        {

            project project = ProjectDAO.Instance.GetProjectById(_selectedId);
            if (project.progress == 100 || UserDAO.Instance.IsEmployee())
            {
                button_save.Text = "Exit";
                combobox2_progress.Items.Add(project.progress);
                combobox2_progress.SelectedIndex = 0;
                textbox_projectName.ReadOnly = true;
                textbox_Desciption.ReadOnly = true;
                textBox_projectBonus.ReadOnly = true;
                dateTime_endDate2.Enabled = false;
                dateTime_startDate2.Enabled = false;
                combobox2_progress.Enabled = false;
            }
            else if (UserDAO.Instance.IsLeader())
            {
                LoadCB();
                int index = (int)project.progress / 10;
                combobox2_progress.SelectedIndex = index;
                textbox_projectName.ReadOnly = true;
                textbox_Desciption.ReadOnly = true;
                textBox_projectBonus.ReadOnly = true;
                dateTime_endDate2.Enabled = false;
                dateTime_startDate2.Enabled = false;
            }
            else
            {
                LoadCB();
                int index = (int)project.progress / 10;
                combobox2_progress.SelectedIndex = index;
                
            }

            team assigneeTeam = TeamDAO.Instance.GetTeamByIdTeam((int)project.idTeam);
            picturebox_teamAvatar2.Image = ByteArrayToImage(assigneeTeam.avatar);
            label2_assigneedTeam.Text = assigneeTeam.name;


            user assigneeUser = UserDAO.Instance.GetUserByID((int)project.idAssignee);
            label2_assignedPerson.Text = assigneeUser.fullName;
            picturebox_userAvatar2.Image = ByteArrayToImage(assigneeUser.avatar);

            textbox_projectName.Text = project.name;
            textbox_Desciption.Text = project.description;
            textBox_projectBonus.Text = ((float)project.bonus).ToString(CultureInfo.InvariantCulture);



            circleProgressBar2.Value = (int)project.progress;
            progressValue2.Text = ((int)project.progress).ToString("0.'%'");



            try
            {
                dateTime_startDate2.Value = (DateTime)project.startDate;
                dateTime_endDate2.Value = (DateTime)project.endDate;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void FormViewOrUpdateProject_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void combobox2_progress_SelectedIndexChanged(object sender, EventArgs e)
        {
            int progress = Convert.ToInt32(combobox2_progress.SelectedItem);
            circleProgressBar2.Value = progress;
            progressValue2.Text = progress.ToString("0.'%'");
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (button_save.Text == "Exit")
            {
                this.Close();
                return;
            }
            if (CheckDataInput())
            {
                project project = ProjectDAO.Instance.GetProjectById(_selectedId);
                project.name = textbox_projectName.Text;
                project.description = textbox_Desciption.Text;
                project.progress = int.Parse(combobox2_progress.SelectedItem.ToString());
                project.startDate = dateTime_startDate2.Value;
                project.endDate = dateTime_endDate2.Value;
                if (textBox_projectBonus.Text != "")
                {
                    project.bonus = float.Parse(textBox_projectBonus.Text);
                }
                if(project.progress == 100)
                {
                    if(MessageBox.Show("This project is done?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                        ProjectDAO.Instance.UpdateProject(project);
                }
                
            }
        }


    }
}
