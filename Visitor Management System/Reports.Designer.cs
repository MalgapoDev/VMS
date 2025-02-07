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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_ReportTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_reportSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBox_Department = new Guna.UI2.WinForms.Guna2ComboBox();
            this.downloadReport_CSV_btn = new Guna.UI2.WinForms.Guna2Button();
            this.downloadReport_PDF_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dateFilter_comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ReportTable)).BeginInit();
            this.guna2Panel1.SuspendLayout();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGrid_ReportTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_ReportTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_ReportTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_ReportTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_ReportTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_ReportTable.ColumnHeadersHeight = 20;
            this.dataGrid_ReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_ReportTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_ReportTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_ReportTable.Location = new System.Drawing.Point(17, 356);
            this.dataGrid_ReportTable.Name = "dataGrid_ReportTable";
            this.dataGrid_ReportTable.RowHeadersVisible = false;
            this.dataGrid_ReportTable.RowHeadersWidth = 51;
            this.dataGrid_ReportTable.RowTemplate.Height = 24;
            this.dataGrid_ReportTable.Size = new System.Drawing.Size(1208, 286);
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
            this.txt_reportSearch.Location = new System.Drawing.Point(36, 284);
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
            this.comboBox_Department.Location = new System.Drawing.Point(826, 284);
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
            this.label3.Location = new System.Drawing.Point(822, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1044, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Filter";
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
            this.guna2Panel1.Controls.Add(this.dateFilter_comboBox);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.downloadReport_PDF_btn);
            this.guna2Panel1.Controls.Add(this.label4);
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
            // dateFilter_comboBox
            // 
            this.dateFilter_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFilter_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.dateFilter_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateFilter_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilter_comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilter_comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateFilter_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilter_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dateFilter_comboBox.ItemHeight = 30;
            this.dateFilter_comboBox.Location = new System.Drawing.Point(1045, 284);
            this.dateFilter_comboBox.Name = "dateFilter_comboBox";
            this.dateFilter_comboBox.Size = new System.Drawing.Size(180, 36);
            this.dateFilter_comboBox.TabIndex = 13;
            this.dateFilter_comboBox.SelectedIndexChanged += new System.EventHandler(this.dateFilter_comboBox_SelectedIndexChanged);
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
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox dateFilter_comboBox;
    }
}