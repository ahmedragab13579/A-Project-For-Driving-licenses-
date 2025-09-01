using System.Drawing;
using System.Windows.Forms;

namespace DVDL_Persentation
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
            ProcessMenuStrip = new MenuStrip();
            ApplicationsToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
            drivingLicenseServesesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            iToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            replaceLicenseForDamageOrLostToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            manageLocalDriveingToolStripMenuItem = new ToolStripMenuItem();
            manageInternationalDrivingLicenseApplicationToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageDetainLicenseToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem1 = new ToolStripMenuItem();
            relaseDetainLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem17 = new ToolStripMenuItem();
            ManageDriversToolStripMenuItem = new ToolStripMenuItem();
            ManageUsersToolStripMenuItem = new ToolStripMenuItem();
            ManageAccountToolStripMenuItem = new ToolStripMenuItem();
            currentUserToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            changePToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            ProcessMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ProcessMenuStrip
            // 
            ProcessMenuStrip.AutoSize = false;
            ProcessMenuStrip.BackColor = Color.Black;
            ProcessMenuStrip.Font = new Font("Segoe UI", 15F);
            ProcessMenuStrip.Items.AddRange(new ToolStripItem[] { ApplicationsToolStripMenuItem, toolStripMenuItem17, ManageDriversToolStripMenuItem, ManageUsersToolStripMenuItem, ManageAccountToolStripMenuItem });
            ProcessMenuStrip.Location = new Point(10, 10);
            ProcessMenuStrip.Name = "ProcessMenuStrip";
            ProcessMenuStrip.Size = new Size(941, 46);
            ProcessMenuStrip.TabIndex = 0;
            ProcessMenuStrip.Text = "menuStrip1";
            // 
            // ApplicationsToolStripMenuItem
            // 
            ApplicationsToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            ApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageApplicationTypesToolStripMenuItem, manageTestTypesToolStripMenuItem, drivingLicenseServesesToolStripMenuItem, manageApplicationsToolStripMenuItem, detainLicenseToolStripMenuItem });
            ApplicationsToolStripMenuItem.ForeColor = Color.White;
            ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem";
            ApplicationsToolStripMenuItem.Size = new Size(165, 42);
            ApplicationsToolStripMenuItem.Text = "📝 Applications";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Image = Properties.Resource.Application_Types_512;
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(347, 32);
            manageApplicationTypesToolStripMenuItem.Text = "📄 Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(347, 32);
            manageTestTypesToolStripMenuItem.Text = "\U0001f9ea Manage Test Types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
            // 
            // drivingLicenseServesesToolStripMenuItem
            // 
            drivingLicenseServesesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, replaceLicenseForDamageOrLostToolStripMenuItem });
            drivingLicenseServesesToolStripMenuItem.Name = "drivingLicenseServesesToolStripMenuItem";
            drivingLicenseServesesToolStripMenuItem.Size = new Size(347, 32);
            drivingLicenseServesesToolStripMenuItem.Text = "🚗 Driving License Serveses";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, iToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(384, 32);
            newDrivingLicenseToolStripMenuItem.Text = "➕ New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(294, 32);
            localLicenseToolStripMenuItem.Text = "🏠 Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // iToolStripMenuItem
            // 
            iToolStripMenuItem.Name = "iToolStripMenuItem";
            iToolStripMenuItem.Size = new Size(294, 32);
            iToolStripMenuItem.Text = "🌍 International License";
            iToolStripMenuItem.Click += iToolStripMenuItem_Click;
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(384, 32);
            renewDrivingLicenseToolStripMenuItem.Text = "🔁 Renew Driving License";
            renewDrivingLicenseToolStripMenuItem.Click += renewDrivingLicenseToolStripMenuItem_Click;
            // 
            // replaceLicenseForDamageOrLostToolStripMenuItem
            // 
            replaceLicenseForDamageOrLostToolStripMenuItem.Name = "replaceLicenseForDamageOrLostToolStripMenuItem";
            replaceLicenseForDamageOrLostToolStripMenuItem.Size = new Size(384, 32);
            replaceLicenseForDamageOrLostToolStripMenuItem.Text = "🛠️ Replace Damaged/Lost License";
            replaceLicenseForDamageOrLostToolStripMenuItem.Click += replaceLicenseForDamageOrLostToolStripMenuItem_Click;
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageLocalDriveingToolStripMenuItem, manageInternationalDrivingLicenseApplicationToolStripMenuItem });
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(347, 32);
            manageApplicationsToolStripMenuItem.Text = "📋 Manage Applications";
            // 
            // manageLocalDriveingToolStripMenuItem
            // 
            manageLocalDriveingToolStripMenuItem.Name = "manageLocalDriveingToolStripMenuItem";
            manageLocalDriveingToolStripMenuItem.Size = new Size(477, 32);
            manageLocalDriveingToolStripMenuItem.Text = "📝 Local Driving License Applications";
            manageLocalDriveingToolStripMenuItem.Click += manageLocalDriveingToolStripMenuItem_Click;
            // 
            // manageInternationalDrivingLicenseApplicationToolStripMenuItem
            // 
            manageInternationalDrivingLicenseApplicationToolStripMenuItem.Name = "manageInternationalDrivingLicenseApplicationToolStripMenuItem";
            manageInternationalDrivingLicenseApplicationToolStripMenuItem.Size = new Size(477, 32);
            manageInternationalDrivingLicenseApplicationToolStripMenuItem.Text = "🌐 International Driving License Applications";
            manageInternationalDrivingLicenseApplicationToolStripMenuItem.Click += manageInternationalDrivingLicenseApplicationToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDetainLicenseToolStripMenuItem, detainLicenseToolStripMenuItem1, relaseDetainLicenseToolStripMenuItem });
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(347, 32);
            detainLicenseToolStripMenuItem.Text = "🚫 Detain Licenses";
            // 
            // manageDetainLicenseToolStripMenuItem
            // 
            manageDetainLicenseToolStripMenuItem.Name = "manageDetainLicenseToolStripMenuItem";
            manageDetainLicenseToolStripMenuItem.Size = new Size(331, 32);
            manageDetainLicenseToolStripMenuItem.Text = "📚 Manage Detain Licenses";
            manageDetainLicenseToolStripMenuItem.Click += manageDetainLicenseToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem1
            // 
            detainLicenseToolStripMenuItem1.Name = "detainLicenseToolStripMenuItem1";
            detainLicenseToolStripMenuItem1.Size = new Size(331, 32);
            detainLicenseToolStripMenuItem1.Text = "\U0001f6d1 Detain License";
            detainLicenseToolStripMenuItem1.Click += detainLicenseToolStripMenuItem1_Click;
            // 
            // relaseDetainLicenseToolStripMenuItem
            // 
            relaseDetainLicenseToolStripMenuItem.Name = "relaseDetainLicenseToolStripMenuItem";
            relaseDetainLicenseToolStripMenuItem.Size = new Size(331, 32);
            relaseDetainLicenseToolStripMenuItem.Text = "✅ Release Detained License";
            relaseDetainLicenseToolStripMenuItem.Click += relaseDetainLicenseToolStripMenuItem_Click;
            // 
            // toolStripMenuItem17
            // 
            toolStripMenuItem17.BackColor = Color.FromArgb(45, 45, 45);
            toolStripMenuItem17.ForeColor = Color.White;
            toolStripMenuItem17.Name = "toolStripMenuItem17";
            toolStripMenuItem17.Size = new Size(191, 42);
            toolStripMenuItem17.Text = "👥 Manage People";
            toolStripMenuItem17.Click += ManagePeopleToolStripMenuItem_Click;
            // 
            // ManageDriversToolStripMenuItem
            // 
            ManageDriversToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            ManageDriversToolStripMenuItem.ForeColor = Color.White;
            ManageDriversToolStripMenuItem.Name = "ManageDriversToolStripMenuItem";
            ManageDriversToolStripMenuItem.Size = new Size(193, 42);
            ManageDriversToolStripMenuItem.Text = "🚘 Manage Drivers";
            ManageDriversToolStripMenuItem.Click += ManageDriversToolStripMenuItem_Click;
            // 
            // ManageUsersToolStripMenuItem
            // 
            ManageUsersToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            ManageUsersToolStripMenuItem.ForeColor = Color.White;
            ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem";
            ManageUsersToolStripMenuItem.Size = new Size(179, 42);
            ManageUsersToolStripMenuItem.Text = "👤 Manage Users";
            ManageUsersToolStripMenuItem.Click += ManageUsersToolStripMenuItem_Click;
            // 
            // ManageAccountToolStripMenuItem
            // 
            ManageAccountToolStripMenuItem.BackColor = Color.FromArgb(45, 45, 45);
            ManageAccountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserToolStripMenuItem, logoutToolStripMenuItem, changePToolStripMenuItem });
            ManageAccountToolStripMenuItem.ForeColor = Color.White;
            ManageAccountToolStripMenuItem.Name = "ManageAccountToolStripMenuItem";
            ManageAccountToolStripMenuItem.Size = new Size(204, 42);
            ManageAccountToolStripMenuItem.Text = "⚙️ Manage Account";
            // 
            // currentUserToolStripMenuItem
            // 
            currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            currentUserToolStripMenuItem.Size = new Size(268, 32);
            currentUserToolStripMenuItem.Text = "\U0001f9fe Current User Info";
            currentUserToolStripMenuItem.Click += CurrentUserToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(268, 32);
            logoutToolStripMenuItem.Text = "🚪 Logout";
            logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
            // 
            // changePToolStripMenuItem
            // 
            changePToolStripMenuItem.Name = "changePToolStripMenuItem";
            changePToolStripMenuItem.Size = new Size(268, 32);
            changePToolStripMenuItem.Text = "🔑 Change Password";
            changePToolStripMenuItem.Click += ChangePToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(45, 45, 45);
            pictureBox1.BackgroundImage = Properties.Resource.ChatGPT_Image_Jul_14__2025__10_24_24_PM;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(0, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(953, 501);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TheMainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(961, 558);
            Controls.Add(pictureBox1);
            Controls.Add(ProcessMenuStrip);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = ProcessMenuStrip;
            MaximizeBox = false;
            Name = "TheMainMenuForm";
            Padding = new Padding(10);
            Text = "TheMainMenu";
            Load += TheMainMenuForm_Load;
            ProcessMenuStrip.ResumeLayout(false);
            ProcessMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);


        }

        #endregion

        private System.Windows.Forms.MenuStrip ProcessMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ApplicationsToolStripMenuItem;
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
    }
}