using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.People;
using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class LocalDrivingLicenseInformations : Form
    {
        int LocalDrivingLicenseID;
     

        ILicenseInformationUtility _ILicenseInformationUtility;
        public LocalDrivingLicenseInformations(int LocalDrivingLicenseID, ILicenseInformationUtility _ILicenseInformationUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this.  LocalDrivingLicenseID = LocalDrivingLicenseID;
            
            this._ILicenseInformationUtility = _ILicenseInformationUtility;

        }
        private void PersonImage(string PersonImagePath)
        {
            if (!string.IsNullOrEmpty(PersonImagePath) && File.Exists(PersonImagePath))
            {
                pictureBox2.BackgroundImage = Image.FromFile(PersonImagePath);
                pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }

        private void FillTheLicenseInformation()
        {
            var vm = _ILicenseInformationUtility.GetLicenseInfo(LocalDrivingLicenseID.ToString());
            if (vm == null)
            {
                MessageBox.Show("There is no user with this LicenseID");
                return;
            }
            NameLabel.Text = vm.PersonName;
            IsssueReason.Text = _ILicenseInformationUtility.IssueReason( int.Parse(vm.Class));
            ExpirationDate.Text = vm.ExpirationDate;
            IssueDate.Text = vm.IssueDate;
            LicenseID.Text = vm.LicenseId;
            Notes.Text = vm.Notes;
            DriverID.Text = vm.DriverId;
            IsDetaided.Text = false.ToString();
            IsActive.Text = vm.IsActive.ToString();
            NationalID.Text = vm.NationalId;
            Gendor.Text = vm.Gender;
            DateOfBirth.Text = vm.DateOfBirth;
            PersonImage(_ILicenseInformationUtility.PersonImagePath());
            Class.Text = _ILicenseInformationUtility.IssueReason(int.Parse(vm.Class));
        }


   
        
        public void FillInternationalLIcenseInformation(int id)
        {
            InternationalLIceseInformation.Visible = true;
            InternationalLIcenseID.Text= id.ToString();
        }
        
        
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LicenseInformations_Load(object sender, EventArgs e)
        {
            FillTheLicenseInformation();
        }
    }
}
