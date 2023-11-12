using FullScreenAppDemo.DAO;
using FullScreenAppDemo.DTO;
using FullScreenAppDemo.View;
using Guna.UI2.WinForms.Suite;
using Project_Management;
using Project_Management.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using System.Xml.Linq;


namespace company_management.View.UC
{
    public partial class UcTeam : UserControl
    {
        public UcTeam()
        {
            InitializeComponent();
            TeamDAO.Instance.TeamDataChanged += LoadTeamData;
            LoadTeamData();
        }
        private void LoadTeamData()
        {
            // Clear existing columns and rows
            dataGridView_Team.Columns.Clear();
            dataGridView_Team.Rows.Clear();

            // Create columns
            dataGridView_Team.AutoGenerateColumns = false;

            // ID column
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "ID";
            idColumn.HeaderText = "ID";
            idColumn.Visible = false;
            dataGridView_Team.Columns.Add(idColumn);

            // Team Name column
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Team Name";
            nameColumn.HeaderText = "Team Name";
            dataGridView_Team.Columns.Add(nameColumn);

            // Description column
            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.HeaderText = "Description";
            dataGridView_Team.Columns.Add(descriptionColumn);

            // ID Leader column
            DataGridViewTextBoxColumn idLeaderColumn = new DataGridViewTextBoxColumn();
            idLeaderColumn.DataPropertyName = "ID Leader";
            idLeaderColumn.HeaderText = "ID Leader";
            dataGridView_Team.Columns.Add(idLeaderColumn);

            // Avatar column (assuming it contains byte array data)
            DataGridViewImageColumn avatarColumn = new DataGridViewImageColumn();
            avatarColumn.DataPropertyName = "Avatar";
            avatarColumn.HeaderText = "Avatar";
            dataGridView_Team.Columns.Add(avatarColumn);

            // Populate data
            List<team> teams;

            if (UserDAO.Instance.IsHumanResources() || UserDAO.Instance.IsManager())
            {
                // Nếu là Human Resources hoặc Manager, hiển thị toàn bộ danh sách
                teams = TeamDAO.Instance.GetAllTeams();
            }
            else if (UserDAO.Instance.IsLeader())
            {
                // Nếu là Leader, hiển thị danh sách team của Leader
                teams = TeamDAO.Instance.GetTeamByLeader(UserSession.LoggedInUser.id);
            }
            else
            {
                // Nếu là Employee, hiển thị danh sách team của Employee
                teams = TeamDAO.Instance.GetTeamByIDUser();
            }

            foreach (var t in teams)
            {
                // Convert the byte array to an Image
                Image avatarImage = ByteArrayToImage(t.avatar);

                // Add the row to the dataGridView
                dataGridView_Team.Rows.Add(t.id, t.name, t.description, t.idLeader, avatarImage);
            }
        }

        // Function to convert byte array to Image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTeamData();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Check if the user is Manager or Human Resources
            if (UserDAO.Instance.IsManager() || UserDAO.Instance.IsHumanResources())
            {
                FormAddTeam addTeam = new FormAddTeam();
                addTeam.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to add a team.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView_Team.SelectedRows.Count > 0)
            {
                // Get the ID of the selected team from the DataGridView
                int selectedTeamId = Convert.ToInt32(dataGridView_Team.SelectedRows[0].Cells[0].Value);

                // Check if the user is Manager or Human Resources
                if (UserDAO.Instance.IsManager() || UserDAO.Instance.IsHumanResources())
                {
                    // Open the FormUpdateTeam with the selected team ID
                    FormUpdateTeam updateForm = new FormUpdateTeam();
                    updateForm.TeamId = selectedTeamId;
                    updateForm.ShowDialog();

                    // Optionally, you can reload the data after the update form is closed
                    LoadTeamData();
                }
                else
                {
                    MessageBox.Show("You do not have permission to edit this team.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Display a message or handle the case where no row is selected
                MessageBox.Show("Please select a team to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView_Team.SelectedRows.Count > 0)
            {
                // Get the selected team's ID from the DataGridView
                int selectedTeamId = (int)dataGridView_Team.SelectedRows[0].Cells[0].Value;

                // Check if the user is Manager or Human Resources
                if (UserDAO.Instance.IsManager() || UserDAO.Instance.IsHumanResources())
                {
                    // Display a confirmation dialog before deleting
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this team?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Call the delete method in TeamDAO to delete the team
                        TeamDAO.Instance.DeleteTeam(selectedTeamId);

                        // Refresh the data after deletion
                        LoadTeamData();
                    }
                }
                else
                {
                    MessageBox.Show("You do not have permission to delete this team.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a team to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateLabelsBasedOnSelectedTeam(int selectedTeamId)
        {
            // Get the member count, project count, and task count for the selected team
            int memberCount = TeamDAO.Instance.GetTeamMemberCount(selectedTeamId);
            int projectCount = TeamDAO.Instance.GetTeamProjectCount(selectedTeamId);
            int taskCount = TeamDAO.Instance.GetTeamTaskCount(selectedTeamId);

            // Set the count in the labels
            label_member.Text = $"{memberCount}";
            label_project.Text = $"{projectCount}";
            label_task.Text = $"{taskCount}";
        }
        private void dataGridView_Team_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView_Team.SelectedRows.Count > 0)
            {
                if (dataGridView_Team.SelectedRows[0].Cells[2].Value != null)
                {
                    // Get the ID of the selected team from the DataGridView
                    int selectedTeamId = Convert.ToInt32(dataGridView_Team.SelectedRows[0].Cells[0].Value);

                    // Update labels with information based on the selected team
                    UpdateLabelsBasedOnSelectedTeam(selectedTeamId);

                    // Get the description of the selected team from the DataGridView
                    string selectedDescription = dataGridView_Team.SelectedRows[0].Cells[2].Value.ToString();

                    // Update the TextBox with the description
                    txtbox_Desciption.Text = selectedDescription;
                }


            }
        }

    }
}
