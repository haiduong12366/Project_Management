﻿namespace Project_Management.View
{
    partial class FormUpdateTeam
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
            this.btnUpdateAvatar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.cb_Leader = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_teamName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Desciption = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_teamName = new Guna.UI2.WinForms.Guna2TextBox();
            this.PbAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateAvatar
            // 
            this.btnUpdateAvatar.BorderRadius = 10;
            this.btnUpdateAvatar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAvatar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAvatar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateAvatar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAvatar.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAvatar.Location = new System.Drawing.Point(752, 385);
            this.btnUpdateAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAvatar.Name = "btnUpdateAvatar";
            this.btnUpdateAvatar.Size = new System.Drawing.Size(165, 37);
            this.btnUpdateAvatar.TabIndex = 144;
            this.btnUpdateAvatar.Text = "Team Image";
            this.btnUpdateAvatar.Click += new System.EventHandler(this.btnUpdateAvatar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(69, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 142;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AutoRoundedCorners = true;
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.BorderRadius = 24;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(73, 470);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(129, 50);
            this.btn_Cancel.TabIndex = 141;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AutoRoundedCorners = true;
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.BorderRadius = 24;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(255, 470);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(127, 50);
            this.btn_Save.TabIndex = 140;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_Leader
            // 
            this.cb_Leader.BackColor = System.Drawing.Color.Transparent;
            this.cb_Leader.BorderRadius = 5;
            this.cb_Leader.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Leader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Leader.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Leader.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Leader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Leader.ForeColor = System.Drawing.Color.Black;
            this.cb_Leader.ItemHeight = 30;
            this.cb_Leader.Location = new System.Drawing.Point(660, 62);
            this.cb_Leader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Leader.Name = "cb_Leader";
            this.cb_Leader.Size = new System.Drawing.Size(337, 36);
            this.cb_Leader.TabIndex = 139;
            // 
            // label_teamName
            // 
            this.label_teamName.AutoSize = true;
            this.label_teamName.BackColor = System.Drawing.Color.Transparent;
            this.label_teamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teamName.ForeColor = System.Drawing.Color.Black;
            this.label_teamName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_teamName.Location = new System.Drawing.Point(69, 34);
            this.label_teamName.Name = "label_teamName";
            this.label_teamName.Size = new System.Drawing.Size(112, 24);
            this.label_teamName.TabIndex = 135;
            this.label_teamName.Text = "Team name";
            this.label_teamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(656, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 138;
            this.label7.Text = "Leader";
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
            this.tb_Desciption.Location = new System.Drawing.Point(73, 145);
            this.tb_Desciption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Desciption.Multiline = true;
            this.tb_Desciption.Name = "tb_Desciption";
            this.tb_Desciption.PasswordChar = '\0';
            this.tb_Desciption.PlaceholderText = "";
            this.tb_Desciption.SelectedText = "";
            this.tb_Desciption.Size = new System.Drawing.Size(548, 266);
            this.tb_Desciption.TabIndex = 137;
            // 
            // tb_teamName
            // 
            this.tb_teamName.BorderColor = System.Drawing.Color.Black;
            this.tb_teamName.BorderRadius = 5;
            this.tb_teamName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_teamName.DefaultText = "";
            this.tb_teamName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_teamName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_teamName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_teamName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_teamName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_teamName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_teamName.ForeColor = System.Drawing.Color.Black;
            this.tb_teamName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_teamName.Location = new System.Drawing.Point(73, 62);
            this.tb_teamName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_teamName.Name = "tb_teamName";
            this.tb_teamName.PasswordChar = '\0';
            this.tb_teamName.PlaceholderText = "This is title";
            this.tb_teamName.SelectedText = "";
            this.tb_teamName.Size = new System.Drawing.Size(548, 32);
            this.tb_teamName.TabIndex = 136;
            // 
            // PbAvatar
            // 
            this.PbAvatar.FillColor = System.Drawing.Color.Transparent;
            this.PbAvatar.Image = global::Project_Management.Properties.Resources.team2;
            this.PbAvatar.ImageRotate = 0F;
            this.PbAvatar.Location = new System.Drawing.Point(728, 162);
            this.PbAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PbAvatar.Name = "PbAvatar";
            this.PbAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PbAvatar.Size = new System.Drawing.Size(213, 188);
            this.PbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAvatar.TabIndex = 143;
            this.PbAvatar.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUpdateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnUpdateAvatar);
            this.Controls.Add(this.PbAvatar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cb_Leader);
            this.Controls.Add(this.label_teamName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Desciption);
            this.Controls.Add(this.tb_teamName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUpdateTeam";
            this.Text = "FormUpdateTeam";
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUpdateAvatar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PbAvatar;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Leader;
        private System.Windows.Forms.Label label_teamName;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tb_Desciption;
        private Guna.UI2.WinForms.Guna2TextBox tb_teamName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}