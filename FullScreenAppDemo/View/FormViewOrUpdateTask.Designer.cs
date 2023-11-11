namespace Project_Management.View
{
    partial class FormViewOrUpdateTask
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
            this.label_assigneedTeam = new System.Windows.Forms.Label();
            this.picturebox_teamAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combbox_Project = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combbox_Assignee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Bonus = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.dateTime_deadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label_taskName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_Desciption = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_Taskname = new Guna.UI2.WinForms.Guna2TextBox();
            this.combobox_progress = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.circleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressValue = new System.Windows.Forms.Label();
            this.label_assigneedPerson = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picturebox_userAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gboxTask = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_teamAvatar)).BeginInit();
            this.circleProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_userAvatar)).BeginInit();
            this.gboxTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_assigneedTeam
            // 
            this.label_assigneedTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_assigneedTeam.ForeColor = System.Drawing.Color.Black;
            this.label_assigneedTeam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_assigneedTeam.Location = new System.Drawing.Point(540, 140);
            this.label_assigneedTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_assigneedTeam.Name = "label_assigneedTeam";
            this.label_assigneedTeam.Size = new System.Drawing.Size(218, 23);
            this.label_assigneedTeam.TabIndex = 213;
            this.label_assigneedTeam.Text = "Team";
            this.label_assigneedTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picturebox_teamAvatar
            // 
            this.picturebox_teamAvatar.FillColor = System.Drawing.Color.Transparent;
            this.picturebox_teamAvatar.ImageRotate = 0F;
            this.picturebox_teamAvatar.Location = new System.Drawing.Point(501, 136);
            this.picturebox_teamAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.picturebox_teamAvatar.Name = "picturebox_teamAvatar";
            this.picturebox_teamAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picturebox_teamAvatar.Size = new System.Drawing.Size(38, 37);
            this.picturebox_teamAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_teamAvatar.TabIndex = 212;
            this.picturebox_teamAvatar.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(502, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 211;
            this.label8.Text = "Assigned team";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combbox_Project
            // 
            this.combbox_Project.BackColor = System.Drawing.Color.Transparent;
            this.combbox_Project.BorderRadius = 5;
            this.combbox_Project.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combbox_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbox_Project.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_Project.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_Project.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbox_Project.ForeColor = System.Drawing.Color.Black;
            this.combbox_Project.ItemHeight = 30;
            this.combbox_Project.Location = new System.Drawing.Point(505, 285);
            this.combbox_Project.Margin = new System.Windows.Forms.Padding(2);
            this.combbox_Project.Name = "combbox_Project";
            this.combbox_Project.Size = new System.Drawing.Size(254, 36);
            this.combbox_Project.TabIndex = 210;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(501, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 209;
            this.label7.Text = "Project";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combbox_Assignee
            // 
            this.combbox_Assignee.BackColor = System.Drawing.Color.Transparent;
            this.combbox_Assignee.BorderRadius = 5;
            this.combbox_Assignee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combbox_Assignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combbox_Assignee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_Assignee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combbox_Assignee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combbox_Assignee.ForeColor = System.Drawing.Color.Black;
            this.combbox_Assignee.ItemHeight = 30;
            this.combbox_Assignee.Location = new System.Drawing.Point(505, 217);
            this.combbox_Assignee.Margin = new System.Windows.Forms.Padding(2);
            this.combbox_Assignee.Name = "combbox_Assignee";
            this.combbox_Assignee.Size = new System.Drawing.Size(254, 36);
            this.combbox_Assignee.TabIndex = 208;
            this.combbox_Assignee.SelectedIndexChanged += new System.EventHandler(this.combbox_Assignee_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(501, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 207;
            this.label6.Text = "Assignees";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(61, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 205;
            this.label4.Text = "Bonus ($)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.textBox_Bonus.Location = new System.Drawing.Point(63, 463);
            this.textBox_Bonus.Name = "textBox_Bonus";
            this.textBox_Bonus.PasswordChar = '\0';
            this.textBox_Bonus.PlaceholderText = "Exp: 200 $";
            this.textBox_Bonus.SelectedText = "";
            this.textBox_Bonus.Size = new System.Drawing.Size(102, 26);
            this.textBox_Bonus.TabIndex = 206;
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
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(59, 513);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 41);
            this.btnCancel.TabIndex = 204;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BorderRadius = 19;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(183, 513);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 41);
            this.btnSave.TabIndex = 203;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTime_deadline
            // 
            this.dateTime_deadline.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_deadline.Location = new System.Drawing.Point(505, 359);
            this.dateTime_deadline.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_deadline.Name = "dateTime_deadline";
            this.dateTime_deadline.Size = new System.Drawing.Size(254, 26);
            this.dateTime_deadline.TabIndex = 202;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(61, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 201;
            this.label2.Text = "Desription";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_taskName
            // 
            this.label_taskName.AutoSize = true;
            this.label_taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taskName.ForeColor = System.Drawing.Color.Black;
            this.label_taskName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_taskName.Location = new System.Drawing.Point(61, 42);
            this.label_taskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_taskName.Name = "label_taskName";
            this.label_taskName.Size = new System.Drawing.Size(82, 18);
            this.label_taskName.TabIndex = 197;
            this.label_taskName.Text = "Task name";
            this.label_taskName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(501, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 198;
            this.label3.Text = "Due date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtbox_Desciption.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Desciption.ForeColor = System.Drawing.Color.Black;
            this.txtbox_Desciption.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Desciption.Location = new System.Drawing.Point(63, 136);
            this.txtbox_Desciption.Multiline = true;
            this.txtbox_Desciption.Name = "txtbox_Desciption";
            this.txtbox_Desciption.PasswordChar = '\0';
            this.txtbox_Desciption.PlaceholderText = "";
            this.txtbox_Desciption.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_Desciption.SelectedText = "";
            this.txtbox_Desciption.Size = new System.Drawing.Size(411, 292);
            this.txtbox_Desciption.TabIndex = 200;
            // 
            // txtbox_Taskname
            // 
            this.txtbox_Taskname.BorderColor = System.Drawing.Color.Black;
            this.txtbox_Taskname.BorderRadius = 5;
            this.txtbox_Taskname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Taskname.DefaultText = "";
            this.txtbox_Taskname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_Taskname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_Taskname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Taskname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_Taskname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Taskname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Taskname.ForeColor = System.Drawing.Color.Black;
            this.txtbox_Taskname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_Taskname.Location = new System.Drawing.Point(63, 65);
            this.txtbox_Taskname.Name = "txtbox_Taskname";
            this.txtbox_Taskname.PasswordChar = '\0';
            this.txtbox_Taskname.PlaceholderText = "";
            this.txtbox_Taskname.SelectedText = "";
            this.txtbox_Taskname.Size = new System.Drawing.Size(411, 26);
            this.txtbox_Taskname.TabIndex = 199;
            // 
            // combobox_progress
            // 
            this.combobox_progress.BackColor = System.Drawing.Color.Transparent;
            this.combobox_progress.BorderRadius = 5;
            this.combobox_progress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_progress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_progress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_progress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_progress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_progress.ForeColor = System.Drawing.Color.Black;
            this.combobox_progress.ItemHeight = 30;
            this.combobox_progress.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.combobox_progress.Location = new System.Drawing.Point(505, 430);
            this.combobox_progress.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_progress.Name = "combobox_progress";
            this.combobox_progress.Size = new System.Drawing.Size(78, 36);
            this.combobox_progress.StartIndex = 0;
            this.combobox_progress.TabIndex = 196;
            this.combobox_progress.SelectedIndexChanged += new System.EventHandler(this.combobox_progress_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(503, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 194;
            this.label5.Text = "Progress (%)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // circleProgressBar
            // 
            this.circleProgressBar.Controls.Add(this.progressValue);
            this.circleProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.circleProgressBar.FillThickness = 30;
            this.circleProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.circleProgressBar.ForeColor = System.Drawing.Color.White;
            this.circleProgressBar.Location = new System.Drawing.Point(614, 430);
            this.circleProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.circleProgressBar.Minimum = 0;
            this.circleProgressBar.Name = "circleProgressBar";
            this.circleProgressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circleProgressBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circleProgressBar.ProgressThickness = 35;
            this.circleProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleProgressBar.Size = new System.Drawing.Size(145, 145);
            this.circleProgressBar.TabIndex = 195;
            this.circleProgressBar.Text = "50";
            this.circleProgressBar.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.circleProgressBar.Value = 50;
            // 
            // progressValue
            // 
            this.progressValue.BackColor = System.Drawing.Color.Transparent;
            this.progressValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressValue.ForeColor = System.Drawing.Color.Red;
            this.progressValue.Location = new System.Drawing.Point(32, 53);
            this.progressValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressValue.Name = "progressValue";
            this.progressValue.Size = new System.Drawing.Size(84, 36);
            this.progressValue.TabIndex = 120;
            this.progressValue.Text = "50%";
            this.progressValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_assigneedPerson
            // 
            this.label_assigneedPerson.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_assigneedPerson.ForeColor = System.Drawing.Color.Black;
            this.label_assigneedPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_assigneedPerson.Location = new System.Drawing.Point(540, 69);
            this.label_assigneedPerson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_assigneedPerson.Name = "label_assigneedPerson";
            this.label_assigneedPerson.Size = new System.Drawing.Size(218, 23);
            this.label_assigneedPerson.TabIndex = 193;
            this.label_assigneedPerson.Text = "User";
            this.label_assigneedPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(502, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 192;
            this.label1.Text = "Assigned person";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picturebox_userAvatar
            // 
            this.picturebox_userAvatar.FillColor = System.Drawing.Color.Transparent;
            this.picturebox_userAvatar.ImageRotate = 0F;
            this.picturebox_userAvatar.Location = new System.Drawing.Point(501, 65);
            this.picturebox_userAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.picturebox_userAvatar.Name = "picturebox_userAvatar";
            this.picturebox_userAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picturebox_userAvatar.Size = new System.Drawing.Size(38, 37);
            this.picturebox_userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_userAvatar.TabIndex = 191;
            this.picturebox_userAvatar.TabStop = false;
            // 
            // gboxTask
            // 
            this.gboxTask.Controls.Add(this.label_assigneedTeam);
            this.gboxTask.Controls.Add(this.picturebox_teamAvatar);
            this.gboxTask.Controls.Add(this.label8);
            this.gboxTask.Controls.Add(this.combbox_Project);
            this.gboxTask.Controls.Add(this.label7);
            this.gboxTask.Controls.Add(this.combbox_Assignee);
            this.gboxTask.Controls.Add(this.label6);
            this.gboxTask.Controls.Add(this.label4);
            this.gboxTask.Controls.Add(this.textBox_Bonus);
            this.gboxTask.Controls.Add(this.btnCancel);
            this.gboxTask.Controls.Add(this.btnSave);
            this.gboxTask.Controls.Add(this.dateTime_deadline);
            this.gboxTask.Controls.Add(this.label2);
            this.gboxTask.Controls.Add(this.label_taskName);
            this.gboxTask.Controls.Add(this.label3);
            this.gboxTask.Controls.Add(this.txtbox_Desciption);
            this.gboxTask.Controls.Add(this.txtbox_Taskname);
            this.gboxTask.Controls.Add(this.combobox_progress);
            this.gboxTask.Controls.Add(this.label5);
            this.gboxTask.Controls.Add(this.circleProgressBar);
            this.gboxTask.Controls.Add(this.label_assigneedPerson);
            this.gboxTask.Controls.Add(this.label1);
            this.gboxTask.Controls.Add(this.picturebox_userAvatar);
            this.gboxTask.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTask.Location = new System.Drawing.Point(61, 12);
            this.gboxTask.Name = "gboxTask";
            this.gboxTask.Size = new System.Drawing.Size(825, 582);
            this.gboxTask.TabIndex = 214;
            this.gboxTask.TabStop = false;
            this.gboxTask.Text = "groupBox1";
            // 
            // FormViewOrUpdateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 601);
            this.Controls.Add(this.gboxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewOrUpdateTask";
            this.Text = "FormViewOrUpdateTask";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_teamAvatar)).EndInit();
            this.circleProgressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_userAvatar)).EndInit();
            this.gboxTask.ResumeLayout(false);
            this.gboxTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_assigneedTeam;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picturebox_teamAvatar;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox combbox_Project;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox combbox_Assignee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Bonus;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTime_deadline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_taskName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Desciption;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_Taskname;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_progress;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleProgressBar;
        private System.Windows.Forms.Label progressValue;
        private System.Windows.Forms.Label label_assigneedPerson;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picturebox_userAvatar;
        private System.Windows.Forms.GroupBox gboxTask;
    }
}