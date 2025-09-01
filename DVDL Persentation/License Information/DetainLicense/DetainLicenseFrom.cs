using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.DetainLicense.Detain;

namespace DVDL_Persentation
{
    public partial class DetainLicenseFrom : Form
    {
        IDetainLicenseUtility _DetainLicenseUtility;
        public DetainLicenseFrom(IDetainLicenseUtility _DetainLicenseUtility)
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);

            this._DetainLicenseUtility = _DetainLicenseUtility;
            findLicenseWithFilter1.SetUtility(_DetainLicenseUtility.findLicenserWithFilterUtility());
            findLicenseWithFilter1.LicenseInformation += findLicenseWithFilter1_LicenseInformation;
        }



        private void FillTheDetainInfo()
        {
            ID.Text = _DetainLicenseUtility.LicenseID().ToString();
            User.Text = _DetainLicenseUtility.GetCurrentUserName();
            DetainDate.Text = DateTime.Now.ToString();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            DetainID.Text = _DetainLicenseUtility.PrepareDetainLicese((string.IsNullOrEmpty(FeesTextbox.Text) ? "0" : FeesTextbox.Text)).ToString();
            MessageBox.Show("Detained Sucssesfuly");
        }

        private void findLicenseWithFilter1_LicenseInformation(object sender, EventArgs e)
        {
            if (!_DetainLicenseUtility.IsDetained())
            {

                FillTheDetainInfo();
                Save.Enabled = true;
            }
            else
            {
                MessageBox.Show("This License Is Already Detained");
            }
        }

        private void FeesTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }
    }
}
