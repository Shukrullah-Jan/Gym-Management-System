namespace Gym_Management_System.User_Controls
{
    partial class UCSettings
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
            this.gbDataSource = new System.Windows.Forms.GroupBox();
            this.tbImagesLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangeImagesLocation = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chbEnableEditing = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.tbTableName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeDataSource = new Guna.UI2.WinForms.Guna2Button();
            this.tbDataSourcePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUserPasswordSettings = new System.Windows.Forms.GroupBox();
            this.btnResetUserPasssword = new Guna.UI2.WinForms.Guna2Button();
            this.tbConfirmPasswordUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNewPasswordUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chbUserChangePassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tbCurrentPasswordUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangePasswordUser = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gbAdminPassword = new System.Windows.Forms.GroupBox();
            this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbAdminChangePassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tbCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbContactSettings = new System.Windows.Forms.GroupBox();
            this.chbEnableContactControls = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnChangeContactInfo = new Guna.UI2.WinForms.Guna2Button();
            this.tbGymAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbBackupAndRestore = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.tbBackup = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbDataSource.SuspendLayout();
            this.gbUserPasswordSettings.SuspendLayout();
            this.gbAdminPassword.SuspendLayout();
            this.gbContactSettings.SuspendLayout();
            this.gbBackupAndRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDataSource
            // 
            this.gbDataSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.gbDataSource.Controls.Add(this.tbImagesLocation);
            this.gbDataSource.Controls.Add(this.btnChangeImagesLocation);
            this.gbDataSource.Controls.Add(this.label4);
            this.gbDataSource.Controls.Add(this.chbEnableEditing);
            this.gbDataSource.Controls.Add(this.btnSubmit);
            this.gbDataSource.Controls.Add(this.tbTableName);
            this.gbDataSource.Controls.Add(this.label2);
            this.gbDataSource.Controls.Add(this.btnChangeDataSource);
            this.gbDataSource.Controls.Add(this.tbDataSourcePath);
            this.gbDataSource.Controls.Add(this.label1);
            this.gbDataSource.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbDataSource.Location = new System.Drawing.Point(6, -1);
            this.gbDataSource.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.gbDataSource.Name = "gbDataSource";
            this.gbDataSource.Size = new System.Drawing.Size(792, 164);
            this.gbDataSource.TabIndex = 1;
            this.gbDataSource.TabStop = false;
            this.gbDataSource.Text = "Data Source Settings";
            // 
            // tbImagesLocation
            // 
            this.tbImagesLocation.Animated = true;
            this.tbImagesLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbImagesLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbImagesLocation.BorderRadius = 5;
            this.tbImagesLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbImagesLocation.DefaultText = "";
            this.tbImagesLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbImagesLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbImagesLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbImagesLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbImagesLocation.Enabled = false;
            this.tbImagesLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbImagesLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbImagesLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbImagesLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbImagesLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbImagesLocation.Location = new System.Drawing.Point(235, 92);
            this.tbImagesLocation.Name = "tbImagesLocation";
            this.tbImagesLocation.PasswordChar = '\0';
            this.tbImagesLocation.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbImagesLocation.PlaceholderText = "Images location";
            this.tbImagesLocation.SelectedText = "";
            this.tbImagesLocation.Size = new System.Drawing.Size(229, 22);
            this.tbImagesLocation.TabIndex = 5;
            // 
            // btnChangeImagesLocation
            // 
            this.btnChangeImagesLocation.Animated = true;
            this.btnChangeImagesLocation.BorderColor = System.Drawing.Color.Gray;
            this.btnChangeImagesLocation.BorderRadius = 5;
            this.btnChangeImagesLocation.BorderThickness = 1;
            this.btnChangeImagesLocation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeImagesLocation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeImagesLocation.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.btnChangeImagesLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeImagesLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnChangeImagesLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChangeImagesLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChangeImagesLocation.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnChangeImagesLocation.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnChangeImagesLocation.Location = new System.Drawing.Point(470, 89);
            this.btnChangeImagesLocation.Name = "btnChangeImagesLocation";
            this.btnChangeImagesLocation.Size = new System.Drawing.Size(89, 25);
            this.btnChangeImagesLocation.TabIndex = 6;
            this.btnChangeImagesLocation.Text = "Change";
            this.btnChangeImagesLocation.TextOffset = new System.Drawing.Point(0, -1);
            this.btnChangeImagesLocation.Click += new System.EventHandler(this.btnChangeImagesLocation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(20, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 16);
            this.label4.TabIndex = 160;
            this.label4.Text = "Select Records Images Location:";
            // 
            // chbEnableEditing
            // 
            this.chbEnableEditing.AutoSize = true;
            this.chbEnableEditing.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbEnableEditing.CheckedState.BorderRadius = 0;
            this.chbEnableEditing.CheckedState.BorderThickness = 0;
            this.chbEnableEditing.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbEnableEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEnableEditing.Location = new System.Drawing.Point(23, 22);
            this.chbEnableEditing.Name = "chbEnableEditing";
            this.chbEnableEditing.Size = new System.Drawing.Size(113, 20);
            this.chbEnableEditing.TabIndex = 1;
            this.chbEnableEditing.Text = "Enable Editing";
            this.chbEnableEditing.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbEnableEditing.UncheckedState.BorderRadius = 0;
            this.chbEnableEditing.UncheckedState.BorderThickness = 0;
            this.chbEnableEditing.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chbEnableEditing.CheckedChanged += new System.EventHandler(this.chbEnableEditing_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Animated = true;
            this.btnSubmit.BorderColor = System.Drawing.Color.Gray;
            this.btnSubmit.BorderRadius = 5;
            this.btnSubmit.BorderThickness = 1;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSubmit.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnSubmit.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSubmit.Location = new System.Drawing.Point(23, 124);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 25);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextOffset = new System.Drawing.Point(0, -1);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbTableName
            // 
            this.tbTableName.Animated = true;
            this.tbTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbTableName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbTableName.BorderRadius = 5;
            this.tbTableName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTableName.DefaultText = "";
            this.tbTableName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTableName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTableName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTableName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTableName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbTableName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTableName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbTableName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTableName.Location = new System.Drawing.Point(175, 67);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.PasswordChar = '\0';
            this.tbTableName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbTableName.PlaceholderText = "Students table name";
            this.tbTableName.SelectedText = "";
            this.tbTableName.Size = new System.Drawing.Size(169, 22);
            this.tbTableName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 156;
            this.label2.Text = "Students Table Name:";
            // 
            // btnChangeDataSource
            // 
            this.btnChangeDataSource.Animated = true;
            this.btnChangeDataSource.BorderColor = System.Drawing.Color.Gray;
            this.btnChangeDataSource.BorderRadius = 5;
            this.btnChangeDataSource.BorderThickness = 1;
            this.btnChangeDataSource.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeDataSource.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeDataSource.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.btnChangeDataSource.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeDataSource.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnChangeDataSource.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChangeDataSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChangeDataSource.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnChangeDataSource.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnChangeDataSource.Location = new System.Drawing.Point(489, 39);
            this.btnChangeDataSource.Name = "btnChangeDataSource";
            this.btnChangeDataSource.Size = new System.Drawing.Size(89, 25);
            this.btnChangeDataSource.TabIndex = 3;
            this.btnChangeDataSource.Text = "Change";
            this.btnChangeDataSource.TextOffset = new System.Drawing.Point(0, -1);
            this.btnChangeDataSource.Click += new System.EventHandler(this.btnChangeDataSource_Click);
            // 
            // tbDataSourcePath
            // 
            this.tbDataSourcePath.Animated = true;
            this.tbDataSourcePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbDataSourcePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbDataSourcePath.BorderRadius = 5;
            this.tbDataSourcePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDataSourcePath.DefaultText = "";
            this.tbDataSourcePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDataSourcePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDataSourcePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDataSourcePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDataSourcePath.Enabled = false;
            this.tbDataSourcePath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbDataSourcePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDataSourcePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDataSourcePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbDataSourcePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDataSourcePath.Location = new System.Drawing.Point(160, 42);
            this.tbDataSourcePath.Name = "tbDataSourcePath";
            this.tbDataSourcePath.PasswordChar = '\0';
            this.tbDataSourcePath.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbDataSourcePath.PlaceholderText = "Path to access database";
            this.tbDataSourcePath.SelectedText = "";
            this.tbDataSourcePath.Size = new System.Drawing.Size(323, 22);
            this.tbDataSourcePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 153;
            this.label1.Text = "Select data source:";
            // 
            // gbUserPasswordSettings
            // 
            this.gbUserPasswordSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.gbUserPasswordSettings.Controls.Add(this.btnResetUserPasssword);
            this.gbUserPasswordSettings.Controls.Add(this.tbConfirmPasswordUser);
            this.gbUserPasswordSettings.Controls.Add(this.label8);
            this.gbUserPasswordSettings.Controls.Add(this.tbNewPasswordUser);
            this.gbUserPasswordSettings.Controls.Add(this.label9);
            this.gbUserPasswordSettings.Controls.Add(this.chbUserChangePassword);
            this.gbUserPasswordSettings.Controls.Add(this.tbCurrentPasswordUser);
            this.gbUserPasswordSettings.Controls.Add(this.btnChangePasswordUser);
            this.gbUserPasswordSettings.Controls.Add(this.label12);
            this.gbUserPasswordSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserPasswordSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbUserPasswordSettings.Location = new System.Drawing.Point(398, 164);
            this.gbUserPasswordSettings.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.gbUserPasswordSettings.Name = "gbUserPasswordSettings";
            this.gbUserPasswordSettings.Size = new System.Drawing.Size(400, 157);
            this.gbUserPasswordSettings.TabIndex = 18;
            this.gbUserPasswordSettings.TabStop = false;
            this.gbUserPasswordSettings.Text = "User Password Settings";
            // 
            // btnResetUserPasssword
            // 
            this.btnResetUserPasssword.Animated = true;
            this.btnResetUserPasssword.BorderColor = System.Drawing.Color.Gray;
            this.btnResetUserPasssword.BorderRadius = 5;
            this.btnResetUserPasssword.BorderThickness = 1;
            this.btnResetUserPasssword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetUserPasssword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetUserPasssword.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.btnResetUserPasssword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResetUserPasssword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnResetUserPasssword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnResetUserPasssword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnResetUserPasssword.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnResetUserPasssword.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnResetUserPasssword.Location = new System.Drawing.Point(188, 124);
            this.btnResetUserPasssword.Name = "btnResetUserPasssword";
            this.btnResetUserPasssword.Size = new System.Drawing.Size(179, 25);
            this.btnResetUserPasssword.TabIndex = 159;
            this.btnResetUserPasssword.Text = "Reset user password";
            this.btnResetUserPasssword.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // tbConfirmPasswordUser
            // 
            this.tbConfirmPasswordUser.Animated = true;
            this.tbConfirmPasswordUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbConfirmPasswordUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbConfirmPasswordUser.BorderRadius = 5;
            this.tbConfirmPasswordUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPasswordUser.DefaultText = "";
            this.tbConfirmPasswordUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirmPasswordUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirmPasswordUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConfirmPasswordUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConfirmPasswordUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbConfirmPasswordUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPasswordUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbConfirmPasswordUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbConfirmPasswordUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPasswordUser.Location = new System.Drawing.Point(154, 96);
            this.tbConfirmPasswordUser.Name = "tbConfirmPasswordUser";
            this.tbConfirmPasswordUser.PasswordChar = '*';
            this.tbConfirmPasswordUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbConfirmPasswordUser.PlaceholderText = "Confirm Password";
            this.tbConfirmPasswordUser.SelectedText = "";
            this.tbConfirmPasswordUser.Size = new System.Drawing.Size(190, 22);
            this.tbConfirmPasswordUser.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(20, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 158;
            this.label8.Text = "Confirm Password:";
            // 
            // tbNewPasswordUser
            // 
            this.tbNewPasswordUser.Animated = true;
            this.tbNewPasswordUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbNewPasswordUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbNewPasswordUser.BorderRadius = 5;
            this.tbNewPasswordUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPasswordUser.DefaultText = "";
            this.tbNewPasswordUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNewPasswordUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNewPasswordUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPasswordUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPasswordUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbNewPasswordUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNewPasswordUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNewPasswordUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbNewPasswordUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNewPasswordUser.Location = new System.Drawing.Point(154, 71);
            this.tbNewPasswordUser.Name = "tbNewPasswordUser";
            this.tbNewPasswordUser.PasswordChar = '*';
            this.tbNewPasswordUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbNewPasswordUser.PlaceholderText = "New Password";
            this.tbNewPasswordUser.SelectedText = "";
            this.tbNewPasswordUser.Size = new System.Drawing.Size(190, 22);
            this.tbNewPasswordUser.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(20, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 156;
            this.label9.Text = "New Password: ";
            // 
            // chbUserChangePassword
            // 
            this.chbUserChangePassword.AutoSize = true;
            this.chbUserChangePassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbUserChangePassword.CheckedState.BorderRadius = 0;
            this.chbUserChangePassword.CheckedState.BorderThickness = 0;
            this.chbUserChangePassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbUserChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUserChangePassword.Location = new System.Drawing.Point(24, 22);
            this.chbUserChangePassword.Name = "chbUserChangePassword";
            this.chbUserChangePassword.Size = new System.Drawing.Size(135, 20);
            this.chbUserChangePassword.TabIndex = 9;
            this.chbUserChangePassword.Text = "Change password";
            this.chbUserChangePassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbUserChangePassword.UncheckedState.BorderRadius = 0;
            this.chbUserChangePassword.UncheckedState.BorderThickness = 0;
            this.chbUserChangePassword.UncheckedState.FillColor = System.Drawing.Color.Silver;
            // 
            // tbCurrentPasswordUser
            // 
            this.tbCurrentPasswordUser.Animated = true;
            this.tbCurrentPasswordUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbCurrentPasswordUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbCurrentPasswordUser.BorderRadius = 5;
            this.tbCurrentPasswordUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCurrentPasswordUser.DefaultText = "";
            this.tbCurrentPasswordUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCurrentPasswordUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCurrentPasswordUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCurrentPasswordUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCurrentPasswordUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbCurrentPasswordUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCurrentPasswordUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCurrentPasswordUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbCurrentPasswordUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCurrentPasswordUser.Location = new System.Drawing.Point(154, 46);
            this.tbCurrentPasswordUser.Name = "tbCurrentPasswordUser";
            this.tbCurrentPasswordUser.PasswordChar = '*';
            this.tbCurrentPasswordUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbCurrentPasswordUser.PlaceholderText = "Current Password";
            this.tbCurrentPasswordUser.SelectedText = "";
            this.tbCurrentPasswordUser.Size = new System.Drawing.Size(190, 22);
            this.tbCurrentPasswordUser.TabIndex = 10;
            // 
            // btnChangePasswordUser
            // 
            this.btnChangePasswordUser.Animated = true;
            this.btnChangePasswordUser.BorderColor = System.Drawing.Color.Gray;
            this.btnChangePasswordUser.BorderRadius = 5;
            this.btnChangePasswordUser.BorderThickness = 1;
            this.btnChangePasswordUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePasswordUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePasswordUser.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.btnChangePasswordUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangePasswordUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnChangePasswordUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChangePasswordUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChangePasswordUser.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnChangePasswordUser.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnChangePasswordUser.Location = new System.Drawing.Point(23, 124);
            this.btnChangePasswordUser.Name = "btnChangePasswordUser";
            this.btnChangePasswordUser.Size = new System.Drawing.Size(156, 25);
            this.btnChangePasswordUser.TabIndex = 13;
            this.btnChangePasswordUser.Text = "Change password";
            this.btnChangePasswordUser.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(19, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 19);
            this.label12.TabIndex = 153;
            this.label12.Text = "Current Password:";
            // 
            // gbAdminPassword
            // 
            this.gbAdminPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.gbAdminPassword.Controls.Add(this.tbConfirmPassword);
            this.gbAdminPassword.Controls.Add(this.label7);
            this.gbAdminPassword.Controls.Add(this.tbNewPassword);
            this.gbAdminPassword.Controls.Add(this.label6);
            this.gbAdminPassword.Controls.Add(this.chbAdminChangePassword);
            this.gbAdminPassword.Controls.Add(this.tbCurrentPassword);
            this.gbAdminPassword.Controls.Add(this.btnChangePassword);
            this.gbAdminPassword.Controls.Add(this.label5);
            this.gbAdminPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdminPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbAdminPassword.Location = new System.Drawing.Point(6, 164);
            this.gbAdminPassword.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.gbAdminPassword.Name = "gbAdminPassword";
            this.gbAdminPassword.Size = new System.Drawing.Size(386, 157);
            this.gbAdminPassword.TabIndex = 17;
            this.gbAdminPassword.TabStop = false;
            this.gbAdminPassword.Text = "Admin Password Settings";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Animated = true;
            this.tbConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.BorderRadius = 5;
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.DefaultText = "";
            this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.Location = new System.Drawing.Point(154, 96);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbConfirmPassword.PlaceholderText = "Confirm Password";
            this.tbConfirmPassword.SelectedText = "";
            this.tbConfirmPassword.Size = new System.Drawing.Size(190, 22);
            this.tbConfirmPassword.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(20, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 158;
            this.label7.Text = "Confirm Password:";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Animated = true;
            this.tbNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbNewPassword.BorderRadius = 5;
            this.tbNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPassword.DefaultText = "";
            this.tbNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNewPassword.Location = new System.Drawing.Point(154, 71);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbNewPassword.PlaceholderText = "New Password";
            this.tbNewPassword.SelectedText = "";
            this.tbNewPassword.Size = new System.Drawing.Size(190, 22);
            this.tbNewPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(20, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 156;
            this.label6.Text = "New Password: ";
            // 
            // chbAdminChangePassword
            // 
            this.chbAdminChangePassword.AutoSize = true;
            this.chbAdminChangePassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAdminChangePassword.CheckedState.BorderRadius = 0;
            this.chbAdminChangePassword.CheckedState.BorderThickness = 0;
            this.chbAdminChangePassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAdminChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAdminChangePassword.Location = new System.Drawing.Point(24, 22);
            this.chbAdminChangePassword.Name = "chbAdminChangePassword";
            this.chbAdminChangePassword.Size = new System.Drawing.Size(135, 20);
            this.chbAdminChangePassword.TabIndex = 9;
            this.chbAdminChangePassword.Text = "Change password";
            this.chbAdminChangePassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAdminChangePassword.UncheckedState.BorderRadius = 0;
            this.chbAdminChangePassword.UncheckedState.BorderThickness = 0;
            this.chbAdminChangePassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Animated = true;
            this.tbCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbCurrentPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbCurrentPassword.BorderRadius = 5;
            this.tbCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCurrentPassword.DefaultText = "";
            this.tbCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCurrentPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCurrentPassword.Location = new System.Drawing.Point(154, 46);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PasswordChar = '*';
            this.tbCurrentPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbCurrentPassword.PlaceholderText = "Current Password";
            this.tbCurrentPassword.SelectedText = "";
            this.tbCurrentPassword.Size = new System.Drawing.Size(190, 22);
            this.tbCurrentPassword.TabIndex = 10;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Animated = true;
            this.btnChangePassword.BorderColor = System.Drawing.Color.Gray;
            this.btnChangePassword.BorderRadius = 5;
            this.btnChangePassword.BorderThickness = 1;
            this.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChangePassword.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnChangePassword.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnChangePassword.Location = new System.Drawing.Point(23, 124);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(156, 25);
            this.btnChangePassword.TabIndex = 13;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(19, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 153;
            this.label5.Text = "Current Password:";
            // 
            // gbContactSettings
            // 
            this.gbContactSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.gbContactSettings.Controls.Add(this.chbEnableContactControls);
            this.gbContactSettings.Controls.Add(this.btnChangeContactInfo);
            this.gbContactSettings.Controls.Add(this.tbGymAddress);
            this.gbContactSettings.Controls.Add(this.label10);
            this.gbContactSettings.Controls.Add(this.tbContactNumber);
            this.gbContactSettings.Controls.Add(this.label11);
            this.gbContactSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbContactSettings.Location = new System.Drawing.Point(6, 322);
            this.gbContactSettings.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.gbContactSettings.Name = "gbContactSettings";
            this.gbContactSettings.Size = new System.Drawing.Size(386, 136);
            this.gbContactSettings.TabIndex = 20;
            this.gbContactSettings.TabStop = false;
            this.gbContactSettings.Text = "Contact Settings";
            // 
            // chbEnableContactControls
            // 
            this.chbEnableContactControls.AutoSize = true;
            this.chbEnableContactControls.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbEnableContactControls.CheckedState.BorderRadius = 0;
            this.chbEnableContactControls.CheckedState.BorderThickness = 0;
            this.chbEnableContactControls.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbEnableContactControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEnableContactControls.Location = new System.Drawing.Point(24, 26);
            this.chbEnableContactControls.Name = "chbEnableContactControls";
            this.chbEnableContactControls.Size = new System.Drawing.Size(113, 20);
            this.chbEnableContactControls.TabIndex = 159;
            this.chbEnableContactControls.Text = "Enable Editing";
            this.chbEnableContactControls.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbEnableContactControls.UncheckedState.BorderRadius = 0;
            this.chbEnableContactControls.UncheckedState.BorderThickness = 0;
            this.chbEnableContactControls.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // btnChangeContactInfo
            // 
            this.btnChangeContactInfo.Animated = true;
            this.btnChangeContactInfo.BorderColor = System.Drawing.Color.Gray;
            this.btnChangeContactInfo.BorderRadius = 5;
            this.btnChangeContactInfo.BorderThickness = 1;
            this.btnChangeContactInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeContactInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeContactInfo.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.btnChangeContactInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeContactInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnChangeContactInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChangeContactInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChangeContactInfo.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnChangeContactInfo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnChangeContactInfo.Location = new System.Drawing.Point(21, 102);
            this.btnChangeContactInfo.Name = "btnChangeContactInfo";
            this.btnChangeContactInfo.Size = new System.Drawing.Size(188, 25);
            this.btnChangeContactInfo.TabIndex = 158;
            this.btnChangeContactInfo.Text = "Change contact details";
            this.btnChangeContactInfo.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // tbGymAddress
            // 
            this.tbGymAddress.Animated = true;
            this.tbGymAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbGymAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbGymAddress.BorderRadius = 5;
            this.tbGymAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGymAddress.DefaultText = "";
            this.tbGymAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbGymAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbGymAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbGymAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbGymAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbGymAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGymAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbGymAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbGymAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGymAddress.Location = new System.Drawing.Point(130, 72);
            this.tbGymAddress.Name = "tbGymAddress";
            this.tbGymAddress.PasswordChar = '\0';
            this.tbGymAddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbGymAddress.PlaceholderText = "Gym Address";
            this.tbGymAddress.SelectedText = "";
            this.tbGymAddress.Size = new System.Drawing.Size(250, 22);
            this.tbGymAddress.TabIndex = 156;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(18, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 157;
            this.label10.Text = "Gym Address:";
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Animated = true;
            this.tbContactNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbContactNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbContactNumber.BorderRadius = 5;
            this.tbContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContactNumber.DefaultText = "";
            this.tbContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbContactNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbContactNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbContactNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbContactNumber.Location = new System.Drawing.Point(130, 47);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.PasswordChar = '\0';
            this.tbContactNumber.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbContactNumber.PlaceholderText = "Contact Number";
            this.tbContactNumber.SelectedText = "";
            this.tbContactNumber.Size = new System.Drawing.Size(161, 22);
            this.tbContactNumber.TabIndex = 154;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(18, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 155;
            this.label11.Text = "Contact Number:";
            // 
            // gbBackupAndRestore
            // 
            this.gbBackupAndRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.gbBackupAndRestore.Controls.Add(this.btnBrowse);
            this.gbBackupAndRestore.Controls.Add(this.btnBackup);
            this.gbBackupAndRestore.Controls.Add(this.tbBackup);
            this.gbBackupAndRestore.Controls.Add(this.label14);
            this.gbBackupAndRestore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBackupAndRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbBackupAndRestore.Location = new System.Drawing.Point(398, 322);
            this.gbBackupAndRestore.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.gbBackupAndRestore.Name = "gbBackupAndRestore";
            this.gbBackupAndRestore.Size = new System.Drawing.Size(400, 87);
            this.gbBackupAndRestore.TabIndex = 21;
            this.gbBackupAndRestore.TabStop = false;
            this.gbBackupAndRestore.Text = "Backup And Restore";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Animated = true;
            this.btnBrowse.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowse.BorderRadius = 5;
            this.btnBrowse.BorderThickness = 1;
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBrowse.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnBrowse.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBrowse.Location = new System.Drawing.Point(23, 54);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(103, 25);
            this.btnBrowse.TabIndex = 160;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // btnBackup
            // 
            this.btnBackup.Animated = true;
            this.btnBackup.BorderColor = System.Drawing.Color.Gray;
            this.btnBackup.BorderRadius = 5;
            this.btnBackup.BorderThickness = 1;
            this.btnBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.FillColor = System.Drawing.Color.Silver;
            this.btnBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBackup.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnBackup.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBackup.Location = new System.Drawing.Point(139, 54);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(103, 25);
            this.btnBackup.TabIndex = 158;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // tbBackup
            // 
            this.tbBackup.Animated = true;
            this.tbBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbBackup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbBackup.BorderRadius = 5;
            this.tbBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBackup.DefaultText = "";
            this.tbBackup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbBackup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbBackup.Enabled = false;
            this.tbBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbBackup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbBackup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBackup.Location = new System.Drawing.Point(130, 24);
            this.tbBackup.Name = "tbBackup";
            this.tbBackup.PasswordChar = '\0';
            this.tbBackup.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbBackup.PlaceholderText = "Backup Location";
            this.tbBackup.SelectedText = "";
            this.tbBackup.Size = new System.Drawing.Size(247, 22);
            this.tbBackup.TabIndex = 154;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(18, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 155;
            this.label14.Text = "Backup Location:";
            // 
            // UCSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.gbBackupAndRestore);
            this.Controls.Add(this.gbContactSettings);
            this.Controls.Add(this.gbUserPasswordSettings);
            this.Controls.Add(this.gbAdminPassword);
            this.Controls.Add(this.gbDataSource);
            this.Name = "UCSettings";
            this.Size = new System.Drawing.Size(808, 506);
            this.Load += new System.EventHandler(this.UCSettings_Load);
            this.gbDataSource.ResumeLayout(false);
            this.gbDataSource.PerformLayout();
            this.gbUserPasswordSettings.ResumeLayout(false);
            this.gbUserPasswordSettings.PerformLayout();
            this.gbAdminPassword.ResumeLayout(false);
            this.gbAdminPassword.PerformLayout();
            this.gbContactSettings.ResumeLayout(false);
            this.gbContactSettings.PerformLayout();
            this.gbBackupAndRestore.ResumeLayout(false);
            this.gbBackupAndRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDataSource;
        private Guna.UI2.WinForms.Guna2TextBox tbImagesLocation;
        private Guna.UI2.WinForms.Guna2Button btnChangeImagesLocation;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CheckBox chbEnableEditing;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox tbTableName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnChangeDataSource;
        private Guna.UI2.WinForms.Guna2TextBox tbDataSourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUserPasswordSettings;
        private Guna.UI2.WinForms.Guna2Button btnResetUserPasssword;
        private Guna.UI2.WinForms.Guna2TextBox tbConfirmPasswordUser;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox tbNewPasswordUser;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2CheckBox chbUserChangePassword;
        private Guna.UI2.WinForms.Guna2TextBox tbCurrentPasswordUser;
        private Guna.UI2.WinForms.Guna2Button btnChangePasswordUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbAdminPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbNewPassword;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CheckBox chbAdminChangePassword;
        private Guna.UI2.WinForms.Guna2TextBox tbCurrentPassword;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbContactSettings;
        private Guna.UI2.WinForms.Guna2CheckBox chbEnableContactControls;
        private Guna.UI2.WinForms.Guna2Button btnChangeContactInfo;
        private Guna.UI2.WinForms.Guna2TextBox tbGymAddress;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox tbContactNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbBackupAndRestore;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2Button btnBackup;
        private Guna.UI2.WinForms.Guna2TextBox tbBackup;
        private System.Windows.Forms.Label label14;
    }
}
