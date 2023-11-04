
namespace FullScreenAppDemo
{
    partial class FormCalculateSalary
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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage_calculateByMonth = new System.Windows.Forms.TabPage();
            this.Button_calculateByMonth = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimePicker_calculateByMonth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimePicker_endDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.button_calculateByDay = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePicker_fromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage_calculateByMonth.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage_calculateByMonth);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(800, 450);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage_calculateByMonth
            // 
            this.tabPage_calculateByMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage_calculateByMonth.Controls.Add(this.Button_calculateByMonth);
            this.tabPage_calculateByMonth.Controls.Add(this.label4);
            this.tabPage_calculateByMonth.Controls.Add(this.DateTimePicker_calculateByMonth);
            this.tabPage_calculateByMonth.Location = new System.Drawing.Point(4, 44);
            this.tabPage_calculateByMonth.Name = "tabPage_calculateByMonth";
            this.tabPage_calculateByMonth.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_calculateByMonth.Size = new System.Drawing.Size(792, 402);
            this.tabPage_calculateByMonth.TabIndex = 0;
            this.tabPage_calculateByMonth.Text = "Tính theo tháng";
            this.tabPage_calculateByMonth.UseVisualStyleBackColor = true;
            // 
            // Button_calculateByMonth
            // 
            this.Button_calculateByMonth.BorderRadius = 10;
            this.Button_calculateByMonth.CheckedState.Parent = this.Button_calculateByMonth;
            this.Button_calculateByMonth.CustomImages.Parent = this.Button_calculateByMonth;
            this.Button_calculateByMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_calculateByMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_calculateByMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_calculateByMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_calculateByMonth.DisabledState.Parent = this.Button_calculateByMonth;
            this.Button_calculateByMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_calculateByMonth.ForeColor = System.Drawing.Color.Black;
            this.Button_calculateByMonth.HoverState.Parent = this.Button_calculateByMonth;
            this.Button_calculateByMonth.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_calculateByMonth.Location = new System.Drawing.Point(66, 363);
            this.Button_calculateByMonth.Name = "Button_calculateByMonth";
            this.Button_calculateByMonth.ShadowDecoration.Parent = this.Button_calculateByMonth;
            this.Button_calculateByMonth.Size = new System.Drawing.Size(389, 58);
            this.Button_calculateByMonth.TabIndex = 10;
            this.Button_calculateByMonth.Text = "Thực hiện tính lương";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chọn tháng";
            // 
            // DateTimePicker_calculateByMonth
            // 
            this.DateTimePicker_calculateByMonth.BorderRadius = 10;
            this.DateTimePicker_calculateByMonth.Checked = true;
            this.DateTimePicker_calculateByMonth.CheckedState.Parent = this.DateTimePicker_calculateByMonth;
            this.DateTimePicker_calculateByMonth.CustomFormat = "MM/yyyy";
            this.DateTimePicker_calculateByMonth.FillColor = System.Drawing.Color.White;
            this.DateTimePicker_calculateByMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DateTimePicker_calculateByMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_calculateByMonth.HoverState.Parent = this.DateTimePicker_calculateByMonth;
            this.DateTimePicker_calculateByMonth.Location = new System.Drawing.Point(66, 98);
            this.DateTimePicker_calculateByMonth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_calculateByMonth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_calculateByMonth.Name = "DateTimePicker_calculateByMonth";
            this.DateTimePicker_calculateByMonth.ShadowDecoration.Parent = this.DateTimePicker_calculateByMonth;
            this.DateTimePicker_calculateByMonth.Size = new System.Drawing.Size(389, 52);
            this.DateTimePicker_calculateByMonth.TabIndex = 8;
            this.DateTimePicker_calculateByMonth.Value = new System.DateTime(2023, 4, 29, 1, 47, 32, 531);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.DateTimePicker_endDate);
            this.tabPage2.Controls.Add(this.button_calculateByDay);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DateTimePicker_fromDate);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(518, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tính theo ngày";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày kết thúc";
            // 
            // DateTimePicker_endDate
            // 
            this.DateTimePicker_endDate.BorderRadius = 10;
            this.DateTimePicker_endDate.Checked = true;
            this.DateTimePicker_endDate.CheckedState.Parent = this.DateTimePicker_endDate;
            this.DateTimePicker_endDate.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker_endDate.FillColor = System.Drawing.Color.White;
            this.DateTimePicker_endDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_endDate.HoverState.Parent = this.DateTimePicker_endDate;
            this.DateTimePicker_endDate.Location = new System.Drawing.Point(67, 203);
            this.DateTimePicker_endDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_endDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_endDate.Name = "DateTimePicker_endDate";
            this.DateTimePicker_endDate.ShadowDecoration.Parent = this.DateTimePicker_endDate;
            this.DateTimePicker_endDate.Size = new System.Drawing.Size(389, 52);
            this.DateTimePicker_endDate.TabIndex = 6;
            this.DateTimePicker_endDate.Value = new System.DateTime(2023, 4, 29, 1, 47, 32, 531);
            // 
            // button_calculateByDay
            // 
            this.button_calculateByDay.BorderRadius = 10;
            this.button_calculateByDay.CheckedState.Parent = this.button_calculateByDay;
            this.button_calculateByDay.CustomImages.Parent = this.button_calculateByDay;
            this.button_calculateByDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_calculateByDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_calculateByDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_calculateByDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_calculateByDay.DisabledState.Parent = this.button_calculateByDay;
            this.button_calculateByDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calculateByDay.ForeColor = System.Drawing.Color.Black;
            this.button_calculateByDay.HoverState.Parent = this.button_calculateByDay;
            this.button_calculateByDay.ImageSize = new System.Drawing.Size(30, 30);
            this.button_calculateByDay.Location = new System.Drawing.Point(67, 373);
            this.button_calculateByDay.Name = "button_calculateByDay";
            this.button_calculateByDay.ShadowDecoration.Parent = this.button_calculateByDay;
            this.button_calculateByDay.Size = new System.Drawing.Size(389, 58);
            this.button_calculateByDay.TabIndex = 5;
            this.button_calculateByDay.Text = "Thực hiện tính lương";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // DateTimePicker_fromDate
            // 
            this.DateTimePicker_fromDate.BorderRadius = 10;
            this.DateTimePicker_fromDate.Checked = true;
            this.DateTimePicker_fromDate.CheckedState.Parent = this.DateTimePicker_fromDate;
            this.DateTimePicker_fromDate.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker_fromDate.FillColor = System.Drawing.Color.White;
            this.DateTimePicker_fromDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DateTimePicker_fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_fromDate.HoverState.Parent = this.DateTimePicker_fromDate;
            this.DateTimePicker_fromDate.Location = new System.Drawing.Point(67, 87);
            this.DateTimePicker_fromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_fromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_fromDate.Name = "DateTimePicker_fromDate";
            this.DateTimePicker_fromDate.ShadowDecoration.Parent = this.DateTimePicker_fromDate;
            this.DateTimePicker_fromDate.Size = new System.Drawing.Size(389, 52);
            this.DateTimePicker_fromDate.TabIndex = 3;
            this.DateTimePicker_fromDate.Value = new System.DateTime(2023, 4, 29, 1, 47, 32, 531);
            // 
            // FormCalculateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "FormCalculateSalary";
            this.Text = "FormCalculateSalary";
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage_calculateByMonth.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage_calculateByMonth;
        private Guna.UI2.WinForms.Guna2Button Button_calculateByMonth;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker_calculateByMonth;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker_endDate;
        private Guna.UI2.WinForms.Guna2Button button_calculateByDay;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker_fromDate;
    }
}