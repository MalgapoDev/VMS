namespace Visitor_Management_System
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchHistory = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBox_Department = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datePicker_HistoryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dataGrid_HistoryTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.downloadHistory_CSV_btn = new Guna.UI2.WinForms.Guna2Button();
            this.downloadHistory_PDF_btn = new Guna.UI2.WinForms.Guna2Button();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HistoryTable)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "History";
            // 
            // txt_SearchHistory
            // 
            this.txt_SearchHistory.BorderColor = System.Drawing.Color.Black;
            this.txt_SearchHistory.BorderRadius = 12;
            this.txt_SearchHistory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchHistory.DefaultText = "Search....";
            this.txt_SearchHistory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchHistory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchHistory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchHistory.ForeColor = System.Drawing.Color.Black;
            this.txt_SearchHistory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchHistory.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_SearchHistory.IconRight")));
            this.txt_SearchHistory.IconRightSize = new System.Drawing.Size(30, 30);
            this.txt_SearchHistory.Location = new System.Drawing.Point(36, 284);
            this.txt_SearchHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SearchHistory.Name = "txt_SearchHistory";
            this.txt_SearchHistory.PasswordChar = '\0';
            this.txt_SearchHistory.PlaceholderText = "";
            this.txt_SearchHistory.SelectedText = "";
            this.txt_SearchHistory.Size = new System.Drawing.Size(353, 43);
            this.txt_SearchHistory.TabIndex = 6;
            this.txt_SearchHistory.TextChanged += new System.EventHandler(this.txt_SearchHistory_TextChanged);
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
            this.comboBox_Department.Location = new System.Drawing.Point(807, 284);
            this.comboBox_Department.Name = "comboBox_Department";
            this.comboBox_Department.Size = new System.Drawing.Size(212, 36);
            this.comboBox_Department.TabIndex = 8;
            this.comboBox_Department.Visible = false;
            this.comboBox_Department.SelectedIndexChanged += new System.EventHandler(this.comboBox_Department_SelectedIndexChanged);
            // 
            // datePicker_HistoryDate
            // 
            this.datePicker_HistoryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker_HistoryDate.BackColor = System.Drawing.Color.White;
            this.datePicker_HistoryDate.Checked = true;
            this.datePicker_HistoryDate.FillColor = System.Drawing.Color.White;
            this.datePicker_HistoryDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_HistoryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_HistoryDate.Location = new System.Drawing.Point(1025, 284);
            this.datePicker_HistoryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker_HistoryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker_HistoryDate.Name = "datePicker_HistoryDate";
            this.datePicker_HistoryDate.Size = new System.Drawing.Size(200, 36);
            this.datePicker_HistoryDate.TabIndex = 9;
            this.datePicker_HistoryDate.Value = new System.DateTime(2025, 1, 22, 13, 0, 35, 774);
            this.datePicker_HistoryDate.Visible = false;
            // 
            // dataGrid_HistoryTable
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGrid_HistoryTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_HistoryTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_HistoryTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_HistoryTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_HistoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_HistoryTable.ColumnHeadersHeight = 20;
            this.dataGrid_HistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_HistoryTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_HistoryTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_HistoryTable.Location = new System.Drawing.Point(17, 356);
            this.dataGrid_HistoryTable.Name = "dataGrid_HistoryTable";
            this.dataGrid_HistoryTable.RowHeadersVisible = false;
            this.dataGrid_HistoryTable.RowHeadersWidth = 51;
            this.dataGrid_HistoryTable.RowTemplate.Height = 24;
            this.dataGrid_HistoryTable.Size = new System.Drawing.Size(1208, 286);
            this.dataGrid_HistoryTable.TabIndex = 10;
            this.dataGrid_HistoryTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_HistoryTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_HistoryTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_HistoryTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_HistoryTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_HistoryTable.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_HistoryTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_HistoryTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid_HistoryTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_HistoryTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_HistoryTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_HistoryTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid_HistoryTable.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGrid_HistoryTable.ThemeStyle.ReadOnly = false;
            this.dataGrid_HistoryTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_HistoryTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_HistoryTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_HistoryTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_HistoryTable.ThemeStyle.RowsStyle.Height = 24;
            this.dataGrid_HistoryTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_HistoryTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(803, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Department";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1021, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date";
            this.label4.Visible = false;
            // 
            // downloadHistory_CSV_btn
            // 
            this.downloadHistory_CSV_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadHistory_CSV_btn.BorderRadius = 12;
            this.downloadHistory_CSV_btn.BorderThickness = 1;
            this.downloadHistory_CSV_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadHistory_CSV_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloadHistory_CSV_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloadHistory_CSV_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloadHistory_CSV_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloadHistory_CSV_btn.FillColor = System.Drawing.Color.DarkGreen;
            this.downloadHistory_CSV_btn.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.downloadHistory_CSV_btn.ForeColor = System.Drawing.Color.White;
            this.downloadHistory_CSV_btn.Image = ((System.Drawing.Image)(resources.GetObject("downloadHistory_CSV_btn.Image")));
            this.downloadHistory_CSV_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.downloadHistory_CSV_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.downloadHistory_CSV_btn.Location = new System.Drawing.Point(839, 175);
            this.downloadHistory_CSV_btn.Name = "downloadHistory_CSV_btn";
            this.downloadHistory_CSV_btn.Size = new System.Drawing.Size(180, 45);
            this.downloadHistory_CSV_btn.TabIndex = 14;
            this.downloadHistory_CSV_btn.Text = ".CSV";
            this.downloadHistory_CSV_btn.Click += new System.EventHandler(this.downloadHistory_CSV_btn_Click);
            // 
            // downloadHistory_PDF_btn
            // 
            this.downloadHistory_PDF_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadHistory_PDF_btn.BorderRadius = 12;
            this.downloadHistory_PDF_btn.BorderThickness = 1;
            this.downloadHistory_PDF_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadHistory_PDF_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloadHistory_PDF_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloadHistory_PDF_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloadHistory_PDF_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloadHistory_PDF_btn.FillColor = System.Drawing.Color.Navy;
            this.downloadHistory_PDF_btn.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.downloadHistory_PDF_btn.ForeColor = System.Drawing.Color.White;
            this.downloadHistory_PDF_btn.Image = ((System.Drawing.Image)(resources.GetObject("downloadHistory_PDF_btn.Image")));
            this.downloadHistory_PDF_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.downloadHistory_PDF_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.downloadHistory_PDF_btn.Location = new System.Drawing.Point(1045, 175);
            this.downloadHistory_PDF_btn.Name = "downloadHistory_PDF_btn";
            this.downloadHistory_PDF_btn.Size = new System.Drawing.Size(180, 45);
            this.downloadHistory_PDF_btn.TabIndex = 15;
            this.downloadHistory_PDF_btn.Text = ".PDF";
            this.downloadHistory_PDF_btn.Click += new System.EventHandler(this.downloadHistory_PDF_btn_Click);
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
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.downloadHistory_PDF_btn);
            this.guna2Panel1.Controls.Add(this.txt_SearchHistory);
            this.guna2Panel1.Controls.Add(this.downloadHistory_CSV_btn);
            this.guna2Panel1.Controls.Add(this.dataGrid_HistoryTable);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.comboBox_Department);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.datePicker_HistoryDate);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1244, 654);
            this.guna2Panel1.TabIndex = 16;
            // 
            // History
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
            this.Name = "History";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitor Management System";
            this.TextExtra = "History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HistoryTable)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchHistory;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_Department;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker_HistoryDate;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_HistoryTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button downloadHistory_CSV_btn;
        private Guna.UI2.WinForms.Guna2Button downloadHistory_PDF_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}