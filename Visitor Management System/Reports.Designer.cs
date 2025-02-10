namespace Visitor_Management_System
{
    partial class Reports
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_ReportTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_reportSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBox_Department = new Guna.UI2.WinForms.Guna2ComboBox();
            this.downloadReport_CSV_btn = new Guna.UI2.WinForms.Guna2Button();
            this.downloadReport_PDF_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Yearly = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Daily = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Quarterly = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Weekly = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Monthly = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ReportTable)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reports";
            // 
            // dataGrid_ReportTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGrid_ReportTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_ReportTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_ReportTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_ReportTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_ReportTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_ReportTable.ColumnHeadersHeight = 20;
            this.dataGrid_ReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_ReportTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_ReportTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_ReportTable.Location = new System.Drawing.Point(200, 356);
            this.dataGrid_ReportTable.Name = "dataGrid_ReportTable";
            this.dataGrid_ReportTable.RowHeadersVisible = false;
            this.dataGrid_ReportTable.RowHeadersWidth = 51;
            this.dataGrid_ReportTable.RowTemplate.Height = 24;
            this.dataGrid_ReportTable.Size = new System.Drawing.Size(1025, 286);
            this.dataGrid_ReportTable.TabIndex = 4;
            this.dataGrid_ReportTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_ReportTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_ReportTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_ReportTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_ReportTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_ReportTable.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_ReportTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_ReportTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid_ReportTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_ReportTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_ReportTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_ReportTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_ReportTable.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGrid_ReportTable.ThemeStyle.ReadOnly = false;
            this.dataGrid_ReportTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_ReportTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_ReportTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_ReportTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_ReportTable.ThemeStyle.RowsStyle.Height = 24;
            this.dataGrid_ReportTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_ReportTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txt_reportSearch
            // 
            this.txt_reportSearch.BorderColor = System.Drawing.Color.Black;
            this.txt_reportSearch.BorderRadius = 12;
            this.txt_reportSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reportSearch.DefaultText = "";
            this.txt_reportSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_reportSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_reportSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reportSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reportSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reportSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reportSearch.ForeColor = System.Drawing.Color.Black;
            this.txt_reportSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reportSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_reportSearch.IconRight")));
            this.txt_reportSearch.IconRightSize = new System.Drawing.Size(30, 30);
            this.txt_reportSearch.Location = new System.Drawing.Point(200, 277);
            this.txt_reportSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_reportSearch.Name = "txt_reportSearch";
            this.txt_reportSearch.PasswordChar = '\0';
            this.txt_reportSearch.PlaceholderText = "";
            this.txt_reportSearch.SelectedText = "";
            this.txt_reportSearch.Size = new System.Drawing.Size(353, 43);
            this.txt_reportSearch.TabIndex = 5;
            this.txt_reportSearch.TextChanged += new System.EventHandler(this.txt_reportSearch_TextChanged);
            // 
            // comboBox_Department
            // 
            this.comboBox_Department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Department.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Department.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Department.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Department.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_Department.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Department.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Department.ItemHeight = 30;
            this.comboBox_Department.Location = new System.Drawing.Point(1013, 284);
            this.comboBox_Department.Name = "comboBox_Department";
            this.comboBox_Department.Size = new System.Drawing.Size(212, 36);
            this.comboBox_Department.TabIndex = 7;
            this.comboBox_Department.SelectedIndexChanged += new System.EventHandler(this.comboBox_Department_SelectedIndexChanged);
            // 
            // downloadReport_CSV_btn
            // 
            this.downloadReport_CSV_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadReport_CSV_btn.BorderRadius = 12;
            this.downloadReport_CSV_btn.BorderThickness = 1;
            this.downloadReport_CSV_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadReport_CSV_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloadReport_CSV_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloadReport_CSV_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloadReport_CSV_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloadReport_CSV_btn.FillColor = System.Drawing.Color.DarkGreen;
            this.downloadReport_CSV_btn.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.downloadReport_CSV_btn.ForeColor = System.Drawing.Color.White;
            this.downloadReport_CSV_btn.Image = ((System.Drawing.Image)(resources.GetObject("downloadReport_CSV_btn.Image")));
            this.downloadReport_CSV_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.downloadReport_CSV_btn.Location = new System.Drawing.Point(1031, 175);
            this.downloadReport_CSV_btn.Name = "downloadReport_CSV_btn";
            this.downloadReport_CSV_btn.Size = new System.Drawing.Size(80, 60);
            this.downloadReport_CSV_btn.TabIndex = 9;
            this.downloadReport_CSV_btn.Click += new System.EventHandler(this.downloadReport_CSV_btn_Click);
            // 
            // downloadReport_PDF_btn
            // 
            this.downloadReport_PDF_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadReport_PDF_btn.BorderRadius = 12;
            this.downloadReport_PDF_btn.BorderThickness = 1;
            this.downloadReport_PDF_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadReport_PDF_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloadReport_PDF_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloadReport_PDF_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloadReport_PDF_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloadReport_PDF_btn.FillColor = System.Drawing.Color.Navy;
            this.downloadReport_PDF_btn.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.downloadReport_PDF_btn.ForeColor = System.Drawing.Color.White;
            this.downloadReport_PDF_btn.Image = ((System.Drawing.Image)(resources.GetObject("downloadReport_PDF_btn.Image")));
            this.downloadReport_PDF_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.downloadReport_PDF_btn.Location = new System.Drawing.Point(1133, 175);
            this.downloadReport_PDF_btn.Name = "downloadReport_PDF_btn";
            this.downloadReport_PDF_btn.Size = new System.Drawing.Size(80, 60);
            this.downloadReport_PDF_btn.TabIndex = 10;
            this.downloadReport_PDF_btn.Click += new System.EventHandler(this.downloadReport_PDF_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1009, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Department";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.downloadReport_PDF_btn);
            this.guna2Panel1.Controls.Add(this.downloadReport_CSV_btn);
            this.guna2Panel1.Controls.Add(this.txt_reportSearch);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.dataGrid_ReportTable);
            this.guna2Panel1.Controls.Add(this.comboBox_Department);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1244, 654);
            this.guna2Panel1.TabIndex = 13;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btn_Yearly);
            this.guna2Panel2.Controls.Add(this.btn_Daily);
            this.guna2Panel2.Controls.Add(this.btn_Quarterly);
            this.guna2Panel2.Controls.Add(this.btn_Weekly);
            this.guna2Panel2.Controls.Add(this.btn_Monthly);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 356);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(191, 254);
            this.guna2Panel2.TabIndex = 14;
            // 
            // btn_Yearly
            // 
            this.btn_Yearly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Yearly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Yearly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Yearly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Yearly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yearly.ForeColor = System.Drawing.Color.White;
            this.btn_Yearly.Location = new System.Drawing.Point(0, 207);
            this.btn_Yearly.Name = "btn_Yearly";
            this.btn_Yearly.Size = new System.Drawing.Size(191, 45);
            this.btn_Yearly.TabIndex = 19;
            this.btn_Yearly.Text = "Yearly";
            this.btn_Yearly.Click += new System.EventHandler(this.btn_Yearly_Click);
            // 
            // btn_Daily
            // 
            this.btn_Daily.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Daily.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Daily.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Daily.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Daily.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Daily.ForeColor = System.Drawing.Color.White;
            this.btn_Daily.Location = new System.Drawing.Point(0, 3);
            this.btn_Daily.Name = "btn_Daily";
            this.btn_Daily.Size = new System.Drawing.Size(191, 45);
            this.btn_Daily.TabIndex = 15;
            this.btn_Daily.Text = "Daily";
            this.btn_Daily.Click += new System.EventHandler(this.btn_Daily_Click);
            // 
            // btn_Quarterly
            // 
            this.btn_Quarterly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Quarterly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Quarterly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Quarterly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Quarterly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quarterly.ForeColor = System.Drawing.Color.White;
            this.btn_Quarterly.Location = new System.Drawing.Point(0, 156);
            this.btn_Quarterly.Name = "btn_Quarterly";
            this.btn_Quarterly.Size = new System.Drawing.Size(191, 45);
            this.btn_Quarterly.TabIndex = 18;
            this.btn_Quarterly.Text = "Quarterly";
            this.btn_Quarterly.Click += new System.EventHandler(this.btn_Quarterly_Click);
            // 
            // btn_Weekly
            // 
            this.btn_Weekly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Weekly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Weekly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Weekly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Weekly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Weekly.ForeColor = System.Drawing.Color.White;
            this.btn_Weekly.Location = new System.Drawing.Point(0, 54);
            this.btn_Weekly.Name = "btn_Weekly";
            this.btn_Weekly.Size = new System.Drawing.Size(191, 45);
            this.btn_Weekly.TabIndex = 16;
            this.btn_Weekly.Text = "Weekly";
            this.btn_Weekly.Click += new System.EventHandler(this.btn_Weekly_Click);
            // 
            // btn_Monthly
            // 
            this.btn_Monthly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Monthly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Monthly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Monthly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Monthly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Monthly.ForeColor = System.Drawing.Color.White;
            this.btn_Monthly.Location = new System.Drawing.Point(0, 105);
            this.btn_Monthly.Name = "btn_Monthly";
            this.btn_Monthly.Size = new System.Drawing.Size(191, 45);
            this.btn_Monthly.TabIndex = 17;
            this.btn_Monthly.Text = "Monthly";
            this.btn_Monthly.Click += new System.EventHandler(this.btn_Monthly_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 654);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitor Management System";
            this.TextExtra = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ReportTable)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_ReportTable;
        private Guna.UI2.WinForms.Guna2TextBox txt_reportSearch;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_Department;
        private Guna.UI2.WinForms.Guna2Button downloadReport_CSV_btn;
        private Guna.UI2.WinForms.Guna2Button downloadReport_PDF_btn;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Daily;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btn_Yearly;
        private Guna.UI2.WinForms.Guna2Button btn_Quarterly;
        private Guna.UI2.WinForms.Guna2Button btn_Weekly;
        private Guna.UI2.WinForms.Guna2Button btn_Monthly;
    }
}