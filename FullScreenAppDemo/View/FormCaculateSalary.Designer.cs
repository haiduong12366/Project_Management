namespace Project_Management.View
{
    partial class FormCaculateSalary
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_calculateByMonth = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimePicker_calculateByMonth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Silver;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(843, 584);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(94, 34);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_calculateByMonth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DateTimePicker_calculateByMonth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(288, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 446);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate salary by month";
            // 
            // Button_calculateByMonth
            // 
            this.Button_calculateByMonth.BorderRadius = 5;
            this.Button_calculateByMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_calculateByMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_calculateByMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_calculateByMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_calculateByMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_calculateByMonth.ForeColor = System.Drawing.Color.Black;
            this.Button_calculateByMonth.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_calculateByMonth.Location = new System.Drawing.Point(28, 388);
            this.Button_calculateByMonth.Margin = new System.Windows.Forms.Padding(2);
            this.Button_calculateByMonth.Name = "Button_calculateByMonth";
            this.Button_calculateByMonth.Size = new System.Drawing.Size(336, 40);
            this.Button_calculateByMonth.TabIndex = 17;
            this.Button_calculateByMonth.Text = "Caculate ";
            this.Button_calculateByMonth.Click += new System.EventHandler(this.Button_calculateByMonth_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select month";
            // 
            // DateTimePicker_calculateByMonth
            // 
            this.DateTimePicker_calculateByMonth.BorderRadius = 5;
            this.DateTimePicker_calculateByMonth.Checked = true;
            this.DateTimePicker_calculateByMonth.CustomFormat = "MM/yyyy";
            this.DateTimePicker_calculateByMonth.FillColor = System.Drawing.Color.White;
            this.DateTimePicker_calculateByMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DateTimePicker_calculateByMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_calculateByMonth.Location = new System.Drawing.Point(28, 124);
            this.DateTimePicker_calculateByMonth.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePicker_calculateByMonth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_calculateByMonth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_calculateByMonth.Name = "DateTimePicker_calculateByMonth";
            this.DateTimePicker_calculateByMonth.Size = new System.Drawing.Size(336, 42);
            this.DateTimePicker_calculateByMonth.TabIndex = 15;
            this.DateTimePicker_calculateByMonth.Value = new System.DateTime(2023, 4, 29, 1, 47, 32, 531);
            // 
            // FormCaculateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaculateSalary";
            this.Text = "FormCaculateSalary";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button Button_calculateByMonth;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker_calculateByMonth;
    }
}