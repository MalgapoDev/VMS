namespace Visitor_Management_System
{
    partial class ModalCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalCamera));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.Capture_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox_userProfile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.comboBox_selectCamera = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_userProfile)).BeginInit();
            this.SuspendLayout();
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
            // Capture_btn
            // 
            this.Capture_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Capture_btn.BorderRadius = 15;
            this.Capture_btn.BorderThickness = 1;
            this.Capture_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Capture_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Capture_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Capture_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Capture_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Capture_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Capture_btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capture_btn.ForeColor = System.Drawing.Color.White;
            this.Capture_btn.Image = ((System.Drawing.Image)(resources.GetObject("Capture_btn.Image")));
            this.Capture_btn.Location = new System.Drawing.Point(295, 434);
            this.Capture_btn.Name = "Capture_btn";
            this.Capture_btn.Size = new System.Drawing.Size(60, 60);
            this.Capture_btn.TabIndex = 37;
            this.Capture_btn.Click += new System.EventHandler(this.Capture_btn_Click);
            // 
            // pictureBox_userProfile
            // 
            this.pictureBox_userProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_userProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_userProfile.BorderRadius = 10;
            this.pictureBox_userProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_userProfile.ImageRotate = 0F;
            this.pictureBox_userProfile.Location = new System.Drawing.Point(123, 81);
            this.pictureBox_userProfile.Name = "pictureBox_userProfile";
            this.pictureBox_userProfile.Size = new System.Drawing.Size(425, 347);
            this.pictureBox_userProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_userProfile.TabIndex = 45;
            this.pictureBox_userProfile.TabStop = false;
            // 
            // comboBox_selectCamera
            // 
            this.comboBox_selectCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_selectCamera.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_selectCamera.BorderColor = System.Drawing.Color.Black;
            this.comboBox_selectCamera.BorderRadius = 12;
            this.comboBox_selectCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_selectCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_selectCamera.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_selectCamera.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_selectCamera.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selectCamera.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_selectCamera.ItemHeight = 30;
            this.comboBox_selectCamera.Location = new System.Drawing.Point(238, 28);
            this.comboBox_selectCamera.Name = "comboBox_selectCamera";
            this.comboBox_selectCamera.Size = new System.Drawing.Size(310, 36);
            this.comboBox_selectCamera.TabIndex = 46;
            this.comboBox_selectCamera.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectCamera_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(117, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 33);
            this.label21.TabIndex = 47;
            this.label21.Text = "Camera:";
            // 
            // ModalCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 523);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.comboBox_selectCamera);
            this.Controls.Add(this.pictureBox_userProfile);
            this.Controls.Add(this.Capture_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModalCamera";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "     Visitor Management System";
            this.Load += new System.EventHandler(this.ModalCamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_userProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Guna.UI2.WinForms.Guna2Button Capture_btn;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_userProfile;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_selectCamera;
        private System.Windows.Forms.Label label21;
    }
}