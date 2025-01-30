namespace Visitor_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.History_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.History_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Reports_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Reports_btn = new Guna.UI2.WinForms.Guna2Button();
            this.addVisitor_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.add_Visitor_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Queue_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Queue_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.logoImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.History_panel.SuspendLayout();
            this.Reports_panel.SuspendLayout();
            this.addVisitor_panel.SuspendLayout();
            this.Queue_panel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.LongText.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // History_panel
            // 
            this.History_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.History_panel.Controls.Add(this.History_btn);
            this.History_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History_panel.Location = new System.Drawing.Point(3, 532);
            this.History_panel.Name = "History_panel";
            this.History_panel.Size = new System.Drawing.Size(288, 63);
            this.History_panel.TabIndex = 6;
            // 
            // History_btn
            // 
            this.History_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.History_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.History_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.History_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.History_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.History_btn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_btn.ForeColor = System.Drawing.Color.White;
            this.History_btn.Image = ((System.Drawing.Image)(resources.GetObject("History_btn.Image")));
            this.History_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.History_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.History_btn.Location = new System.Drawing.Point(20, 0);
            this.History_btn.Name = "History_btn";
            this.History_btn.Size = new System.Drawing.Size(268, 63);
            this.History_btn.TabIndex = 8;
            this.History_btn.Text = "History";
            this.History_btn.Click += new System.EventHandler(this.History_btn_Click);
            // 
            // Reports_panel
            // 
            this.Reports_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.Reports_panel.Controls.Add(this.Reports_btn);
            this.Reports_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reports_panel.Location = new System.Drawing.Point(3, 456);
            this.Reports_panel.Name = "Reports_panel";
            this.Reports_panel.Size = new System.Drawing.Size(288, 63);
            this.Reports_panel.TabIndex = 5;
            // 
            // Reports_btn
            // 
            this.Reports_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reports_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Reports_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Reports_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reports_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Reports_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.Reports_btn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports_btn.ForeColor = System.Drawing.Color.White;
            this.Reports_btn.Image = ((System.Drawing.Image)(resources.GetObject("Reports_btn.Image")));
            this.Reports_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Reports_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.Reports_btn.Location = new System.Drawing.Point(20, 0);
            this.Reports_btn.Name = "Reports_btn";
            this.Reports_btn.Size = new System.Drawing.Size(268, 63);
            this.Reports_btn.TabIndex = 8;
            this.Reports_btn.Text = "Reports";
            this.Reports_btn.Click += new System.EventHandler(this.Reports_btn_Click);
            // 
            // addVisitor_panel
            // 
            this.addVisitor_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.addVisitor_panel.Controls.Add(this.add_Visitor_btn);
            this.addVisitor_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addVisitor_panel.Location = new System.Drawing.Point(3, 301);
            this.addVisitor_panel.Name = "addVisitor_panel";
            this.addVisitor_panel.Size = new System.Drawing.Size(288, 63);
            this.addVisitor_panel.TabIndex = 4;
            // 
            // add_Visitor_btn
            // 
            this.add_Visitor_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Visitor_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_Visitor_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_Visitor_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_Visitor_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_Visitor_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.add_Visitor_btn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Visitor_btn.ForeColor = System.Drawing.Color.White;
            this.add_Visitor_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_Visitor_btn.Image")));
            this.add_Visitor_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.add_Visitor_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.add_Visitor_btn.Location = new System.Drawing.Point(20, 0);
            this.add_Visitor_btn.Name = "add_Visitor_btn";
            this.add_Visitor_btn.Size = new System.Drawing.Size(265, 63);
            this.add_Visitor_btn.TabIndex = 7;
            this.add_Visitor_btn.Text = "Add Visitor";
            this.add_Visitor_btn.Click += new System.EventHandler(this.add_Visitor_btn_Click);
            // 
            // Queue_panel
            // 
            this.Queue_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.Queue_panel.Controls.Add(this.Queue_btn);
            this.Queue_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Queue_panel.Location = new System.Drawing.Point(3, 380);
            this.Queue_panel.Name = "Queue_panel";
            this.Queue_panel.Size = new System.Drawing.Size(288, 63);
            this.Queue_panel.TabIndex = 4;
            // 
            // Queue_btn
            // 
            this.Queue_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Queue_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Queue_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Queue_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Queue_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Queue_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.Queue_btn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Queue_btn.ForeColor = System.Drawing.Color.White;
            this.Queue_btn.Image = ((System.Drawing.Image)(resources.GetObject("Queue_btn.Image")));
            this.Queue_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Queue_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.Queue_btn.Location = new System.Drawing.Point(20, 0);
            this.Queue_btn.Name = "Queue_btn";
            this.Queue_btn.Size = new System.Drawing.Size(268, 63);
            this.Queue_btn.TabIndex = 8;
            this.Queue_btn.Text = "Queue";
            this.Queue_btn.Click += new System.EventHandler(this.Queue_btn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.guna2Panel1.Controls.Add(this.Logout_btn);
            this.guna2Panel1.Controls.Add(this.logoImage);
            this.guna2Panel1.Controls.Add(this.addVisitor_panel);
            this.guna2Panel1.Controls.Add(this.History_panel);
            this.guna2Panel1.Controls.Add(this.Reports_panel);
            this.guna2Panel1.Controls.Add(this.Queue_panel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(293, 675);
            this.guna2Panel1.TabIndex = 7;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BorderRadius = 12;
            this.Logout_btn.BorderThickness = 1;
            this.Logout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Logout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Logout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Logout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Logout_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logout_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("Logout_btn.Image")));
            this.Logout_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Logout_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.Logout_btn.Location = new System.Drawing.Point(12, 956);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(264, 51);
            this.Logout_btn.TabIndex = 8;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // logoImage
            // 
            this.logoImage.BackColor = System.Drawing.Color.White;
            this.logoImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.ImageRotate = 0F;
            this.logoImage.Location = new System.Drawing.Point(23, 33);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(239, 184);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(293, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(990, 675);
            this.MainPanel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitor Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.History_panel.ResumeLayout(false);
            this.Reports_panel.ResumeLayout(false);
            this.addVisitor_panel.ResumeLayout(false);
            this.Queue_panel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Guna.UI2.WinForms.Guna2Panel History_panel;
        private Guna.UI2.WinForms.Guna2Button History_btn;
        private Guna.UI2.WinForms.Guna2Panel Reports_panel;
        private Guna.UI2.WinForms.Guna2Button Reports_btn;
        private Guna.UI2.WinForms.Guna2Panel Queue_panel;
        private Guna.UI2.WinForms.Guna2Button Queue_btn;
        private Guna.UI2.WinForms.Guna2Panel addVisitor_panel;
        private Guna.UI2.WinForms.Guna2Button add_Visitor_btn;
        private Guna.UI2.WinForms.Guna2PictureBox logoImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button Logout_btn;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
    }
}