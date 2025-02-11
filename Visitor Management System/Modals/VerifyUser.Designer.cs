namespace Visitor_Management_System
{
    partial class VerifyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyUser));
            this.Verified_User_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.confirmPinCode_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.Verified_User_panel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Verified_User_panel
            // 
            this.Verified_User_panel.BackColor = System.Drawing.Color.Transparent;
            this.Verified_User_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Verified_User_panel.BackgroundImage")));
            this.Verified_User_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Verified_User_panel.BorderColor = System.Drawing.Color.Transparent;
            this.Verified_User_panel.Controls.Add(this.guna2Panel2);
            this.Verified_User_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Verified_User_panel.Location = new System.Drawing.Point(0, 0);
            this.Verified_User_panel.Name = "Verified_User_panel";
            this.Verified_User_panel.Size = new System.Drawing.Size(1902, 1033);
            this.Verified_User_panel.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.btn_back);
            this.guna2Panel2.Controls.Add(this.confirmPinCode_btn);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.txt_PinCode);
            this.guna2Panel2.Location = new System.Drawing.Point(551, 345);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(553, 295);
            this.guna2Panel2.TabIndex = 4;
            // 
            // confirmPinCode_btn
            // 
            this.confirmPinCode_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPinCode_btn.BackColor = System.Drawing.Color.Transparent;
            this.confirmPinCode_btn.BorderRadius = 12;
            this.confirmPinCode_btn.BorderThickness = 1;
            this.confirmPinCode_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmPinCode_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmPinCode_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmPinCode_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmPinCode_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmPinCode_btn.FillColor = System.Drawing.Color.Navy;
            this.confirmPinCode_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPinCode_btn.ForeColor = System.Drawing.Color.White;
            this.confirmPinCode_btn.Location = new System.Drawing.Point(181, 193);
            this.confirmPinCode_btn.Name = "confirmPinCode_btn";
            this.confirmPinCode_btn.Size = new System.Drawing.Size(179, 50);
            this.confirmPinCode_btn.TabIndex = 2;
            this.confirmPinCode_btn.Text = "Enter";
            this.confirmPinCode_btn.Click += new System.EventHandler(this.confirmPinCode_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verify User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter 6 - digits Pin Code";
            // 
            // txt_PinCode
            // 
            this.txt_PinCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PinCode.BackColor = System.Drawing.Color.Transparent;
            this.txt_PinCode.BorderColor = System.Drawing.Color.Black;
            this.txt_PinCode.BorderRadius = 12;
            this.txt_PinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PinCode.DefaultText = "";
            this.txt_PinCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PinCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PinCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PinCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PinCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PinCode.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PinCode.ForeColor = System.Drawing.Color.Black;
            this.txt_PinCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PinCode.Location = new System.Drawing.Point(58, 130);
            this.txt_PinCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_PinCode.Name = "txt_PinCode";
            this.txt_PinCode.PasswordChar = '\0';
            this.txt_PinCode.PlaceholderText = "";
            this.txt_PinCode.SelectedText = "";
            this.txt_PinCode.Size = new System.Drawing.Size(449, 38);
            this.txt_PinCode.TabIndex = 1;
            this.txt_PinCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PinCode_KeyPress);
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
            // btn_back
            // 
            this.btn_back.BorderRadius = 5;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.Transparent;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_back.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_back.Location = new System.Drawing.Point(27, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(60, 60);
            this.btn_back.TabIndex = 4;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // VerifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Verified_User_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerifyUser";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitor Management System";
            this.Verified_User_panel.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Verified_User_panel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_PinCode;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button confirmPinCode_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btn_back;
    }
}