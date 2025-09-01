using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using System;
using System.Windows.Forms;

namespace DVDL_Persentation.License_Information
{
    public partial class LocalLicenseApplicationInfomationForm : Form
    {
        int id;
        ILicenseInformationUtility _LicenseInformationUtility;
        public LocalLicenseApplicationInfomationForm(int id,ILicenseInformationUtility _LicenseInformationUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this.id = id;
            this._LicenseInformationUtility = _LicenseInformationUtility;
            licenseInfomations1.SetUtility(this._LicenseInformationUtility);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LocalLicenseInfomation_Load(object sender, EventArgs e)
        {
            licenseInfomations1.FillTheLocalLicenseInformation(id);
        }
    }
}
