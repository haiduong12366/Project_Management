
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 38);
            this.label5.TabIndex = 199;
            this.label5.Text = "Thời gian nghỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 198;
            this.label1.Text = "Từ:";
            // 
            // datetime_startDate
            // 
            this.datetime_startDate.BackColor = System.Drawing.Color.Transparent;
            this.datetime_startDate.BorderRadius = 10;
            this.datetime_startDate.Checked = true;
            this.datetime_startDate.CheckedState.Parent = this.datetime_startDate;
            this.datetime_startDate.CustomFormat = "dd/MM/yyyy";
            this.datetime_startDate.FillColor = System.Drawing.Color.White;
            this.datetime_startDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_startDate.HoverState.Parent = this.datetime_startDate;
            this.datetime_startDate.Location = new System.Drawing.Point(216, 482);
            this.datetime_startDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_startDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_startDate.Name = "datetime_startDate";
            this.datetime_startDate.ShadowDecoration.Parent = this.datetime_startDate;
            this.datetime_startDate.Size = new System.Drawing.Size(463, 46);
            this.datetime_startDate.TabIndex = 197;
            this.datetime_startDate.Value = new System.DateTime(2023, 4, 2, 18, 5, 35, 464);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 196;
            this.label4.Text = "Ngày viết đơn";
            // 
            // datetime_requestDate
            // 
            this.datetime_requestDate.BackColor = System.Drawing.Color.Transparent;
            this.datetime_requestDate.BorderRadius = 10;
            this.datetime_requestDate.Checked = true;
            this.datetime_requestDate.CheckedState.Parent = this.datetime_requestDate;
            this.datetime_requestDate.CustomFormat = "dd/MM/yyyy";
            this.datetime_requestDate.FillColor = System.Drawing.Color.White;
            this.datetime_requestDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_requestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_requestDate.HoverState.Parent = this.datetime_requestDate;
            this.datetime_requestDate.Location = new System.Drawing.Point(216, 100);
            this.datetime_requestDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_requestDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_requestDate.Name = "datetime_requestDate";
            this.datetime_requestDate.ShadowDecoration.Parent = this.datetime_requestDate;
            this.datetime_requestDate.Size = new System.Drawing.Size(466, 46);
            this.datetime_requestDate.TabIndex = 195;
            this.datetime_requestDate.Value = new System.DateTime(2023, 4, 2, 18, 5, 35, 464);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 42);
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
            this.txtbox_content.DisabledState.Parent = this.txtbox_content;
            this.txtbox_content.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_content.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_content.FocusedState.Parent = this.txtbox_content;
            this.txtbox_content.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtbox_content.ForeColor = System.Drawing.Color.Black;
            this.txtbox_content.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_content.HoverState.Parent = this.txtbox_content;
            this.txtbox_content.Location = new System.Drawing.Point(217, 169);
            this.txtbox_content.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbox_content.Multiline = true;
            this.txtbox_content.Name = "txtbox_content";
            this.txtbox_content.PasswordChar = '\0';
            this.txtbox_content.PlaceholderText = "Nhập nội dung xin nghỉ ...";
            this.txtbox_content.SelectedText = "";
            this.txtbox_content.ShadowDecoration.Parent = this.txtbox_content;
            this.txtbox_content.Size = new System.Drawing.Size(466, 229);
            this.txtbox_content.TabIndex = 193;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(433, 18);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(38, 42);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 200;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormAdRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 541);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datetime_startDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetime_requestDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_content);
            this.Name = "FormAdRequest";
            this.Text = "FormAdRequest";
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
    }
}