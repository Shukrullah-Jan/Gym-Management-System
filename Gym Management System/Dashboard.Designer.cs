namespace Gym_Management_System
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Guna2Button btnSettings;
            Guna.UI2.WinForms.Guna2Button btnPendingPayment;
            Guna.UI2.WinForms.Guna2Button btnAddMember;
            Guna.UI2.WinForms.Guna2Button btnHome;
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblUserControlName = new System.Windows.Forms.Label();
            this.panelUserControls = new System.Windows.Forms.Panel();
            this.pbClose = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            btnSettings = new Guna.UI2.WinForms.Guna2Button();
            btnPendingPayment = new Guna.UI2.WinForms.Guna2Button();
            btnAddMember = new Guna.UI2.WinForms.Guna2Button();
            btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panelButtons.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.panelButtons.Controls.Add(btnSettings);
            this.panelButtons.Controls.Add(btnPendingPayment);
            this.panelButtons.Controls.Add(btnAddMember);
            this.panelButtons.Controls.Add(btnHome);
            this.panelButtons.Controls.Add(this.panelLogo);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(176, 541);
            this.panelButtons.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(176, 130);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(11, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hazara Lachin ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.panelTitleBar.Controls.Add(this.pbClose);
            this.panelTitleBar.Controls.Add(this.lblUserControlName);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(176, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(808, 35);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblUserControlName
            // 
            this.lblUserControlName.AutoSize = true;
            this.lblUserControlName.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserControlName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUserControlName.Location = new System.Drawing.Point(360, 1);
            this.lblUserControlName.Name = "lblUserControlName";
            this.lblUserControlName.Size = new System.Drawing.Size(88, 32);
            this.lblUserControlName.TabIndex = 1;
            this.lblUserControlName.Text = "HOME";
            // 
            // panelUserControls
            // 
            this.panelUserControls.BackColor = System.Drawing.Color.Wheat;
            this.panelUserControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserControls.Location = new System.Drawing.Point(176, 35);
            this.panelUserControls.Name = "panelUserControls";
            this.panelUserControls.Size = new System.Drawing.Size(808, 506);
            this.panelUserControls.TabIndex = 2;
            // 
            // pbClose
            // 
            this.pbClose.Image = global::Gym_Management_System.Properties.Resources.light_close;
            this.pbClose.ImageRotate = 0F;
            this.pbClose.Location = new System.Drawing.Point(773, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbClose.Size = new System.Drawing.Size(28, 28);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 2;
            this.pbClose.TabStop = false;
            // 
            // btnSettings
            // 
            btnSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnSettings.BorderRadius = 1;
            btnSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnSettings.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnSettings.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(230)))), ((int)(((byte)(110)))));
            btnSettings.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSettings.CustomBorderColor = System.Drawing.Color.Transparent;
            btnSettings.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(100)))));
            btnSettings.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnSettings.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            btnSettings.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(230)))), ((int)(((byte)(110)))));
            btnSettings.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            btnSettings.Image = global::Gym_Management_System.Properties.Resources.settings;
            btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            btnSettings.ImageSize = new System.Drawing.Size(25, 25);
            btnSettings.Location = new System.Drawing.Point(0, 235);
            btnSettings.Name = "btnSettings";
            btnSettings.PressedColor = System.Drawing.Color.Gray;
            btnSettings.Size = new System.Drawing.Size(175, 35);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPendingPayment
            // 
            btnPendingPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnPendingPayment.BorderRadius = 1;
            btnPendingPayment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnPendingPayment.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnPendingPayment.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnPendingPayment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(230)))), ((int)(((byte)(110)))));
            btnPendingPayment.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            btnPendingPayment.CheckedState.Image = global::Gym_Management_System.Properties.Resources.pending_icon_dark;
            btnPendingPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPendingPayment.CustomBorderColor = System.Drawing.Color.Transparent;
            btnPendingPayment.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnPendingPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnPendingPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnPendingPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnPendingPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnPendingPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(100)))));
            btnPendingPayment.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPendingPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnPendingPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            btnPendingPayment.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnPendingPayment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(230)))), ((int)(((byte)(110)))));
            btnPendingPayment.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            btnPendingPayment.HoverState.Image = global::Gym_Management_System.Properties.Resources.pending_icon_dark;
            btnPendingPayment.Image = global::Gym_Management_System.Properties.Resources.pending_icon_light;
            btnPendingPayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            btnPendingPayment.ImageSize = new System.Drawing.Size(25, 25);
            btnPendingPayment.Location = new System.Drawing.Point(1, 202);
            btnPendingPayment.Name = "btnPendingPayment";
            btnPendingPayment.PressedColor = System.Drawing.Color.Gray;
            btnPendingPayment.Size = new System.Drawing.Size(175, 35);
            btnPendingPayment.TabIndex = 3;
            btnPendingPayment.Text = "Pending payments";
            btnPendingPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            btnPendingPayment.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // btnAddMember
            // 
            btnAddMember.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnAddMember.BorderRadius = 1;
            btnAddMember.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAddMember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnAddMember.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnAddMember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(230)))), ((int)(((byte)(110)))));
            btnAddMember.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            btnAddMember.CheckedState.Image = global::Gym_Management_System.Properties.Resources.add_icon_dark;
            btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddMember.CustomBorderColor = System.Drawing.Color.Transparent;
            btnAddMember.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnAddMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnAddMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnAddMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnAddMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnAddMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(100)))));
            btnAddMember.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnAddMember.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            btnAddMember.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnAddMember.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(230)))), ((int)(((byte)(110)))));
            btnAddMember.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            btnAddMember.HoverState.Image = global::Gym_Management_System.Properties.Resources.add_icon_dark;
            btnAddMember.Image = global::Gym_Management_System.Properties.Resources.add_icon;
            btnAddMember.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            btnAddMember.ImageSize = new System.Drawing.Size(25, 25);
            btnAddMember.Location = new System.Drawing.Point(1, 168);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.PressedColor = System.Drawing.Color.Gray;
            btnAddMember.Size = new System.Drawing.Size(175, 35);
            btnAddMember.TabIndex = 2;
            btnAddMember.Text = "Add member";
            btnAddMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnHome
            // 
            btnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnHome.BorderRadius = 1;
            btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnHome.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnHome.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(230)))), ((int)(((byte)(110)))));
            btnHome.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            btnHome.CheckedState.Image = global::Gym_Management_System.Properties.Resources.show_all;
            btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHome.CustomBorderColor = System.Drawing.Color.Transparent;
            btnHome.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(100)))));
            btnHome.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnHome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            btnHome.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(230)))), ((int)(((byte)(110)))));
            btnHome.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            btnHome.HoverState.Image = global::Gym_Management_System.Properties.Resources.show_all;
            btnHome.Image = global::Gym_Management_System.Properties.Resources.light_show_all;
            btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            btnHome.ImageSize = new System.Drawing.Size(25, 25);
            btnHome.Location = new System.Drawing.Point(1, 135);
            btnHome.Name = "btnHome";
            btnHome.PressedColor = System.Drawing.Color.Gray;
            btnHome.Size = new System.Drawing.Size(175, 35);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Gym_Management_System.Properties.Resources.gym_male_icon;
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(47, 9);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbLogo.Size = new System.Drawing.Size(82, 82);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 541);
            this.Controls.Add(this.panelUserControls);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelButtons);
            this.MinimumSize = new System.Drawing.Size(1000, 580);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelUserControls;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbClose;
        private System.Windows.Forms.Label lblUserControlName;
    }
}
