
namespace FullScreenAppDemo
{
    partial class FormAddRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRequest));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datetime_startDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.datetime_requestDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_content = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datetime_endDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.button_apply = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 337);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 31);
            this.label5.TabIndex = 199;
            this.label5.Text = "Thời gian nghỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 198;
            this.label1.Text = "Từ:";
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
            this.datetime_startDate.Location = new System.Drawing.Point(162, 392);
            this.datetime_startDate.Margin = new System.Windows.Forms.Padding(2);
            this.datetime_startDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_startDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_startDate.Name = "datetime_startDate";
            this.datetime_startDate.Size = new System.Drawing.Size(347, 37);
            this.datetime_startDate.TabIndex = 197;
            this.datetime_startDate.Value = new System.DateTime(2023, 4, 2, 18, 5, 35, 464);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 196;
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
            this.datetime_requestDate.Location = new System.Drawing.Point(162, 81);
            this.datetime_requestDate.Margin = new System.Windows.Forms.Padding(2);
            this.datetime_requestDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_requestDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_requestDate.Name = "datetime_requestDate";
            this.datetime_requestDate.Size = new System.Drawing.Size(350, 37);
            this.datetime_requestDate.TabIndex = 195;
            this.datetime_requestDate.Value = new System.DateTime(2023, 4, 2, 18, 5, 35, 464);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 34);
            this.label3.TabIndex = 194;
            this.label3.Text = "Tạo đơn xin phép";
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
            this.txtbox_content.Location = new System.Drawing.Point(163, 137);
            this.txtbox_content.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbox_content.Multiline = true;
            this.txtbox_content.Name = "txtbox_content";
            this.txtbox_content.PasswordChar = '\0';
            this.txtbox_content.PlaceholderText = "Nhập nội dung xin nghỉ ...";
            this.txtbox_content.SelectedText = "";
            this.txtbox_content.Size = new System.Drawing.Size(350, 186);
            this.txtbox_content.TabIndex = 193;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(325, 15);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(28, 34);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 200;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 454);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 203;
            this.label2.Text = "Đến:";
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
            this.datetime_endDate.Location = new System.Drawing.Point(165, 475);
            this.datetime_endDate.Margin = new System.Windows.Forms.Padding(2);
            this.datetime_endDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_endDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_endDate.Name = "datetime_endDate";
            this.datetime_endDate.Size = new System.Drawing.Size(347, 40);
            this.datetime_endDate.TabIndex = 202;
            this.datetime_endDate.Value = new System.DateTime(2023, 4, 26, 20, 37, 46, 0);
            // 
            // button_apply
            // 
            this.button_apply.BackColor = System.Drawing.Color.Transparent;
            this.button_apply.BorderRadius = 10;
            this.button_apply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_apply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_apply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_apply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_apply.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_apply.ForeColor = System.Drawing.Color.White;
            this.button_apply.Location = new System.Drawing.Point(164, 559);
            this.button_apply.Margin = new System.Windows.Forms.Padding(2);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(350, 41);
            this.button_apply.TabIndex = 201;
            this.button_apply.Text = "Apply";
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // FormAddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 645);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datetime_endDate);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datetime_startDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetime_requestDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_content);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddRequest";
            this.Text = "FormAddRequest";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_startDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_requestDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_content;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_endDate;
        private Guna.UI2.WinForms.Guna2Button button_apply;
    }
}