namespace Project_Management.View.UC
{
    partial class UcSalary
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSalary));
            this.panelData = new Guna.UI2.WinForms.Guna2Panel();
            this.combobox_year = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combobox_month = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_showAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.datagridview_salary = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelFields = new Guna.UI2.WinForms.Guna2Panel();
            this.label_totalHours = new System.Windows.Forms.Label();
            this.label_basic = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_totalAllowance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_totalInsurance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_totalFinalSalary = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_totalTax = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_caculateSalary = new Guna.UI2.WinForms.Guna2Button();
            this.button_remove = new Guna.UI2.WinForms.Guna2Button();
            this.combobox_sortByDate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_showAllSalariesOf = new Guna.UI2.WinForms.Guna2Button();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_salary)).BeginInit();
            this.panelFields.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.BorderColor = System.Drawing.Color.White;
            this.panelData.BorderRadius = 20;
            this.panelData.BorderThickness = 1;
            this.panelData.Controls.Add(this.btn_showAllSalariesOf);
            this.panelData.Controls.Add(this.combobox_sortByDate);
            this.panelData.Controls.Add(this.combobox_year);
            this.panelData.Controls.Add(this.combobox_month);
            this.panelData.Controls.Add(this.btn_showAll);
            this.panelData.Controls.Add(this.btnRefresh);
            this.panelData.Controls.Add(this.datagridview_salary);
            this.panelData.FillColor = System.Drawing.Color.White;
            this.panelData.Location = new System.Drawing.Point(13, 206);
            this.panelData.Margin = new System.Windows.Forms.Padding(2);
            this.panelData.Name = "panelData";
            this.panelData.ShadowDecoration.BorderRadius = 25;
            this.panelData.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelData.ShadowDecoration.Enabled = true;
            this.panelData.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.panelData.Size = new System.Drawing.Size(944, 419);
            this.panelData.TabIndex = 87;
            // 
            // combobox_year
            // 
            this.combobox_year.BackColor = System.Drawing.Color.Transparent;
            this.combobox_year.BorderRadius = 5;
            this.combobox_year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_year.FillColor = System.Drawing.Color.WhiteSmoke;
            this.combobox_year.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_year.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.combobox_year.ForeColor = System.Drawing.Color.Black;
            this.combobox_year.ItemHeight = 26;
            this.combobox_year.Items.AddRange(new object[] {
            "Year",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.combobox_year.Location = new System.Drawing.Point(197, 15);
            this.combobox_year.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_year.Name = "combobox_year";
            this.combobox_year.Size = new System.Drawing.Size(93, 32);
            this.combobox_year.StartIndex = 0;
            this.combobox_year.TabIndex = 108;
            this.combobox_year.SelectedIndexChanged += new System.EventHandler(this.combobox_year_SelectedIndexChanged);
            // 
            // combobox_month
            // 
            this.combobox_month.BackColor = System.Drawing.Color.Transparent;
            this.combobox_month.BorderRadius = 5;
            this.combobox_month.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_month.FillColor = System.Drawing.Color.WhiteSmoke;
            this.combobox_month.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_month.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_month.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.combobox_month.ForeColor = System.Drawing.Color.Black;
            this.combobox_month.ItemHeight = 26;
            this.combobox_month.Items.AddRange(new object[] {
            "Month",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.combobox_month.Location = new System.Drawing.Point(91, 15);
            this.combobox_month.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_month.Name = "combobox_month";
            this.combobox_month.Size = new System.Drawing.Size(93, 32);
            this.combobox_month.StartIndex = 0;
            this.combobox_month.TabIndex = 106;
            this.combobox_month.SelectedIndexChanged += new System.EventHandler(this.combobox_month_SelectedIndexChanged);
            // 
            // btn_showAll
            // 
            this.btn_showAll.BorderRadius = 15;
            this.btn_showAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_showAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_showAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_showAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_showAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_showAll.ForeColor = System.Drawing.Color.Black;
            this.btn_showAll.Location = new System.Drawing.Point(12, 15);
            this.btn_showAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(72, 32);
            this.btn_showAll.TabIndex = 104;
            this.btn_showAll.Text = "All";
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 15;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(841, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 32);
            this.btnRefresh.TabIndex = 103;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // datagridview_salary
            // 
            this.datagridview_salary.AllowUserToOrderColumns = true;
            this.datagridview_salary.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.datagridview_salary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.datagridview_salary.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_salary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.datagridview_salary.ColumnHeadersHeight = 60;
            this.datagridview_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_salary.DefaultCellStyle = dataGridViewCellStyle23;
            this.datagridview_salary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_salary.Location = new System.Drawing.Point(12, 63);
            this.datagridview_salary.Margin = new System.Windows.Forms.Padding(2);
            this.datagridview_salary.Name = "datagridview_salary";
            this.datagridview_salary.RowHeadersVisible = false;
            this.datagridview_salary.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.datagridview_salary.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.datagridview_salary.RowTemplate.Height = 30;
            this.datagridview_salary.Size = new System.Drawing.Size(916, 341);
            this.datagridview_salary.TabIndex = 0;
            this.datagridview_salary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_salary.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridview_salary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridview_salary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridview_salary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridview_salary.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.datagridview_salary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_salary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridview_salary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_salary.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_salary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview_salary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview_salary.ThemeStyle.HeaderStyle.Height = 60;
            this.datagridview_salary.ThemeStyle.ReadOnly = false;
            this.datagridview_salary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_salary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_salary.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_salary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_salary.ThemeStyle.RowsStyle.Height = 30;
            this.datagridview_salary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_salary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_salary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_salary_CellClick);
            // 
            // panelFields
            // 
            this.panelFields.BackColor = System.Drawing.Color.Transparent;
            this.panelFields.BorderColor = System.Drawing.Color.White;
            this.panelFields.BorderRadius = 20;
            this.panelFields.BorderThickness = 1;
            this.panelFields.Controls.Add(this.label_totalHours);
            this.panelFields.Controls.Add(this.label_basic);
            this.panelFields.FillColor = System.Drawing.Color.White;
            this.panelFields.Location = new System.Drawing.Point(13, 15);
            this.panelFields.Margin = new System.Windows.Forms.Padding(2);
            this.panelFields.Name = "panelFields";
            this.panelFields.ShadowDecoration.BorderRadius = 25;
            this.panelFields.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelFields.ShadowDecoration.Enabled = true;
            this.panelFields.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.panelFields.Size = new System.Drawing.Size(181, 89);
            this.panelFields.TabIndex = 86;
            // 
            // label_totalHours
            // 
            this.label_totalHours.BackColor = System.Drawing.Color.Transparent;
            this.label_totalHours.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_totalHours.Location = new System.Drawing.Point(10, 14);
            this.label_totalHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalHours.Name = "label_totalHours";
            this.label_totalHours.Size = new System.Drawing.Size(168, 41);
            this.label_totalHours.TabIndex = 93;
            this.label_totalHours.Text = "500 h";
            this.label_totalHours.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_basic
            // 
            this.label_basic.BackColor = System.Drawing.Color.Transparent;
            this.label_basic.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_basic.Location = new System.Drawing.Point(14, 54);
            this.label_basic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_basic.Name = "label_basic";
            this.label_basic.Size = new System.Drawing.Size(137, 26);
            this.label_basic.TabIndex = 92;
            this.label_basic.Text = "Total working hours";
            this.label_basic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label_totalAllowance);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(206, 15);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel1.Size = new System.Drawing.Size(181, 89);
            this.guna2Panel1.TabIndex = 87;
            // 
            // label_totalAllowance
            // 
            this.label_totalAllowance.BackColor = System.Drawing.Color.Transparent;
            this.label_totalAllowance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalAllowance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_totalAllowance.Location = new System.Drawing.Point(10, 14);
            this.label_totalAllowance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalAllowance.Name = "label_totalAllowance";
            this.label_totalAllowance.Size = new System.Drawing.Size(169, 41);
            this.label_totalAllowance.TabIndex = 95;
            this.label_totalAllowance.Text = "$500";
            this.label_totalAllowance.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 94;
            this.label3.Text = "Total allowance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label_totalInsurance);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(397, 15);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel2.Size = new System.Drawing.Size(181, 89);
            this.guna2Panel2.TabIndex = 87;
            // 
            // label_totalInsurance
            // 
            this.label_totalInsurance.BackColor = System.Drawing.Color.Transparent;
            this.label_totalInsurance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalInsurance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_totalInsurance.Location = new System.Drawing.Point(9, 14);
            this.label_totalInsurance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalInsurance.Name = "label_totalInsurance";
            this.label_totalInsurance.Size = new System.Drawing.Size(170, 41);
            this.label_totalInsurance.TabIndex = 95;
            this.label_totalInsurance.Text = "$500";
            this.label_totalInsurance.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 26);
            this.label5.TabIndex = 94;
            this.label5.Text = "Total insurance amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderRadius = 20;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.label_totalFinalSalary);
            this.guna2Panel4.Controls.Add(this.label9);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(779, 15);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel4.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel4.ShadowDecoration.Enabled = true;
            this.guna2Panel4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel4.Size = new System.Drawing.Size(177, 89);
            this.guna2Panel4.TabIndex = 89;
            // 
            // label_totalFinalSalary
            // 
            this.label_totalFinalSalary.BackColor = System.Drawing.Color.Transparent;
            this.label_totalFinalSalary.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalFinalSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_totalFinalSalary.Location = new System.Drawing.Point(8, 14);
            this.label_totalFinalSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalFinalSalary.Name = "label_totalFinalSalary";
            this.label_totalFinalSalary.Size = new System.Drawing.Size(166, 41);
            this.label_totalFinalSalary.TabIndex = 99;
            this.label_totalFinalSalary.Text = "$10,000";
            this.label_totalFinalSalary.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 26);
            this.label9.TabIndex = 98;
            this.label9.Text = "Total salary";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 91;
            this.label1.Text = "Salary Board";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 26);
            this.label7.TabIndex = 96;
            this.label7.Text = "Total tax";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_totalTax
            // 
            this.label_totalTax.BackColor = System.Drawing.Color.Transparent;
            this.label_totalTax.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_totalTax.Location = new System.Drawing.Point(10, 14);
            this.label_totalTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalTax.Name = "label_totalTax";
            this.label_totalTax.Size = new System.Drawing.Size(169, 41);
            this.label_totalTax.TabIndex = 97;
            this.label_totalTax.Text = "$500";
            this.label_totalTax.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.label_totalTax);
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(588, 15);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel3.Size = new System.Drawing.Size(181, 89);
            this.guna2Panel3.TabIndex = 88;
            // 
            // btn_caculateSalary
            // 
            this.btn_caculateSalary.BackColor = System.Drawing.Color.Transparent;
            this.btn_caculateSalary.BorderRadius = 15;
            this.btn_caculateSalary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_caculateSalary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_caculateSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_caculateSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_caculateSalary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_caculateSalary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_caculateSalary.ForeColor = System.Drawing.Color.Black;
            this.btn_caculateSalary.Image = ((System.Drawing.Image)(resources.GetObject("btn_caculateSalary.Image")));
            this.btn_caculateSalary.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_caculateSalary.Location = new System.Drawing.Point(706, 153);
            this.btn_caculateSalary.Margin = new System.Windows.Forms.Padding(2);
            this.btn_caculateSalary.Name = "btn_caculateSalary";
            this.btn_caculateSalary.Size = new System.Drawing.Size(208, 41);
            this.btn_caculateSalary.TabIndex = 92;
            this.btn_caculateSalary.Text = "Calculation of wages";
            this.btn_caculateSalary.Click += new System.EventHandler(this.btn_caculateSalary_Click);
            // 
            // button_remove
            // 
            this.button_remove.AutoRoundedCorners = true;
            this.button_remove.BackColor = System.Drawing.Color.Transparent;
            this.button_remove.BorderRadius = 15;
            this.button_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_remove.FillColor = System.Drawing.Color.Transparent;
            this.button_remove.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_remove.ForeColor = System.Drawing.Color.White;
            this.button_remove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.button_remove.Image = ((System.Drawing.Image)(resources.GetObject("button_remove.Image")));
            this.button_remove.ImageSize = new System.Drawing.Size(24, 24);
            this.button_remove.Location = new System.Drawing.Point(919, 161);
            this.button_remove.Margin = new System.Windows.Forms.Padding(2);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(38, 32);
            this.button_remove.TabIndex = 104;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // combobox_sortByDate
            // 
            this.combobox_sortByDate.BackColor = System.Drawing.Color.Transparent;
            this.combobox_sortByDate.BorderRadius = 5;
            this.combobox_sortByDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_sortByDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_sortByDate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.combobox_sortByDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_sortByDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_sortByDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.combobox_sortByDate.ForeColor = System.Drawing.Color.Black;
            this.combobox_sortByDate.ItemHeight = 26;
            this.combobox_sortByDate.Items.AddRange(new object[] {
            "Latest",
            "Oldest"});
            this.combobox_sortByDate.Location = new System.Drawing.Point(304, 15);
            this.combobox_sortByDate.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_sortByDate.Name = "combobox_sortByDate";
            this.combobox_sortByDate.Size = new System.Drawing.Size(95, 32);
            this.combobox_sortByDate.StartIndex = 0;
            this.combobox_sortByDate.TabIndex = 110;
            this.combobox_sortByDate.SelectedIndexChanged += new System.EventHandler(this.combobox_sortByDate_SelectedIndexChanged);
            // 
            // btn_showAllSalariesOf
            // 
            this.btn_showAllSalariesOf.BorderRadius = 15;
            this.btn_showAllSalariesOf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_showAllSalariesOf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_showAllSalariesOf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_showAllSalariesOf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_showAllSalariesOf.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_showAllSalariesOf.ForeColor = System.Drawing.Color.Black;
            this.btn_showAllSalariesOf.Location = new System.Drawing.Point(693, 15);
            this.btn_showAllSalariesOf.Margin = new System.Windows.Forms.Padding(2);
            this.btn_showAllSalariesOf.Name = "btn_showAllSalariesOf";
            this.btn_showAllSalariesOf.Size = new System.Drawing.Size(135, 32);
            this.btn_showAllSalariesOf.TabIndex = 111;
            this.btn_showAllSalariesOf.Text = "All it\'s salaries";
            this.btn_showAllSalariesOf.Click += new System.EventHandler(this.btn_showAllSalariesOf_Click);
            // 
            // UcSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.btn_caculateSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelFields);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcSalary";
            this.Size = new System.Drawing.Size(969, 640);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_salary)).EndInit();
            this.panelFields.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Button button_remove;

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelData;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview_salary;
        private Guna.UI2.WinForms.Guna2Panel panelFields;
        private System.Windows.Forms.Label label_totalHours;
        private System.Windows.Forms.Label label_basic;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label_totalAllowance;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label_totalInsurance;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label_totalFinalSalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_totalTax;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btn_caculateSalary;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btn_showAll;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_year;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_month;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_sortByDate;
        private Guna.UI2.WinForms.Guna2Button btn_showAllSalariesOf;
    }
}
