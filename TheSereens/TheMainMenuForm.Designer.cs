using System.Drawing;
using System.Windows.Forms;

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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessMenuStrip
            // 
            this.ProcessMenuStrip.AutoSize = false;
            this.ProcessMenuStrip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ProcessMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationsToolStripMenuItem,
            this.toolStripMenuItem17,
            this.toolStripMenuItem1,
            this.ManagePeopleToolStripMenuItem,
            this.ManageDriversToolStripMenuItem,
            this.ManageUsersToolStripMenuItem,
            this.ManageAccountToolStripMenuItem});
            this.ProcessMenuStrip.Location = new System.Drawing.Point(10, 10);
            this.ProcessMenuStrip.Name = "ProcessMenuStrip";
            this.ProcessMenuStrip.Size = new System.Drawing.Size(1011, 29);
            this.ProcessMenuStrip.TabIndex = 0;
            this.ProcessMenuStrip.Text = "menuStrip1";
            // 
            // ApplicationsToolStripMenuItem
            // 
            this.ApplicationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem,
            this.drivingLicenseServesesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicenseToolStripMenuItem});
            this.ApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem";
            this.ApplicationsToolStripMenuItem.Size = new System.Drawing.Size(133, 25);
            this.ApplicationsToolStripMenuItem.Text = "📝 Applications";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.manageApplicationTypesToolStripMenuItem.Text = "📄 Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.manageTestTypesToolStripMenuItem.Text = "🧪 Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // drivingLicenseServesesToolStripMenuItem
            // 
            this.drivingLicenseServesesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replaceLicenseForDamageOrLostToolStripMenuItem});
            this.drivingLicenseServesesToolStripMenuItem.Name = "drivingLicenseServesesToolStripMenuItem";
            this.drivingLicenseServesesToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.drivingLicenseServesesToolStripMenuItem.Text = "🚗 Driving License Serveses";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.iToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.newDrivingLicenseToolStripMenuItem.Text = "➕ New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.localLicenseToolStripMenuItem.Text = "🏠 Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.iToolStripMenuItem.Text = "🌍 International License";
            this.iToolStripMenuItem.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.renewDrivingLicenseToolStripMenuItem.Text = "🔁 Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replaceLicenseForDamageOrLostToolStripMenuItem
            // 
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Name = "replaceLicenseForDamageOrLostToolStripMenuItem";
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Text = "🛠️ Replace Damaged/Lost License";
            this.replaceLicenseForDamageOrLostToolStripMenuItem.Click += new System.EventHandler(this.replaceLicenseForDamageOrLostToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLocalDriveingToolStripMenuItem,
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.manageApplicationsToolStripMenuItem.Text = "📋 Manage Applications";
            // 
            // manageLocalDriveingToolStripMenuItem
            // 
            this.manageLocalDriveingToolStripMenuItem.Name = "manageLocalDriveingToolStripMenuItem";
            this.manageLocalDriveingToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.manageLocalDriveingToolStripMenuItem.Text = "📝 Local Driving License Applications";
            this.manageLocalDriveingToolStripMenuItem.Click += new System.EventHandler(this.manageLocalDriveingToolStripMenuItem_Click);
            // 
            // manageInternationalDrivingLicenseApplicationToolStripMenuItem
            // 
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem.Name = "manageInternationalDrivingLicenseApplicationToolStripMenuItem";
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(393, 26);
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem.Text = "🌐 International Driving License Applications";
            this.manageInternationalDrivingLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.manageInternationalDrivingLicenseApplicationToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainLicenseToolStripMenuItem,
            this.detainLicenseToolStripMenuItem1,
            this.relaseDetainLicenseToolStripMenuItem});
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.detainLicenseToolStripMenuItem.Text = "🚫 Detain Licenses";
            // 
            // manageDetainLicenseToolStripMenuItem
            // 
            this.manageDetainLicenseToolStripMenuItem.Name = "manageDetainLicenseToolStripMenuItem";
            this.manageDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.manageDetainLicenseToolStripMenuItem.Text = "📚 Manage Detain Licenses";
            // 
            // detainLicenseToolStripMenuItem1
            // 
            this.detainLicenseToolStripMenuItem1.Name = "detainLicenseToolStripMenuItem1";
            this.detainLicenseToolStripMenuItem1.Size = new System.Drawing.Size(280, 26);
            this.detainLicenseToolStripMenuItem1.Text = "🛑 Detain License";
            this.detainLicenseToolStripMenuItem1.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem1_Click);
            // 
            // relaseDetainLicenseToolStripMenuItem
            // 
            this.relaseDetainLicenseToolStripMenuItem.Name = "relaseDetainLicenseToolStripMenuItem";
            this.relaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.relaseDetainLicenseToolStripMenuItem.Text = "✅ Release Detained License";
            this.relaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.relaseDetainLicenseToolStripMenuItem_Click);
            // 
            // ManagePeopleToolStripMenuItem
            // 
            this.ManagePeopleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ManagePeopleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ManagePeopleToolStripMenuItem.Name = "ManagePeopleToolStripMenuItem";
            this.ManagePeopleToolStripMenuItem.Size = new System.Drawing.Size(154, 25);
            this.ManagePeopleToolStripMenuItem.Text = "👥 Manage People";
            this.ManagePeopleToolStripMenuItem.Click += new System.EventHandler(this.ManagePeopleToolStripMenuItem_Click);
            // 
            // ManageDriversToolStripMenuItem
            // 
            this.ManageDriversToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ManageDriversToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ManageDriversToolStripMenuItem.Name = "ManageDriversToolStripMenuItem";
            this.ManageDriversToolStripMenuItem.Size = new System.Drawing.Size(158, 25);
            this.ManageDriversToolStripMenuItem.Text = "🚘 Manage Drivers";
            this.ManageDriversToolStripMenuItem.Click += new System.EventHandler(this.ManageDriversToolStripMenuItem_Click);
            // 
            // ManageUsersToolStripMenuItem
            // 
            this.ManageUsersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ManageUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem";
            this.ManageUsersToolStripMenuItem.Size = new System.Drawing.Size(147, 25);
            this.ManageUsersToolStripMenuItem.Text = "👤 Manage Users";
            this.ManageUsersToolStripMenuItem.Click += new System.EventHandler(this.ManageUsersToolStripMenuItem_Click);
            // 
            // ManageAccountToolStripMenuItem
            // 
            this.ManageAccountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ManageAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.changePToolStripMenuItem});
            this.ManageAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ManageAccountToolStripMenuItem.Name = "ManageAccountToolStripMenuItem";
            this.ManageAccountToolStripMenuItem.Size = new System.Drawing.Size(164, 25);
            this.ManageAccountToolStripMenuItem.Text = "⚙️ Manage Account";
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.currentUserToolStripMenuItem.Text = "🧾 Current User Info";
            this.currentUserToolStripMenuItem.Click += new System.EventHandler(this.CurrentUserToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.logoutToolStripMenuItem.Text = "🚪 Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // changePToolStripMenuItem
            // 
            this.changePToolStripMenuItem.Name = "changePToolStripMenuItem";
            this.changePToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.changePToolStripMenuItem.Text = "🔑 Change Password";
            this.changePToolStripMenuItem.Click += new System.EventHandler(this.ChangePToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pictureBox1.BackgroundImage = global::TheSereens.Properties.Resources.ChatGPT_Image_Jul_14__2025__10_24_24_PM;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1021, 518);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem10,
            this.toolStripMenuItem13});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 25);
            this.toolStripMenuItem1.Text = "📝 Applications";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(287, 26);
            this.toolStripMenuItem2.Text = "📄 Manage Application Types";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(287, 26);
            this.toolStripMenuItem3.Text = "🧪 Manage Test Types";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(287, 26);
            this.toolStripMenuItem4.Text = "🚗 Driving License Serveses";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(321, 26);
            this.toolStripMenuItem5.Text = "➕ New Driving License";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(249, 26);
            this.toolStripMenuItem6.Text = "🏠 Local License";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(249, 26);
            this.toolStripMenuItem7.Text = "🌍 International License";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(321, 26);
            this.toolStripMenuItem8.Text = "🔁 Renew Driving License";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(321, 26);
            this.toolStripMenuItem9.Text = "🛠️ Replace Damaged/Lost License";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.replaceLicenseForDamageOrLostToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(287, 26);
            this.toolStripMenuItem10.Text = "📋 Manage Applications";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(393, 26);
            this.toolStripMenuItem11.Text = "📝 Local Driving License Applications";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.manageLocalDriveingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(393, 26);
            this.toolStripMenuItem12.Text = "🌐 International Driving License Applications";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.manageInternationalDrivingLicenseApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16});
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(287, 26);
            this.toolStripMenuItem13.Text = "🚫 Detain Licenses";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem14.Text = "📚 Manage Detain Licenses";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem15.Text = "🛑 Detain License";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem16.Text = "✅ Release Detained License";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.relaseDetainLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem17.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(154, 25);
            this.toolStripMenuItem17.Text = "👥 Manage People";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.ManagePeopleToolStripMenuItem_Click);
            // 
            // TheMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProcessMenuStrip);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ProcessMenuStrip;
            this.MaximizeBox = false;
            this.Name = "TheMainMenuForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "TheMainMenu";
            this.Load += new System.EventHandler(this.TheMainMenuForm_Load);
            this.ProcessMenuStrip.ResumeLayout(false);
            this.ProcessMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
    }
}