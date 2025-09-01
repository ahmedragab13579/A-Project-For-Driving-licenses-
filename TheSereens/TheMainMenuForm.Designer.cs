namespace TheSereens
{
    partial class TheMainMenuForm
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
            this.ProcessMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenseServesesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceLicenseForDamageOrLostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLocalDriveingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagePeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProcessMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessMenuStrip
            // 
            this.ProcessMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationsToolStripMenuItem,
            this.ManagePeopleToolStripMenuItem,
            this.ManageDriversToolStripMenuItem,
            this.ManageUsersToolStripMenuItem,
            this.ManageAccountToolStripMenuItem});
            this.ProcessMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProcessMenuStrip.Name = "ProcessMenuStrip";
            this.ProcessMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.ProcessMenuStrip.TabIndex = 0;
            this.ProcessMenuStrip.Text = "menuStrip1";
            // 
            // ApplicationsToolStripMenuItem
            // 
            this.ApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem,
            this.drivingLicenseServesesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicenseToolStripMenuItem});
            this.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem";
            this.ApplicationsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ApplicationsToolStripMenuItem.Text = "Application";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // drivingLicenseServesesToolStripMenuItem
            // 
            this.drivingLicenseServesesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replaceLicenseForDamageOrLostToolStripMenuItem});
            this.drivingLicenseServesesToolStripMenuItem.Name = "drivingLicenseServesesToolStripMenuItem";
            this.drivingLicenseServesesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.drivingLicenseServesesToolStripMenuItem.Text = "Driving License Serveses";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.iToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.iToolStripMenuItem.Text = "International License";
            this.iToolStripMenuItem.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replaceLicenseForDamageOrLostToolStripMenuItem
            // 
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Name = "replaceLicenseForDamageOrLostToolStripMenuItem";
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Text = "Replace license For Damage Or Lost";
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Click += new System.EventHandler(this.replaceLicenseForDamageOrLostToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLocalDriveingToolStripMenuItem,
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // manageLocalDriveingToolStripMenuItem
            // 
            this.manageLocalDriveingToolStripMenuItem.Name = "manageLocalDriveingToolStripMenuItem";
            this.manageLocalDriveingToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.manageLocalDriveingToolStripMenuItem.Text = "Manage Local Driving License Application";
            this.manageLocalDriveingToolStripMenuItem.Click += new System.EventHandler(this.manageLocalDriveingToolStripMenuItem_Click);
            // 
            // manageInternationalDrivingLicenseApplicationToolStripMenuItem
            // 
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem.Name = "manageInternationalDrivingLicenseApplicationToolStripMenuItem";
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem.Text = "Manage International Driving License Application";
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.manageInternationalDrivingLicenseApplicationToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainLicenseToolStripMenuItem,
            this.detainLicenseToolStripMenuItem1,
            this.relaseDetainLicenseToolStripMenuItem});
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.detainLicenseToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainLicenseToolStripMenuItem
            // 
            this.manageDetainLicenseToolStripMenuItem.Name = "manageDetainLicenseToolStripMenuItem";
            this.manageDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.manageDetainLicenseToolStripMenuItem.Text = "Manage Detain License";
            // 
            // detainLicenseToolStripMenuItem1
            // 
            this.detainLicenseToolStripMenuItem1.Name = "detainLicenseToolStripMenuItem1";
            this.detainLicenseToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.detainLicenseToolStripMenuItem1.Text = "Detain License";
            this.detainLicenseToolStripMenuItem1.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem1_Click);
            // 
            // relaseDetainLicenseToolStripMenuItem
            // 
            this.relaseDetainLicenseToolStripMenuItem.Name = "relaseDetainLicenseToolStripMenuItem";
            this.relaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.relaseDetainLicenseToolStripMenuItem.Text = "Relase Detain License";
            this.relaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.relaseDetainLicenseToolStripMenuItem_Click);
            // 
            // ManagePeopleToolStripMenuItem
            // 
            this.ManagePeopleToolStripMenuItem.Name = "ManagePeopleToolStripMenuItem";
            this.ManagePeopleToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.ManagePeopleToolStripMenuItem.Text = "ManagePeople";
            this.ManagePeopleToolStripMenuItem.Click += new System.EventHandler(this.ManagePeopleToolStripMenuItem_Click);
            // 
            // ManageDriversToolStripMenuItem
            // 
            this.ManageDriversToolStripMenuItem.Name = "ManageDriversToolStripMenuItem";
            this.ManageDriversToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.ManageDriversToolStripMenuItem.Text = "ManageDrivers";
            this.ManageDriversToolStripMenuItem.Click += new System.EventHandler(this.ManageDriversToolStripMenuItem_Click);
            // 
            // ManageUsersToolStripMenuItem
            // 
            this.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem";
            this.ManageUsersToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ManageUsersToolStripMenuItem.Text = "Manage users";
            this.ManageUsersToolStripMenuItem.Click += new System.EventHandler(this.ManageUsersToolStripMenuItem_Click);
            // 
            // ManageAccountToolStripMenuItem
            // 
            this.ManageAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.changePToolStripMenuItem});
            this.ManageAccountToolStripMenuItem.Name = "ManageAccountToolStripMenuItem";
            this.ManageAccountToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.ManageAccountToolStripMenuItem.Text = "Manage account";
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.currentUserToolStripMenuItem.Text = "Current user Information";
            this.currentUserToolStripMenuItem.Click += new System.EventHandler(this.CurrentUserToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // changePToolStripMenuItem
            // 
            this.changePToolStripMenuItem.Name = "changePToolStripMenuItem";
            this.changePToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.changePToolStripMenuItem.Text = "Change password";
            this.changePToolStripMenuItem.Click += new System.EventHandler(this.ChangePToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheSereens.Properties.Resources.ChatGPT_Image_Jul_14__2025__10_24_24_PM;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 475);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TheMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProcessMenuStrip);
            this.MainMenuStrip = this.ProcessMenuStrip;
            this.Name = "TheMainMenuForm";
            this.Text = "TheMainMenu";
            this.ProcessMenuStrip.ResumeLayout(false);
            this.ProcessMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProcessMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagePeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseServesesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLocalDriveingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInternationalDrivingLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceLicenseForDamageOrLostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relaseDetainLicenseToolStripMenuItem;
    }
}