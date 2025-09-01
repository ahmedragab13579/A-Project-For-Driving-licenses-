using DVDL_Business.After.Users;
using DVDL_InfrastructureLayer;
using DVDL_Persentation.License_Information;
using DVDL_Persentation.Manage_Screens;
using FormsUtilities.ManageScreens.ManageDetainLicesne;
using FormsUtilities.PersonInformation.PersonCard;
using FormsUtilities.UserInformation.ChangePasssword;
using FormsUtilities.UserInformation.UserCard;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class TheMainMenuForm : Form
    {
        public TheMainMenuForm()
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);
        }

        #region Finished
        private void ManagePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ManagePeople = Program.ServiceProvider.GetRequiredService<ManagePeopleForm>();
            ManagePeople.ShowDialog();
            
        }
        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ManageAppType = Program.ServiceProvider.GetRequiredService<ManageApplicationTypesForm>();
            ManageAppType.ShowDialog();
           
        }
        private void manageDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageDetainLicense = Program.ServiceProvider.GetRequiredService<ManageDetainLicesneForm>();
            manageDetainLicense.ShowDialog();

        }
        private void ManageDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ManageDrivers = Program.ServiceProvider.GetRequiredService<ManageDrivers>();
            ManageDrivers.ShowDialog();
           
        }
        private void ManageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ManageUsers = Program.ServiceProvider.GetRequiredService<ManageUsersForm>();
            ManageUsers.ShowDialog();
          
        }
        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ManageTestType = Program.ServiceProvider.GetRequiredService<ManageTestsType>();
            ManageTestType.ShowDialog();
            
        }
        private void manageInternationalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InternationalInformation = Program.ServiceProvider.GetRequiredService<ManageInternationalLicense>();
            InternationalInformation.ShowDialog();
          
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InternationalInformation = Program.ServiceProvider.GetRequiredService<RenewDrivingLicenseForm>();
            InternationalInformation.ShowDialog();
           
        }

        private void replaceLicenseForDamageOrLostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InternationalInformation = Program.ServiceProvider.GetRequiredService<ChangeLicenseForLostOrDamage>();
            InternationalInformation.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var InternationalInformation = Program.ServiceProvider.GetRequiredService<DetainLicenseFrom>();
            InternationalInformation.ShowDialog();
         
        }

        private void relaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InternationalInformation = Program.ServiceProvider.GetRequiredService<RelaseDetainLicenseFrom>();
            InternationalInformation.ShowDialog();
        }
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var LoginScreen = Program.ServiceProvider.GetRequiredService<TheLoginScreenForm>();
            LoginScreen.ShowDialog();
            this.Close();

        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<AddLocalDrivingLicenseApplicationForm>();
            form.ShowDialog();

          
        }

        private void manageLocalDriveingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var LocalDrivingLicenseApplication = Program.ServiceProvider.GetRequiredService<ManageLocalDrivingLicenseApplicationForm>();
            LocalDrivingLicenseApplication.ShowDialog();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InternationalLicense = Program.ServiceProvider.GetRequiredService<IssueInternationalLicense>();
            InternationalLicense.ShowDialog();
          
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

        private void ChangePToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Service = Program.ServiceProvider.GetRequiredService<IChangePasswordUtility>();
            ChangePasswordForm form = new ChangePasswordForm(Service, ClassCurrentUserInformation.CurrentUser.UserID);
            form.ShowDialog();

         
        }

        private void CurrentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Service = Program.ServiceProvider.GetRequiredService<IUsercardUtility>();
            UserInformationForm form = new UserInformationForm(Service, ClassCurrentUserInformation.CurrentUser.UserID);
            form.ShowDialog();


        }


        #endregion Finished
    
        
        




    }
}
