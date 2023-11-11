namespace company_management.View.UC
{
    partial class UcLeaveRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcLeaveRequest));
            this.panelData = new Guna.UI2.WinForms.Guna2Panel();
            this.combobox_requestStatusFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.datagridview_leaveRequest = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label_cancelled = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label_pending = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label_rejected = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label_approved = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFields = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_allCount = new System.Windows.Forms.Label();
            this.label_basic = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonRemove = new Guna.UI2.WinForms.Guna2Button();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_leaveRequest)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelFields.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.BorderColor = System.Drawing.Color.White;
            this.panelData.BorderRadius = 20;
            this.panelData.BorderThickness = 1;
            this.panelData.Controls.Add(this.combobox_requestStatusFilter);
            this.panelData.Controls.Add(this.btnRefresh);
            this.panelData.Controls.Add(this.datagridview_leaveRequest);
            this.panelData.FillColor = System.Drawing.Color.White;
            this.panelData.Location = new System.Drawing.Point(13, 188);
            this.panelData.Margin = new System.Windows.Forms.Padding(2);
            this.panelData.Name = "panelData";
            this.panelData.ShadowDecoration.BorderRadius = 25;
            this.panelData.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelData.ShadowDecoration.Enabled = true;
            this.panelData.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.panelData.Size = new System.Drawing.Size(944, 437);
            this.panelData.TabIndex = 82;
            // 
            // combobox_requestStatusFilter
            // 
            this.combobox_requestStatusFilter.BackColor = System.Drawing.Color.Transparent;
            this.combobox_requestStatusFilter.BorderRadius = 10;
            this.combobox_requestStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_requestStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_requestStatusFilter.FillColor = System.Drawing.Color.WhiteSmoke;
            this.combobox_requestStatusFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_requestStatusFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_requestStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.combobox_requestStatusFilter.ForeColor = System.Drawing.Color.Black;
            this.combobox_requestStatusFilter.ItemHeight = 26;
            this.combobox_requestStatusFilter.Location = new System.Drawing.Point(12, 11);
            this.combobox_requestStatusFilter.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_requestStatusFilter.Name = "combobox_requestStatusFilter";
            this.combobox_requestStatusFilter.Size = new System.Drawing.Size(140, 32);
            this.combobox_requestStatusFilter.TabIndex = 105;
            this.combobox_requestStatusFilter.SelectedIndexChanged += new System.EventHandler(this.combobox_requestStatusFilter_SelectedIndexChanged);
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
            this.btnRefresh.Location = new System.Drawing.Point(837, 11);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 32);
            this.btnRefresh.TabIndex = 103;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // datagridview_leaveRequest
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridview_leaveRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_leaveRequest.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_leaveRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview_leaveRequest.ColumnHeadersHeight = 30;
            this.datagridview_leaveRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_leaveRequest.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview_leaveRequest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_leaveRequest.Location = new System.Drawing.Point(12, 58);
            this.datagridview_leaveRequest.Margin = new System.Windows.Forms.Padding(2);
            this.datagridview_leaveRequest.Name = "datagridview_leaveRequest";
            this.datagridview_leaveRequest.RowHeadersVisible = false;
            this.datagridview_leaveRequest.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datagridview_leaveRequest.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview_leaveRequest.RowTemplate.Height = 30;
            this.datagridview_leaveRequest.Size = new System.Drawing.Size(916, 366);
            this.datagridview_leaveRequest.TabIndex = 0;
            this.datagridview_leaveRequest.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_leaveRequest.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridview_leaveRequest.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridview_leaveRequest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridview_leaveRequest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridview_leaveRequest.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.datagridview_leaveRequest.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview_leaveRequest.ThemeStyle.HeaderStyle.Height = 30;
            this.datagridview_leaveRequest.ThemeStyle.ReadOnly = false;
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.Height = 30;
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_leaveRequest.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_leaveRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_leaveRequest_CellClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 94;
            this.label1.Text = "Leave Request Board";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderRadius = 20;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.label10);
            this.guna2Panel4.Controls.Add(this.label_cancelled);
            this.guna2Panel4.Controls.Add(this.label9);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(779, 12);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel4.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel4.ShadowDecoration.Enabled = true;
            this.guna2Panel4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel4.Size = new System.Drawing.Size(177, 89);
            this.guna2Panel4.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(102, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 28);
            this.label10.TabIndex = 100;
            // 
            // label_cancelled
            // 
            this.label_cancelled.BackColor = System.Drawing.Color.Transparent;
            this.label_cancelled.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cancelled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_cancelled.Location = new System.Drawing.Point(25, 14);
            this.label_cancelled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cancelled.Name = "label_cancelled";
            this.label_cancelled.Size = new System.Drawing.Size(141, 41);
            this.label_cancelled.TabIndex = 99;
            this.label_cancelled.Text = "4";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 26);
            this.label9.TabIndex = 98;
            this.label9.Text = "Cancelled";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.label8);
            this.guna2Panel3.Controls.Add(this.label_pending);
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(588, 12);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel3.Size = new System.Drawing.Size(181, 89);
            this.guna2Panel3.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(101, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 28);
            this.label8.TabIndex = 98;
            // 
            // label_pending
            // 
            this.label_pending.BackColor = System.Drawing.Color.Transparent;
            this.label_pending.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_pending.Location = new System.Drawing.Point(22, 14);
            this.label_pending.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pending.Name = "label_pending";
            this.label_pending.Size = new System.Drawing.Size(141, 41);
            this.label_pending.TabIndex = 97;
            this.label_pending.Text = "2";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 26);
            this.label7.TabIndex = 96;
            this.label7.Text = "Pending";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.label_rejected);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(397, 12);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel2.Size = new System.Drawing.Size(181, 89);
            this.guna2Panel2.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(88, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 28);
            this.label6.TabIndex = 98;
            // 
            // label_rejected
            // 
            this.label_rejected.BackColor = System.Drawing.Color.Transparent;
            this.label_rejected.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rejected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_rejected.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_rejected.Location = new System.Drawing.Point(22, 14);
            this.label_rejected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_rejected.Name = "label_rejected";
            this.label_rejected.Size = new System.Drawing.Size(141, 41);
            this.label_rejected.TabIndex = 95;
            this.label_rejected.Text = "2";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 94;
            this.label5.Text = "Refused";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label_approved);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(206, 12);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel1.Size = new System.Drawing.Size(181, 89);
            this.guna2Panel1.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(95, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 28);
            this.label4.TabIndex = 97;
            // 
            // label_approved
            // 
            this.label_approved.BackColor = System.Drawing.Color.Transparent;
            this.label_approved.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_approved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_approved.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_approved.Location = new System.Drawing.Point(22, 14);
            this.label_approved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_approved.Name = "label_approved";
            this.label_approved.Size = new System.Drawing.Size(141, 41);
            this.label_approved.TabIndex = 95;
            this.label_approved.Text = "6";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 94;
            this.label3.Text = "Approved";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFields
            // 
            this.panelFields.BackColor = System.Drawing.Color.Transparent;
            this.panelFields.BorderColor = System.Drawing.Color.White;
            this.panelFields.BorderRadius = 20;
            this.panelFields.BorderThickness = 1;
            this.panelFields.Controls.Add(this.label2);
            this.panelFields.Controls.Add(this.label_allCount);
            this.panelFields.Controls.Add(this.label_basic);
            this.panelFields.FillColor = System.Drawing.Color.White;
            this.panelFields.Location = new System.Drawing.Point(13, 12);
            this.panelFields.Margin = new System.Windows.Forms.Padding(2);
            this.panelFields.Name = "panelFields";
            this.panelFields.ShadowDecoration.BorderRadius = 25;
            this.panelFields.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelFields.ShadowDecoration.Enabled = true;
            this.panelFields.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.panelFields.Size = new System.Drawing.Size(181, 89);
            this.panelFields.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(126, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 28);
            this.label2.TabIndex = 96;
            // 
            // label_allCount
            // 
            this.label_allCount.BackColor = System.Drawing.Color.Transparent;
            this.label_allCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_allCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_allCount.Location = new System.Drawing.Point(19, 14);
            this.label_allCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_allCount.Name = "label_allCount";
            this.label_allCount.Size = new System.Drawing.Size(141, 41);
            this.label_allCount.TabIndex = 93;
            this.label_allCount.Text = "3";
            // 
            // label_basic
            // 
            this.label_basic.BackColor = System.Drawing.Color.Transparent;
            this.label_basic.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_basic.Location = new System.Drawing.Point(18, 53);
            this.label_basic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_basic.Name = "label_basic";
            this.label_basic.Size = new System.Drawing.Size(131, 26);
            this.label_basic.TabIndex = 92;
            this.label_basic.Text = "All Application";
            this.label_basic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(794, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 32);
            this.panel1.TabIndex = 113;
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoRoundedCorners = true;
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.BorderRadius = 15;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEdit.FillColor = System.Drawing.Color.Transparent;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonEdit.Image = global::Project_Management.Properties.Resources.edit;
            this.buttonEdit.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonEdit.Location = new System.Drawing.Point(48, 0);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(38, 32);
            this.buttonEdit.TabIndex = 94;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoRoundedCorners = true;
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BorderRadius = 15;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdd.FillColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Image = global::Project_Management.Properties.Resources.plus;
            this.buttonAdd.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonAdd.Location = new System.Drawing.Point(86, 0);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(38, 32);
            this.buttonAdd.TabIndex = 91;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoRoundedCorners = true;
            this.buttonRemove.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemove.BorderRadius = 15;
            this.buttonRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRemove.FillColor = System.Drawing.Color.Transparent;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemove.HoverState.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Image = global::Project_Management.Properties.Resources.trash;
            this.buttonRemove.ImageSize = new System.Drawing.Size(24, 24);
            this.buttonRemove.Location = new System.Drawing.Point(124, 0);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(38, 32);
            this.buttonRemove.TabIndex = 93;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // UcLeaveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelFields);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcLeaveRequest";
            this.Size = new System.Drawing.Size(969, 640);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_leaveRequest)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panelFields.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel1;

        private Guna.UI2.WinForms.Guna2Button btnRefresh;

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelData;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview_leaveRequest;
        private Guna.UI2.WinForms.Guna2Button buttonRemove;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label_cancelled;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label_pending;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label_rejected;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label_approved;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panelFields;
        private System.Windows.Forms.Label label_allCount;
        private System.Windows.Forms.Label label_basic;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_requestStatusFilter;
    }
}
