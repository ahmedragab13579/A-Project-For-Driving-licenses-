using DVDL_Business.After.DTOs;
using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.InternationalLicense.InternationalLicense;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using Microsoft.Extensions.DependencyInjection;
namespace DVDL_Persentation.License_Information
{
    public partial class InternationalLicense : UserControl
    {


        IInternationalLicenseUtility _InternationalLicenseUtility;

        public InternationalLicense()
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);


        }
        public void SetUtility(IInternationalLicenseUtility _InternationalLicenseUtility)
        {
            this._InternationalLicenseUtility = _InternationalLicenseUtility;
            licenseInfomations1.SetUtility(_InternationalLicenseUtility.LicenseInformation());
            findLicenseWithFilter1.SetUtility(_InternationalLicenseUtility.findLicenserWithFilterUtility());
            findLicenseWithFilter1.LicenseIsFound += findLicenseWithFilter1_LicenseIsFound;
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_InternationalLicenseUtility.AddInternationalLicense())
            {

            }
            else
            {
                MessageBox.Show("You Already Have an InternationalLicese");
                InternationalLiceseInformation.Enabled = true;
                LicenseInformation.Enabled = true;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Service = Program.ServiceProvider.GetRequiredService<ILicenseInformationUtility>();

            Form License = new LocalLicenseApplicationInfomationForm(_InternationalLicenseUtility.GetLocalDrivingLicenseApplicationID(), Service);
            License.ShowDialog();
        }
        private void InternationalLiceseInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Service = Program.ServiceProvider.GetRequiredService<ILicenseInformationUtility>();
            Form Form=new LocalDrivingLicenseInformations(_InternationalLicenseUtility. GetLocalDrivingLicenseID(), Service);
            Form.ShowDialog();
        }
        private void findLicenseWithFilter1_LicenseIsFound(int obj)
        {
            licenseInfomations1.FillTheLocalLicenseInformation(_InternationalLicenseUtility.GetLocalDrivingLicenseApplicationID());
            issue.Enabled = true;
        }
    }
}
