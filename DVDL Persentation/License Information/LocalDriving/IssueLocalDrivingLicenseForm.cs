using DVDL_Business.After.Application;
using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.LicenseType;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.Users;
using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.LocalLicense.IssueDrivinglIcense;
using System;
using System.Windows.Forms;

namespace DVDL_Persentation.License_Information
{
    public partial class IssueLocalDrivingLicenseForm : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheLicense;

   

        IIssueDrivingLicenseUtility _IssueDrivingLicenseUtility;
        int Local;
        public IssueLocalDrivingLicenseForm(int local, IIssueDrivingLicenseUtility _IssueDrivingLicenseUtility)
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);

            this._IssueDrivingLicenseUtility = _IssueDrivingLicenseUtility;

        }



  
        
        
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void IssueDrivingLicenseForm_Load(object sender, EventArgs e)
        {
            licenseInfomations1.FillTheLocalLicenseInformation(Local);
        }

        private void Issue_Click(object sender, EventArgs e)
        {
            _IssueDrivingLicenseUtility.PrepareTheLicense(licenseInfomations1.PersonID(),Local,NotesTextBox.Text);
            _IssueDrivingLicenseUtility. MakeTheApplicationCompleted(Local);
            RefreshTheLicense?.Invoke(this);
            MessageBox.Show("Wellcome In The Street 👌");
        }
    }
}
