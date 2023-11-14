using company_management.View.UC;
using FullScreenAppDemo.DAO;
using Project_Management;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management.View
{
    public partial class FormAddTeam : Form
    {
        public FormAddTeam()
        {
            InitializeComponent();
            LoadIdLeaders();
        }
        private void LoadIdLeaders()
        {
            // Assuming you have a method in your UserDAO to get a list of leaders
            List<user> leaders = UserDAO.Instance.GetALlUser();

            // Assuming you have a property in your user class like "Username" for display
            cb_Leader.DataSource = leaders;
            cb_Leader.DisplayMember = "Username";
            cb_Leader.ValueMember = "Id";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Close the form when cancel button is clicked
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Retrieve values from controls
            string name = tb_teamName.Text;
            string description = tb_Desciption.Text;
            int idLeader = Convert.ToInt32(cb_Leader.SelectedValue);
            // Assuming you have a method to convert image to byte array
            byte[] avatar = Util.Instance.ImageToByteArray(PbAvatar.Image);

            // Add the team using the TeamDAO method
            TeamDAO.Instance.AddTeam(name, description, idLeader, avatar);

            // Optionally, you can close the form or perform other actions after saving
            this.Close();
        }

        private void btnUpdateAvatar_Click(object sender, EventArgs e)
        {
            // Allow the user to browse for an image and display it in the PictureBox
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PbAvatar.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
