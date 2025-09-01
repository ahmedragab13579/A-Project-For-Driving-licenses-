using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.InternationalLicense.InternationalLicense;
using System.Windows.Forms;

namespace DVDL_Persentation.License_Information
{
    public partial class IssueInternationalLicense : Form
    {
        IInternationalLicenseUtility _InternationalLicenseUtility;
        public IssueInternationalLicense(IInternationalLicenseUtility _InternationalLicenseUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._InternationalLicenseUtility = _InternationalLicenseUtility;
            internationalLicense2.SetUtility(this._InternationalLicenseUtility);
        }

        private void internationalLicense2_Load(object sender, EventArgs e)
        {

        }
    }
}
