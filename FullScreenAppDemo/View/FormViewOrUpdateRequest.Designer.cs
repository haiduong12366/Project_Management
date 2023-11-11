using System.ComponentModel;

namespace Project_Management.View
{
    partial class FormViewOrUpdateRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewOrUpdateRequest));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datetime_requestDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button_save = new Guna.UI2.WinForms.Guna2Button();
            this.txtbox_content = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_writer = new System.Windows.Forms.Label();
            this.picturebox_writer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label_approver = new System.Windows.Forms.Label();
            this.picturebox_approver = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combobox_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetime_startDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datetime_endDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_approved = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_numberDay = new System.Windows.Forms.Label();
            this.button_Cancel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_writer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_approver)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(430, 9);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(24, 24);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 203;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 197;
            this.label4.Text = "Ngày viết đơn";
            // 
            // datetime_requestDate
            // 
            this.datetime_requestDate.BackColor = System.Drawing.Color.Transparent;
            this.datetime_requestDate.BorderRadius = 10;
            this.datetime_requestDate.Checked = true;
            this.datetime_requestDate.CustomFormat = "dd/MM/yyyy";
            this.datetime_requestDate.FillColor = System.Drawing.Color.White;
            this.datetime_requestDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_requestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_requestDate.Location = new System.Drawing.Point(12, 229);
            this.datetime_requestDate.Margin = new System.Windows.Forms.Padding(2);
            this.datetime_requestDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_requestDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_requestDate.Name = "datetime_requestDate";
            this.datetime_requestDate.Size = new System.Drawing.Size(242, 37);
            this.datetime_requestDate.TabIndex = 196;
            this.datetime_requestDate.Value = new System.DateTime(2023, 4, 2, 18, 5, 35, 464);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 31);
            this.label3.TabIndex = 195;
            this.label3.Text = "Details of leave application";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Transparent;
            this.button_save.BorderRadius = 15;
            this.button_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(128, 609);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(350, 41);
            this.button_save.TabIndex = 194;
            this.button_save.Text = "Approve";
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // txtbox_content
            // 
            this.txtbox_content.BorderColor = System.Drawing.Color.Black;
            this.txtbox_content.BorderRadius = 5;
            this.txtbox_content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_content.DefaultText = "";
            this.txtbox_content.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_content.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_content.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_content.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_content.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_content.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtbox_content.ForeColor = System.Drawing.Color.Black;
            this.txtbox_content.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_content.Location = new System.Drawing.Point(13, 285);
            this.txtbox_content.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbox_content.Multiline = true;
            this.txtbox_content.Name = "txtbox_content";
            this.txtbox_content.PasswordChar = '\0';
            this.txtbox_content.PlaceholderText = "Nội dung xin nghỉ";
            this.txtbox_content.ReadOnly = true;
            this.txtbox_content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_content.SelectedText = "";
            this.txtbox_content.Size = new System.Drawing.Size(571, 99);
            this.txtbox_content.TabIndex = 193;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 204;
            this.label6.Text = "The applicant";
            // 
            // label_writer
            // 
            this.label_writer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_writer.ForeColor = System.Drawing.Color.Black;
            this.label_writer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_writer.Location = new System.Drawing.Point(53, 84);
            this.label_writer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_writer.Name = "label_writer";
            this.label_writer.Size = new System.Drawing.Size(200, 23);
            this.label_writer.TabIndex = 206;
            this.label_writer.Text = "Writer";
            this.label_writer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // picturebox_writer
            // 
            this.picturebox_writer.FillColor = System.Drawing.Color.Transparent;
            this.picturebox_writer.Image = global::Project_Management.Properties.Resources.user1;
            this.picturebox_writer.ImageRotate = 0F;
            this.picturebox_writer.Location = new System.Drawing.Point(13, 80);
            this.picturebox_writer.Margin = new System.Windows.Forms.Padding(2);
            this.picturebox_writer.Name = "picturebox_writer";
            this.picturebox_writer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picturebox_writer.Size = new System.Drawing.Size(38, 37);
            this.picturebox_writer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_writer.TabIndex = 205;
            this.picturebox_writer.TabStop = false;
            // 
            // label_approver
            // 
            this.label_approver.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_approver.ForeColor = System.Drawing.Color.Black;
            this.label_approver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_approver.Location = new System.Drawing.Point(53, 154);
            this.label_approver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_approver.Name = "label_approver";
            this.label_approver.Size = new System.Drawing.Size(232, 23);
            this.label_approver.TabIndex = 209;
            this.label_approver.Text = "Waiting for someone to approve the application";
            this.label_approver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picturebox_approver
            // 
            this.picturebox_approver.FillColor = System.Drawing.Color.Transparent;
            this.picturebox_approver.Image = global::Project_Management.Properties.Resources.user1;
            this.picturebox_approver.ImageRotate = 0F;
            this.picturebox_approver.Location = new System.Drawing.Point(13, 150);
            this.picturebox_approver.Margin = new System.Windows.Forms.Padding(2);
            this.picturebox_approver.Name = "picturebox_approver";
            this.picturebox_approver.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picturebox_approver.Size = new System.Drawing.Size(38, 37);
            this.picturebox_approver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_approver.TabIndex = 208;
            this.picturebox_approver.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 207;
            this.label8.Text = "Application reviewer";
            // 
            // combobox_status
            // 
            this.combobox_status.BackColor = System.Drawing.Color.Transparent;
            this.combobox_status.BorderRadius = 10;
            this.combobox_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox_status.ForeColor = System.Drawing.Color.Black;
            this.combobox_status.ItemHeight = 30;
            this.combobox_status.Location = new System.Drawing.Point(329, 528);
            this.combobox_status.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_status.Name = "combobox_status";
            this.combobox_status.Size = new System.Drawing.Size(255, 36);
            this.combobox_status.TabIndex = 216;
            this.combobox_status.SelectedIndexChanged += new System.EventHandler(this.combobox_status_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 399);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 215;
            this.label5.Text = "Total Time Off:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 499);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 214;
            this.label2.Text = "To:";
            // 
            // datetime_startDate
            // 
            this.datetime_startDate.BackColor = System.Drawing.Color.Transparent;
            this.datetime_startDate.BorderRadius = 10;
            this.datetime_startDate.Checked = true;
            this.datetime_startDate.CustomFormat = "dd/MM/yyyy";
            this.datetime_startDate.FillColor = System.Drawing.Color.White;
            this.datetime_startDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_startDate.Location = new System.Drawing.Point(13, 451);
            this.datetime_startDate.Margin = new System.Windows.Forms.Padding(2);
            this.datetime_startDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_startDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_startDate.Name = "datetime_startDate";
            this.datetime_startDate.Size = new System.Drawing.Size(241, 37);
            this.datetime_startDate.TabIndex = 212;
            this.datetime_startDate.Value = new System.DateTime(2023, 4, 2, 18, 5, 35, 464);
            this.datetime_startDate.ValueChanged += new System.EventHandler(this.datetime_startDate_ValueChanged);
            // 
            // datetime_endDate
            // 
            this.datetime_endDate.BackColor = System.Drawing.Color.Transparent;
            this.datetime_endDate.BorderRadius = 10;
            this.datetime_endDate.Checked = true;
            this.datetime_endDate.CustomFormat = "dd/MM/yyyy";
            this.datetime_endDate.FillColor = System.Drawing.Color.White;
            this.datetime_endDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_endDate.Location = new System.Drawing.Point(13, 520);
            this.datetime_endDate.Margin = new System.Windows.Forms.Padding(2);
            this.datetime_endDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_endDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_endDate.Name = "datetime_endDate";
            this.datetime_endDate.Size = new System.Drawing.Size(241, 37);
            this.datetime_endDate.TabIndex = 211;
            this.datetime_endDate.Value = new System.DateTime(2023, 4, 26, 20, 37, 46, 0);
            this.datetime_endDate.ValueChanged += new System.EventHandler(this.datetime_endDate_ValueChanged);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(329, 451);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 19);
            this.label.TabIndex = 217;
            this.label.Text = "Status :";
            // 
            // label_status
            // 
            this.label_status.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(403, 451);
            this.label_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(181, 19);
            this.label_status.TabIndex = 218;
            this.label_status.Text = "Status";
            // 
            // label_approved
            // 
            this.label_approved.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_approved.Location = new System.Drawing.Point(329, 505);
            this.label_approved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_approved.Name = "label_approved";
            this.label_approved.Size = new System.Drawing.Size(125, 19);
            this.label_approved.TabIndex = 220;
            this.label_approved.Text = "Approval status:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 221;
            this.label1.Text = "From:";
            // 
            // label_numberDay
            // 
            this.label_numberDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_numberDay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberDay.Location = new System.Drawing.Point(188, 399);
            this.label_numberDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numberDay.Name = "label_numberDay";
            this.label_numberDay.Size = new System.Drawing.Size(81, 31);
            this.label_numberDay.TabIndex = 222;
            this.label_numberDay.Text = "10 days";
            this.label_numberDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.button_Cancel.BorderRadius = 10;
            this.button_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Cancel.FillColor = System.Drawing.Color.Gainsboro;
            this.button_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.HoverState.FillColor = System.Drawing.Color.Red;
            this.button_Cancel.Location = new System.Drawing.Point(499, 10);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(85, 25);
            this.button_Cancel.TabIndex = 219;
            this.button_Cancel.Text = "Cancell";
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // FormViewOrUpdateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(595, 659);
            this.Controls.Add(this.label_numberDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_approved);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label);
            this.Controls.Add(this.combobox_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datetime_startDate);
            this.Controls.Add(this.datetime_endDate);
            this.Controls.Add(this.label_approver);
            this.Controls.Add(this.picturebox_approver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_writer);
            this.Controls.Add(this.picturebox_writer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetime_requestDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.txtbox_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormViewOrUpdateRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_writer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_approver)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label_numberDay;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label_approved;

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_status;

        private Guna.UI2.WinForms.Guna2ComboBox combobox_status;

        private System.Windows.Forms.Label label_approver;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picturebox_approver;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label_writer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picturebox_writer;

        private System.Windows.Forms.Label label6;

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_startDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_endDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_requestDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button button_save;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_content;

        #endregion

        private Guna.UI2.WinForms.Guna2Button button_Cancel;
    }
}