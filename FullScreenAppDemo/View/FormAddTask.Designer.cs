
namespace Project_Management.view
{
    partial class FormAddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTask));
            this.combbox_Project = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Bonus = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTime_deadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.combbox_Assignee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_taskName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_Desciption = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_taskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gboxTask = new System.Windows.Forms.GroupBox();
            this.combbox_UserOfTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labAssigneesUser = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.gboxTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // combbox_Project
            // 
            this.combbox_Project.BackColor = System.Drawing.Color.Transparent;
            this.combbox_Project.BorderRadius = 5;
            this.combbox_Project.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combbox_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbox_Project.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_Project.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_Project.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.combbox_Project.ForeColor = System.Drawing.Color.Black;
            this.combbox_Project.ItemHeight = 30;
            this.combbox_Project.Location = new System.Drawing.Point(524, 177);
            this.combbox_Project.Margin = new System.Windows.Forms.Padding(2);
            this.combbox_Project.Name = "combbox_Project";
            this.combbox_Project.Size = new System.Drawing.Size(256, 36);
            this.combbox_Project.TabIndex = 122;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(523, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 121;
            this.label4.Text = "Project";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(521, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 119;
            this.label1.Text = "Bonus ($)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Bonus
            // 
            this.textBox_Bonus.BorderColor = System.Drawing.Color.Black;
            this.textBox_Bonus.BorderRadius = 5;
            this.textBox_Bonus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Bonus.DefaultText = "";
            this.textBox_Bonus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Bonus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Bonus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Bonus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Bonus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Bonus.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBox_Bonus.ForeColor = System.Drawing.Color.Black;
            this.textBox_Bonus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Bonus.Location = new System.Drawing.Point(525, 375);
            this.textBox_Bonus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Bonus.Name = "textBox_Bonus";
            this.textBox_Bonus.PasswordChar = '\0';
            this.textBox_Bonus.PlaceholderText = "Exp: 200 $";
            this.textBox_Bonus.SelectedText = "";
            this.textBox_Bonus.Size = new System.Drawing.Size(255, 28);
            this.textBox_Bonus.TabIndex = 120;
            // 
            // dateTime_deadline
            // 
            this.dateTime_deadline.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_deadline.Location = new System.Drawing.Point(525, 314);
            this.dateTime_deadline.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_deadline.Name = "dateTime_deadline";
            this.dateTime_deadline.Size = new System.Drawing.Size(255, 26);
            this.dateTime_deadline.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(38, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 117;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combbox_Assignee
            // 
            this.combbox_Assignee.BackColor = System.Drawing.Color.Transparent;
            this.combbox_Assignee.BorderRadius = 5;
            this.combbox_Assignee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combbox_Assignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbox_Assignee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_Assignee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_Assignee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbox_Assignee.ForeColor = System.Drawing.Color.Black;
            this.combbox_Assignee.ItemHeight = 30;
            this.combbox_Assignee.Location = new System.Drawing.Point(524, 108);
            this.combbox_Assignee.Margin = new System.Windows.Forms.Padding(2);
            this.combbox_Assignee.Name = "combbox_Assignee";
            this.combbox_Assignee.Size = new System.Drawing.Size(256, 36);
            this.combbox_Assignee.TabIndex = 114;
            this.combbox_Assignee.SelectedIndexChanged += new System.EventHandler(this.combbox_Assignee_SelectedIndexChanged);
            // 
            // label_taskName
            // 
            this.label_taskName.AutoSize = true;
            this.label_taskName.BackColor = System.Drawing.Color.Transparent;
            this.label_taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taskName.ForeColor = System.Drawing.Color.Black;
            this.label_taskName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_taskName.Location = new System.Drawing.Point(38, 72);
            this.label_taskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_taskName.Name = "label_taskName";
            this.label_taskName.Size = new System.Drawing.Size(82, 18);
            this.label_taskName.TabIndex = 109;
            this.label_taskName.Text = "Task name";
            this.label_taskName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(523, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 110;
            this.label3.Text = "Due date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(523, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 113;
            this.label7.Text = "Assignees team";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbox_Desciption
            // 
            this.txtbox_Desciption.BorderColor = System.Drawing.Color.Black;
            this.txtbox_Desciption.BorderRadius = 5;
            this.txtbox_Desciption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Desciption.DefaultText = "";
            this.txtbox_Desciption.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_Desciption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_Desciption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Desciption.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Desciption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Desciption.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtbox_Desciption.ForeColor = System.Drawing.Color.Black;
            this.txtbox_Desciption.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Desciption.Location = new System.Drawing.Point(40, 170);
            this.txtbox_Desciption.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbox_Desciption.Multiline = true;
            this.txtbox_Desciption.Name = "txtbox_Desciption";
            this.txtbox_Desciption.PasswordChar = '\0';
            this.txtbox_Desciption.PlaceholderText = "Description of task";
            this.txtbox_Desciption.SelectedText = "";
            this.txtbox_Desciption.Size = new System.Drawing.Size(438, 233);
            this.txtbox_Desciption.TabIndex = 112;
            // 
            // txtbox_taskName
            // 
            this.txtbox_taskName.BorderColor = System.Drawing.Color.Black;
            this.txtbox_taskName.BorderRadius = 5;
            this.txtbox_taskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_taskName.DefaultText = "";
            this.txtbox_taskName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_taskName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_taskName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_taskName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_taskName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_taskName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtbox_taskName.ForeColor = System.Drawing.Color.Black;
            this.txtbox_taskName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_taskName.Location = new System.Drawing.Point(40, 96);
            this.txtbox_taskName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbox_taskName.Name = "txtbox_taskName";
            this.txtbox_taskName.PasswordChar = '\0';
            this.txtbox_taskName.PlaceholderText = "This is task name";
            this.txtbox_taskName.SelectedText = "";
            this.txtbox_taskName.Size = new System.Drawing.Size(438, 26);
            this.txtbox_taskName.TabIndex = 111;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BorderRadius = 19;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(40, 477);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 41);
            this.btnCancel.TabIndex = 116;
            this.btnCancel.Text = "Refresh";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BorderRadius = 20;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(554, 477);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 41);
            this.btnSave.TabIndex = 115;
            this.btnSave.Text = "Add";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gboxTask
            // 
            this.gboxTask.Controls.Add(this.combbox_UserOfTeam);
            this.gboxTask.Controls.Add(this.labAssigneesUser);
            this.gboxTask.Controls.Add(this.btnClose);
            this.gboxTask.Controls.Add(this.combbox_Project);
            this.gboxTask.Controls.Add(this.label4);
            this.gboxTask.Controls.Add(this.label1);
            this.gboxTask.Controls.Add(this.textBox_Bonus);
            this.gboxTask.Controls.Add(this.dateTime_deadline);
            this.gboxTask.Controls.Add(this.label2);
            this.gboxTask.Controls.Add(this.btnCancel);
            this.gboxTask.Controls.Add(this.btnSave);
            this.gboxTask.Controls.Add(this.combbox_Assignee);
            this.gboxTask.Controls.Add(this.label_taskName);
            this.gboxTask.Controls.Add(this.label3);
            this.gboxTask.Controls.Add(this.label7);
            this.gboxTask.Controls.Add(this.txtbox_Desciption);
            this.gboxTask.Controls.Add(this.txtbox_taskName);
            this.gboxTask.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTask.Location = new System.Drawing.Point(68, 34);
            this.gboxTask.Margin = new System.Windows.Forms.Padding(2);
            this.gboxTask.Name = "gboxTask";
            this.gboxTask.Padding = new System.Windows.Forms.Padding(2);
            this.gboxTask.Size = new System.Drawing.Size(820, 542);
            this.gboxTask.TabIndex = 125;
            this.gboxTask.TabStop = false;
            this.gboxTask.Text = "Add Task";
            // 
            // combbox_UserOfTeam
            // 
            this.combbox_UserOfTeam.BackColor = System.Drawing.Color.Transparent;
            this.combbox_UserOfTeam.BorderRadius = 5;
            this.combbox_UserOfTeam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combbox_UserOfTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbox_UserOfTeam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_UserOfTeam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_UserOfTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbox_UserOfTeam.ForeColor = System.Drawing.Color.Black;
            this.combbox_UserOfTeam.ItemHeight = 30;
            this.combbox_UserOfTeam.Location = new System.Drawing.Point(524, 245);
            this.combbox_UserOfTeam.Margin = new System.Windows.Forms.Padding(2);
            this.combbox_UserOfTeam.Name = "combbox_UserOfTeam";
            this.combbox_UserOfTeam.Size = new System.Drawing.Size(256, 36);
            this.combbox_UserOfTeam.TabIndex = 128;
            this.combbox_UserOfTeam.SelectedIndexChanged += new System.EventHandler(this.combbox_UserOfTeam_SelectedIndexChanged);
            // 
            // labAssigneesUser
            // 
            this.labAssigneesUser.AutoSize = true;
            this.labAssigneesUser.BackColor = System.Drawing.Color.Transparent;
            this.labAssigneesUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAssigneesUser.ForeColor = System.Drawing.Color.Black;
            this.labAssigneesUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAssigneesUser.Location = new System.Drawing.Point(522, 225);
            this.labAssigneesUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labAssigneesUser.Name = "labAssigneesUser";
            this.labAssigneesUser.Size = new System.Drawing.Size(109, 18);
            this.labAssigneesUser.TabIndex = 127;
            this.labAssigneesUser.Text = "Assignees user";
            this.labAssigneesUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BorderRadius = 20;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Project_Management.Properties.Resources.x;
            this.btnClose.Location = new System.Drawing.Point(656, 477);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 41);
            this.btnClose.TabIndex = 126;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 601);
            this.Controls.Add(this.gboxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddTask";
            this.Text = "FormAddTask";
            this.gboxTask.ResumeLayout(false);
            this.gboxTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox combbox_Project;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Bonus;
        private System.Windows.Forms.DateTimePicker dateTime_deadline;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox combbox_Assignee;
        private System.Windows.Forms.Label label_taskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Desciption;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_taskName;
        private System.Windows.Forms.GroupBox gboxTask;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox combbox_UserOfTeam;
        private System.Windows.Forms.Label labAssigneesUser;
    }
}