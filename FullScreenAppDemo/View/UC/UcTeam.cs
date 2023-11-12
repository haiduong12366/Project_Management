﻿using FullScreenAppDemo.DAO;
using FullScreenAppDemo.View;
using Guna.UI2.WinForms.Suite;
using Project_Management;
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
        private void LoadTeamData1()
        {
            // Get the list of teams from the DAO
            var teams = TeamDAO.Instance.GetAllTeams();

            // Bind the list to the DataGridView
            dataGridView_Team.DataSource = teams;

            // Optionally, you can customize the DataGridView appearance or handle other UI logic here.
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
            nameColumn.DataPropertyName = "Tên nhóm";
            nameColumn.HeaderText = "Tên nhóm";
            dataGridView_Team.Columns.Add(nameColumn);

            // Description column
            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Mô tả nhóm";
            descriptionColumn.HeaderText = "Mô tả nhóm";
            dataGridView_Team.Columns.Add(descriptionColumn);

            // ID Leader column
            DataGridViewTextBoxColumn idLeaderColumn = new DataGridViewTextBoxColumn();
            idLeaderColumn.DataPropertyName = "ID trưởng nhóm";
            idLeaderColumn.HeaderText = "ID trưởng nhóm";
            dataGridView_Team.Columns.Add(idLeaderColumn);

            // Avatar column (assuming it contains byte array data)
            DataGridViewImageColumn avatarColumn = new DataGridViewImageColumn();
            avatarColumn.DataPropertyName = "Avatar";
            avatarColumn.HeaderText = "Avatar";
            dataGridView_Team.Columns.Add(avatarColumn);

            // Populate data
            List<team> teams = TeamDAO.Instance.GetAllTeams();
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
            FormAddTeam addTeam = new FormAddTeam();
            addTeam.ShowDialog();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView_Team.SelectedRows.Count > 0)
            {
                // Get the ID of the selected team from the DataGridView
                int selectedTeamId = Convert.ToInt32(dataGridView_Team.SelectedRows[0].Cells[0].Value);

                // Open the FormUpdateTeam with the selected team ID
                FormUpdateTeam updateForm = new FormUpdateTeam();
                updateForm.TeamId = selectedTeamId;
                updateForm.ShowDialog();

                // Optionally, you can reload the data after the update form is closed
                LoadTeamData();
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
                MessageBox.Show("Please select a team to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     
    }
}
