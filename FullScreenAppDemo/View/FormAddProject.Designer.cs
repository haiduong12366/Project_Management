
namespace FullScreenAppDemo
{
    partial class FormAddProject
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
            this.dt_endDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_startDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Bonus = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.cb_AssigneeTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_taskName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Desciption = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_projectName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // dt_endDate
            // 
            this.dt_endDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_endDate.Location = new System.Drawing.Point(474, 179);
            this.dt_endDate.Margin = new System.Windows.Forms.Padding(2);
            this.dt_endDate.Name = "dt_endDate";
            this.dt_endDate.Size = new System.Drawing.Size(254, 26);
            this.dt_endDate.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(471, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 123;
            this.label4.Text = "End date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dt_startDate
            // 
            this.dt_startDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_startDate.Location = new System.Drawing.Point(474, 109);
            this.dt_startDate.Margin = new System.Windows.Forms.Padding(2);
            this.dt_startDate.Name = "dt_startDate";
            this.dt_startDate.Size = new System.Drawing.Size(254, 26);
            this.dt_startDate.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(471, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 121;
            this.label3.Text = "Start date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(471, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 119;
            this.label1.Text = "Bonus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Bonus
            // 
            this.tb_Bonus.BorderColor = System.Drawing.Color.Black;
            this.tb_Bonus.BorderRadius = 5;
            this.tb_Bonus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Bonus.DefaultText = "";
            this.tb_Bonus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Bonus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Bonus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Bonus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Bonus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Bonus.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_Bonus.ForeColor = System.Drawing.Color.Black;
            this.tb_Bonus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Bonus.Location = new System.Drawing.Point(474, 249);
            this.tb_Bonus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Bonus.Name = "tb_Bonus";
            this.tb_Bonus.PasswordChar = '\0';
            this.tb_Bonus.PlaceholderText = "Exp: 200 $";
            this.tb_Bonus.SelectedText = "";
            this.tb_Bonus.Size = new System.Drawing.Size(255, 26);
            this.tb_Bonus.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 118;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AutoRoundedCorners = true;
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.BorderRadius = 19;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(34, 373);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(97, 41);
            this.btn_Cancel.TabIndex = 117;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AutoRoundedCorners = true;
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.BorderRadius = 19;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(170, 373);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(95, 41);
            this.btn_Save.TabIndex = 116;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_AssigneeTeam
            // 
            this.cb_AssigneeTeam.BackColor = System.Drawing.Color.Transparent;
            this.cb_AssigneeTeam.BorderRadius = 5;
            this.cb_AssigneeTeam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_AssigneeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AssigneeTeam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_AssigneeTeam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_AssigneeTeam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AssigneeTeam.ForeColor = System.Drawing.Color.Black;
            this.cb_AssigneeTeam.ItemHeight = 30;
            this.cb_AssigneeTeam.Location = new System.Drawing.Point(474, 41);
            this.cb_AssigneeTeam.Margin = new System.Windows.Forms.Padding(2);
            this.cb_AssigneeTeam.Name = "cb_AssigneeTeam";
            this.cb_AssigneeTeam.Size = new System.Drawing.Size(254, 36);
            this.cb_AssigneeTeam.TabIndex = 115;
            // 
            // label_taskName
            // 
            this.label_taskName.AutoSize = true;
            this.label_taskName.BackColor = System.Drawing.Color.Transparent;
            this.label_taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taskName.ForeColor = System.Drawing.Color.Black;
            this.label_taskName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_taskName.Location = new System.Drawing.Point(31, 19);
            this.label_taskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_taskName.Name = "label_taskName";
            this.label_taskName.Size = new System.Drawing.Size(96, 18);
            this.label_taskName.TabIndex = 111;
            this.label_taskName.Text = "Project name";
            this.label_taskName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(471, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 114;
            this.label7.Text = "Assignee to";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Desciption
            // 
            this.tb_Desciption.BorderColor = System.Drawing.Color.Black;
            this.tb_Desciption.BorderRadius = 5;
            this.tb_Desciption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Desciption.DefaultText = "";
            this.tb_Desciption.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Desciption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Desciption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Desciption.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Desciption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Desciption.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_Desciption.ForeColor = System.Drawing.Color.Black;
            this.tb_Desciption.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Desciption.Location = new System.Drawing.Point(34, 109);
            this.tb_Desciption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Desciption.Multiline = true;
            this.tb_Desciption.Name = "tb_Desciption";
            this.tb_Desciption.PasswordChar = '\0';
            this.tb_Desciption.PlaceholderText = "";
            this.tb_Desciption.SelectedText = "";
            this.tb_Desciption.Size = new System.Drawing.Size(411, 216);
            this.tb_Desciption.TabIndex = 113;
            // 
            // tb_projectName
            // 
            this.tb_projectName.BorderColor = System.Drawing.Color.Black;
            this.tb_projectName.BorderRadius = 5;
            this.tb_projectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_projectName.DefaultText = "";
            this.tb_projectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_projectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_projectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_projectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_projectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_projectName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_projectName.ForeColor = System.Drawing.Color.Black;
            this.tb_projectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_projectName.Location = new System.Drawing.Point(34, 41);
            this.tb_projectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_projectName.Name = "tb_projectName";
            this.tb_projectName.PasswordChar = '\0';
            this.tb_projectName.PlaceholderText = "This is title";
            this.tb_projectName.SelectedText = "";
            this.tb_projectName.Size = new System.Drawing.Size(411, 26);
            this.tb_projectName.TabIndex = 112;
            // 
            // FormAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 477);
            this.Controls.Add(this.dt_endDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_startDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Bonus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cb_AssigneeTeam);
            this.Controls.Add(this.label_taskName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Desciption);
            this.Controls.Add(this.tb_projectName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddProject";
            this.Text = "FormAddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_endDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_startDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tb_Bonus;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Guna.UI2.WinForms.Guna2ComboBox cb_AssigneeTeam;
        private System.Windows.Forms.Label label_taskName;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tb_Desciption;
        private Guna.UI2.WinForms.Guna2TextBox tb_projectName;
    }
}