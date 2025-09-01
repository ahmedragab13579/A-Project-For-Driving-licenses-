using DVDL_Business.After.Application;
using DVDL_Business.After.ApplicationType;
using DVDL_Business.After.DetainLicense;
using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.People;
using DVDL_Business.After.Users;
using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.DetainLicense.Release;
using FormsUtilities.LicenseInformation.DetainLicense.Release.viewModels;
using System;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class RelaseDetainLicenseFrom : Form
    {


        IReleaseLicenseUtility _ReleaseLicenseUtility;
        public RelaseDetainLicenseFrom(IReleaseLicenseUtility _ReleaseLicenseUtility)
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);

            this._ReleaseLicenseUtility = _ReleaseLicenseUtility;
            findLicenseWithFilter1.SetUtility(_ReleaseLicenseUtility.findLicenserWithFilterUtility());
            findLicenseWithFilter1.LicenseInformation += findLicenseWithFilter1_LicenseInformation;
        }


        private void BindDetainInfo(DetainLicenseViewModel vm)
        {
            AppFees.Text = vm.AppFees.ToString();
            DetainID.Text = vm.DetainID.ToString();
            DetainFees.Text = vm.DetainFees.ToString();
            ID.Text = vm.LicenseID.ToString();
            User.Text = vm.User;
            DetainDate.Text = vm.DetainDate.ToString();
            ID.Text=_ReleaseLicenseUtility.LicenseID().ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            AppRElID.Text = _ReleaseLicenseUtility.PerpareTheApplication(AppFees.Text).ToString();
            _ReleaseLicenseUtility.PrepareRelaseDetain(AppRElID.Text);
            MessageBox.Show("Relased Sucssesfuly");
        }

        private void findLicenseWithFilter1_LicenseInformation(object sender, EventArgs e)
        {
            if(_ReleaseLicenseUtility.IsDetained())
            {
                BindDetainInfo(_ReleaseLicenseUtility.GetDetainLicenseInfo());
                Save.Enabled = true;
            }
            else
            {
                MessageBox.Show("This License Not Detained");
            }
        }
    }
}
