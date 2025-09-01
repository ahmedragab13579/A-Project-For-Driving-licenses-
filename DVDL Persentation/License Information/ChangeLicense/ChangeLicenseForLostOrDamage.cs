using DVDL_Business.After.DTOs;
using DVDL_InfrastructureLayer;
using DVDL_Persentation.Manage_Screens;
using FormsUtilities.LicenseInformation.ChangeLicense.ChangeLicenseForLostOrDamage;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using FormsUtilities.PersonInformation.PersonLicenseHistory;
using Microsoft.Extensions.DependencyInjection;

namespace DVDL_Persentation
{
    public partial class ChangeLicenseForLostOrDamage : Form
    {

        IChangeLicenseForLostOrDamage _LicenseForLostOfDamage;
        public ChangeLicenseForLostOrDamage(IChangeLicenseForLostOrDamage _licenseForLostOfDamage)
        {

            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._LicenseForLostOfDamage = _licenseForLostOfDamage;
            findLicenseWithFilter1.SetUtility(_licenseForLostOfDamage.GetLicenserWithFilterUtility());
            findLicenseWithFilter1.LicenseInformation += findLicenseWithFilter1_LicenseInformation;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FillTheReplaceApplicationID()
        {
            RepAppDate.Text = DateTime.Now.ToString();
            OldLicId.Text = _LicenseForLostOfDamage.GetLicenseID().ToString();
            CreatedUser.Text = _LicenseForLostOfDamage.CurruntUserName();
            Issue.Enabled = true;

        }
        private void ShowHistoryLicenses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formFactory = Program.ServiceProvider.GetRequiredService<IPersonLicenseHistoryUtility>();
            Form form = new PersonLicenseHistory(_LicenseForLostOfDamage.NationalNumber(), formFactory);
            form.ShowDialog();
        }
        private void Lost_CheckedChanged(object sender, EventArgs e)
        {
            RepAppFees.Text = _LicenseForLostOfDamage.ApplicationFees(Damage.Checked == true).ToString();

        }
        private void ShowNewLicenseInformarion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formFactory = Program.ServiceProvider.GetRequiredService<ILicenseInformationUtility>();
            Form form = new LocalDrivingLicenseInformations(_LicenseForLostOfDamage.GetLicenseID(), formFactory);
            form.ShowDialog();



        }



        private void Issue_Click(object sender, EventArgs e)
        {
            if (_LicenseForLostOfDamage.IsActiveLicense())
            {

                _LicenseForLostOfDamage.DeactivatedTheOldLicense();
                _LicenseForLostOfDamage.prepareTheNewApplication(RepAppFees.Text);
                ReplaceAppID.Text = _LicenseForLostOfDamage.SaveApplication().ToString();
                _LicenseForLostOfDamage.prepareTheNewLicense();
                RepLicID.Text = _LicenseForLostOfDamage.AddLicense().ToString();
                Issue.Enabled = false;
                MessageBox.Show("Added Sucseccfuly");
            }
            else
            {
                MessageBox.Show("This Licesne Is not Active You can not Replace it");
            }

        }

        private void findLicenseWithFilter1_LicenseInformation(object sender, EventArgs e)
        {
            FillTheReplaceApplicationID();
            ShowHistoryLicenses.Enabled = true;
            ShowNewLicenseInformarion.Enabled = true;

        }

        private void findLicenseWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
