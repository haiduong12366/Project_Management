﻿namespace Project_Management.View.UC
{
    partial class UcTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTask));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelData = new Guna.UI2.WinForms.Guna2Panel();
            this.combobox_taskProgressFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.combobox_taskStatusFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridView_Task = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelFields = new Guna.UI2.WinForms.Guna2Panel();
            this.chart_taskProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label_todoTask = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_inprogressTask = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label_doneTask = new System.Windows.Forms.Label();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Task)).BeginInit();
            this.panelFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_taskProgress)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2GradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.BorderColor = System.Drawing.Color.White;
            this.panelData.BorderRadius = 20;
            this.panelData.BorderThickness = 1;
            this.panelData.Controls.Add(this.combobox_taskProgressFilter);
            this.panelData.Controls.Add(this.btnRefresh);
            this.panelData.Controls.Add(this.combobox_taskStatusFilter);
            this.panelData.Controls.Add(this.dataGridView_Task);
            this.panelData.FillColor = System.Drawing.Color.White;
            this.panelData.Location = new System.Drawing.Point(13, 255);
            this.panelData.Margin = new System.Windows.Forms.Padding(2);
            this.panelData.Name = "panelData";
            this.panelData.ShadowDecoration.BorderRadius = 25;
            this.panelData.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelData.ShadowDecoration.Enabled = true;
            this.panelData.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.panelData.Size = new System.Drawing.Size(944, 370);
            this.panelData.TabIndex = 96;
            // 
            // combobox_taskProgressFilter
            // 
            this.combobox_taskProgressFilter.BackColor = System.Drawing.Color.Transparent;
            this.combobox_taskProgressFilter.BorderRadius = 5;
            this.combobox_taskProgressFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_taskProgressFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_taskProgressFilter.FillColor = System.Drawing.Color.WhiteSmoke;
            this.combobox_taskProgressFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_taskProgressFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_taskProgressFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.combobox_taskProgressFilter.ForeColor = System.Drawing.Color.Black;
            this.combobox_taskProgressFilter.ItemHeight = 26;
            this.combobox_taskProgressFilter.Items.AddRange(new object[] {
            "Lọc theo tiến độ",
            "Tất cả",
            "Cần làm ",
            "Đang làm",
            "Đã hoàn thành"});
            this.combobox_taskProgressFilter.Location = new System.Drawing.Point(170, 16);
            this.combobox_taskProgressFilter.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_taskProgressFilter.Name = "combobox_taskProgressFilter";
            this.combobox_taskProgressFilter.Size = new System.Drawing.Size(172, 32);
            this.combobox_taskProgressFilter.StartIndex = 0;
            this.combobox_taskProgressFilter.TabIndex = 103;
            this.combobox_taskProgressFilter.SelectedIndexChanged += new System.EventHandler(this.combobox_taskProgressFilter_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(837, 13);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 32);
            this.btnRefresh.TabIndex = 102;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // combobox_taskStatusFilter
            // 
            this.combobox_taskStatusFilter.BackColor = System.Drawing.Color.Transparent;
            this.combobox_taskStatusFilter.BorderRadius = 5;
            this.combobox_taskStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_taskStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_taskStatusFilter.FillColor = System.Drawing.Color.WhiteSmoke;
            this.combobox_taskStatusFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_taskStatusFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox_taskStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.combobox_taskStatusFilter.ForeColor = System.Drawing.Color.Black;
            this.combobox_taskStatusFilter.ItemHeight = 26;
            this.combobox_taskStatusFilter.Items.AddRange(new object[] {
            "Tất cả",
            "Đã tạo\t",
            "Được giao"});
            this.combobox_taskStatusFilter.Location = new System.Drawing.Point(12, 16);
            this.combobox_taskStatusFilter.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_taskStatusFilter.Name = "combobox_taskStatusFilter";
            this.combobox_taskStatusFilter.Size = new System.Drawing.Size(124, 32);
            this.combobox_taskStatusFilter.StartIndex = 0;
            this.combobox_taskStatusFilter.TabIndex = 71;
            this.combobox_taskStatusFilter.SelectedIndexChanged += new System.EventHandler(this.combobox_taskStatusFilter_SelectedIndexChanged);
            // 
            // dataGridView_Task
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_Task.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Task.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Task.ColumnHeadersHeight = 30;
            this.dataGridView_Task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Task.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Task.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_Task.Location = new System.Drawing.Point(12, 62);
            this.dataGridView_Task.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Task.Name = "dataGridView_Task";
            this.dataGridView_Task.RowHeadersVisible = false;
            this.dataGridView_Task.RowHeadersWidth = 20;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_Task.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Task.RowTemplate.Height = 30;
            this.dataGridView_Task.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Task.Size = new System.Drawing.Size(916, 295);
            this.dataGridView_Task.TabIndex = 0;
            this.dataGridView_Task.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Task.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Task.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Task.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Task.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Task.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Task.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_Task.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Task.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Task.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Task.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Task.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Task.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridView_Task.ThemeStyle.ReadOnly = false;
            this.dataGridView_Task.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Task.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Task.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Task.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Task.ThemeStyle.RowsStyle.Height = 30;
            this.dataGridView_Task.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Task.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Task.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Task_CellClick);
            // 
            // panelFields
            // 
            this.panelFields.BackColor = System.Drawing.Color.Transparent;
            this.panelFields.BorderColor = System.Drawing.Color.White;
            this.panelFields.BorderRadius = 20;
            this.panelFields.BorderThickness = 1;
            this.panelFields.Controls.Add(this.chart_taskProgress);
            this.panelFields.FillColor = System.Drawing.Color.White;
            this.panelFields.Location = new System.Drawing.Point(13, 15);
            this.panelFields.Margin = new System.Windows.Forms.Padding(2);
            this.panelFields.Name = "panelFields";
            this.panelFields.ShadowDecoration.BorderRadius = 25;
            this.panelFields.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelFields.ShadowDecoration.Enabled = true;
            this.panelFields.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.panelFields.Size = new System.Drawing.Size(210, 157);
            this.panelFields.TabIndex = 95;
            // 
            // chart_taskProgress
            // 
            chartArea1.Name = "ChartArea";
            this.chart_taskProgress.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend_progress";
            this.chart_taskProgress.Legends.Add(legend1);
            this.chart_taskProgress.Location = new System.Drawing.Point(12, 2);
            this.chart_taskProgress.Margin = new System.Windows.Forms.Padding(2);
            this.chart_taskProgress.Name = "chart_taskProgress";
            this.chart_taskProgress.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend_progress";
            series1.Name = "SeriesProgress";
            this.chart_taskProgress.Series.Add(series1);
            this.chart_taskProgress.Size = new System.Drawing.Size(188, 152);
            this.chart_taskProgress.TabIndex = 18;
            this.chart_taskProgress.Text = " ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 100;
            this.label1.Text = "Task Board";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(2, 18);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(218, 26);
            this.label.TabIndex = 96;
            this.label.Text = "TODO";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_todoTask
            // 
            this.label_todoTask.BackColor = System.Drawing.Color.Transparent;
            this.label_todoTask.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_todoTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_todoTask.Location = new System.Drawing.Point(2, 94);
            this.label_todoTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_todoTask.Name = "label_todoTask";
            this.label_todoTask.Size = new System.Drawing.Size(218, 41);
            this.label_todoTask.TabIndex = 97;
            this.label_todoTask.Text = "44 %";
            this.label_todoTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.guna2GradientPanel1);
            this.guna2Panel3.Controls.Add(this.label_todoTask);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(242, 15);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel3.Size = new System.Drawing.Size(225, 157);
            this.guna2Panel3.TabIndex = 89;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.label);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.BorderRadius = 25;
            this.guna2GradientPanel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.ShadowDecoration.Enabled = true;
            this.guna2GradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2GradientPanel1.Size = new System.Drawing.Size(225, 66);
            this.guna2GradientPanel1.TabIndex = 104;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel2);
            this.guna2Panel2.Controls.Add(this.label_inprogressTask);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(487, 15);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel2.Size = new System.Drawing.Size(225, 157);
            this.guna2Panel2.TabIndex = 98;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.BorderRadius = 20;
            this.guna2GradientPanel2.Controls.Add(this.label2);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.Lime;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.SpringGreen;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.BorderRadius = 25;
            this.guna2GradientPanel2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel2.ShadowDecoration.Enabled = true;
            this.guna2GradientPanel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2GradientPanel2.Size = new System.Drawing.Size(225, 66);
            this.guna2GradientPanel2.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 26);
            this.label2.TabIndex = 96;
            this.label2.Text = "IN PROGRESS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_inprogressTask
            // 
            this.label_inprogressTask.BackColor = System.Drawing.Color.Transparent;
            this.label_inprogressTask.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inprogressTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_inprogressTask.Location = new System.Drawing.Point(2, 94);
            this.label_inprogressTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_inprogressTask.Name = "label_inprogressTask";
            this.label_inprogressTask.Size = new System.Drawing.Size(220, 41);
            this.label_inprogressTask.TabIndex = 97;
            this.label_inprogressTask.Text = "20 %";
            this.label_inprogressTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderRadius = 20;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.guna2GradientPanel3);
            this.guna2Panel4.Controls.Add(this.label_doneTask);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(731, 15);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.BorderRadius = 25;
            this.guna2Panel4.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel4.ShadowDecoration.Enabled = true;
            this.guna2Panel4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel4.Size = new System.Drawing.Size(225, 157);
            this.guna2Panel4.TabIndex = 98;
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel3.BorderRadius = 20;
            this.guna2GradientPanel3.Controls.Add(this.label4);
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.Magenta;
            this.guna2GradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.ShadowDecoration.BorderRadius = 25;
            this.guna2GradientPanel3.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel3.ShadowDecoration.Enabled = true;
            this.guna2GradientPanel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2GradientPanel3.Size = new System.Drawing.Size(225, 66);
            this.guna2GradientPanel3.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 26);
            this.label4.TabIndex = 96;
            this.label4.Text = "DONE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_doneTask
            // 
            this.label_doneTask.BackColor = System.Drawing.Color.Transparent;
            this.label_doneTask.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_doneTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(40)))), ((int)(((byte)(226)))));
            this.label_doneTask.Location = new System.Drawing.Point(2, 94);
            this.label_doneTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_doneTask.Name = "label_doneTask";
            this.label_doneTask.Size = new System.Drawing.Size(220, 41);
            this.label_doneTask.TabIndex = 97;
            this.label_doneTask.Text = "36 %";
            this.label_doneTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoRoundedCorners = true;
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BorderRadius = 14;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonAdd.Location = new System.Drawing.Point(836, 221);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(30, 32);
            this.buttonAdd.TabIndex = 97;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.AutoRoundedCorners = true;
            this.btnViewDetail.BorderRadius = 14;
            this.btnViewDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDetail.FillColor = System.Drawing.Color.Transparent;
            this.btnViewDetail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnViewDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDetail.Image")));
            this.btnViewDetail.ImageSize = new System.Drawing.Size(28, 28);
            this.btnViewDetail.Location = new System.Drawing.Point(794, 221);
            this.btnViewDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(30, 32);
            this.btnViewDetail.TabIndex = 101;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.AutoRoundedCorners = true;
            this.btnEditTask.BackColor = System.Drawing.Color.Transparent;
            this.btnEditTask.BorderRadius = 14;
            this.btnEditTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditTask.FillColor = System.Drawing.Color.Transparent;
            this.btnEditTask.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditTask.ForeColor = System.Drawing.Color.White;
            this.btnEditTask.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnEditTask.Image = global::Project_Management.Properties.Resources.edit;
            this.btnEditTask.ImageSize = new System.Drawing.Size(28, 28);
            this.btnEditTask.Location = new System.Drawing.Point(878, 221);
            this.btnEditTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(30, 32);
            this.btnEditTask.TabIndex = 98;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.AutoRoundedCorners = true;
            this.btnRemoveTask.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveTask.BorderRadius = 14;
            this.btnRemoveTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveTask.FillColor = System.Drawing.Color.Transparent;
            this.btnRemoveTask.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRemoveTask.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTask.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveTask.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTask.Image = global::Project_Management.Properties.Resources.trash;
            this.btnRemoveTask.ImageSize = new System.Drawing.Size(28, 28);
            this.btnRemoveTask.Location = new System.Drawing.Point(920, 221);
            this.btnRemoveTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(30, 32);
            this.btnRemoveTask.TabIndex = 99;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.AutoRoundedCorners = true;
            this.btnAddTask.BorderRadius = 14;
            this.btnAddTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTask.FillColor = System.Drawing.Color.Transparent;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Image = global::Project_Management.Properties.Resources.plus;
            this.btnAddTask.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAddTask.Location = new System.Drawing.Point(836, 221);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(30, 32);
            this.btnAddTask.TabIndex = 103;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // UcTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.btnViewDetail);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelFields);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnRemoveTask);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcTask";
            this.Size = new System.Drawing.Size(969, 640);
            this.Load += new System.EventHandler(this.UC_Task_Load);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Task)).EndInit();
            this.panelFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_taskProgress)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2GradientPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2ComboBox combobox_taskProgressFilter;

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelData;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Task;
        private Guna.UI2.WinForms.Guna2Panel panelFields;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnEditTask;
        private Guna.UI2.WinForms.Guna2Button btnRemoveTask;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2Button btnViewDetail;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_taskProgress;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_todoTask;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label_doneTask;
        private System.Windows.Forms.Label label_inprogressTask;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_taskStatusFilter;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
    }
}
