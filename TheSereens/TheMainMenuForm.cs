using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Users;
using TheSereens.License_Information;
using TheSereens.Manage_Screens;

namespace TheSereens
{
    public partial class TheMainMenuForm : Form
    {
        public TheMainMenuForm()
        {
            InitializeComponent();
        }

        private void ManagePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManagePeopleScreen = new ManagePeopleForm();
            ManagePeopleScreen.ShowDialog();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form LoginScreen = new TheLoginScreenForm();
            LoginScreen.ShowDialog();
            this.Close();

        }

        private void ManageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManageUsers=new ManageUsersForm();
            ManageUsers.ShowDialog();
        }

        private void ChangePToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form changepassword = new ChangePasswordForm(ClassCurrentUserInformation.CurrentUser.UserID);
            changepassword.ShowDialog();
        }

        private void CurrentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form User = new UserInformationForm(ClassCurrentUserInformation.CurrentUser.UserID);
            User.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Application=new ManageApplicationTypesForm();
            Application.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Test = new ManageTestsType();
            Test.ShowDialog();

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form license=new AddDrivingLicenseForm(1);
            license.ShowDialog();
        }

        private void manageLocalDriveingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form LocalDrivingLicenseApplication = new ManageLocalDrivingLicenseApplicationForm();
            LocalDrivingLicenseApplication.ShowDialog();
        }

        private void ManageDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Drivers = new ManageDrivers();
            Drivers.ShowDialog();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InternationalLicense = new IssueInternationalLicense();
            InternationalLicense.ShowDialog();
        }

        private void manageInternationalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InternationalInformation = new ManageInternationalLicense();
            InternationalInformation.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RenewLicense= new RenewDrivingLicenseForm();
            RenewLicense.ShowDialog();
        }

        private void replaceLicenseForDamageOrLostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Change = new ChangeLicenseForLostOrDamage();
            Change.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form detain = new DetainLicenseFrom();
            detain.ShowDialog();
        }

        private void relaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Relase = new RelaseDetainLicenseFrom();
            Relase.ShowDialog();
        }

        private void TheMainMenuForm_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menuItem in this.ProcessMenuStrip.Items)
            {
              

                foreach (ToolStripItem subItem in menuItem.DropDownItems)
                {
                    subItem.BackColor = Color.FromArgb(45, 45, 45);
                    subItem.ForeColor = Color.White;
                    subItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);

                    if (subItem is ToolStripMenuItem subMenuItem && subMenuItem.HasDropDownItems)
                    {
                        foreach (ToolStripItem thirdItem in subMenuItem.DropDownItems)
                        {
                            thirdItem.BackColor = Color.FromArgb(55, 55, 55);
                            thirdItem.ForeColor = Color.White;
                            thirdItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        }
                    }
                }
            }
        }
    }
}
