using FullScreenAppDemo.DAO;
using Project_Management.Utils;
using Project_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Win32;

namespace Project_Management.View
{
    public partial class FormUpdateTeam : Form
    {
        private int teamId; // To store the ID of the team being updated
        private string currentImagePath;  // Add a class-level variable to store the current image path
        public FormUpdateTeam()
        {
            InitializeComponent();
        }
        // Add a property to set the team ID
        public int TeamId
        {
            set
            {
                teamId = value;
                LoadTeamInfo();
            }
        }
        private void LoadTeamInfo()
        {
            // Retrieve the team information from the database using the TeamDAO
            team currentTeam = TeamDAO.Instance.GetTeamByIdTeam(teamId);

            // Populate the form controls with the team information
            if (currentTeam != null)
            {
                tb_teamName.Text = currentTeam.name;
                tb_Desciption.Text = currentTeam.description;

                // Assuming you have a method to get a list of leaders from the UserDAO
                List<user> leaders = UserDAO.Instance.GetALlUser();
                cb_Leader.DataSource = leaders;
                cb_Leader.DisplayMember = "Username";
                cb_Leader.ValueMember = "Id";
                cb_Leader.SelectedValue = currentTeam.idLeader;

                // Assuming you have a method to convert byte array to Image in Util
                PbAvatar.Image = Util.Instance.ByteArrayToImage(currentTeam.avatar);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Retrieve values from controls
            string name = tb_teamName.Text;
            string description = tb_Desciption.Text;
            int idLeader = Convert.ToInt32(cb_Leader.SelectedValue);

            byte[] avatar;

            // Check if a new image is selected
            if (!string.IsNullOrEmpty(currentImagePath))
            {
                // If a new image is selected, convert and update the avatar
                avatar = Util.Instance.ImageToByteArray(PbAvatar.Image);
            }
            else
            {
                // If no new image is selected, keep the original avatar
                avatar = Util.Instance.ImageToByteArray((Image)PbAvatar.Image.Clone());
            }

            // Update the team using the TeamDAO method
            TeamDAO.Instance.UpdateTeam(teamId, name, description, idLeader, avatar);

            // Optionally, you can close the form or perform other actions after saving
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PbAvatar.Image = Image.FromFile(openFileDialog1.FileName);
                currentImagePath = openFileDialog1.FileName;  // Save the current image path
            }
        }
    }
}
