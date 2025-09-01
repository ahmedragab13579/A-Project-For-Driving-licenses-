using DVDL_Business.After.Application;
using DVDL_Business.After.ApplicationType;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.LicenseType;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.Users;
using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.LocalLicense.AddDrivingLicense;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class AddLocalDrivingLicenseApplicationForm : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshLicenseData;


        IAddDrivingLIcenseUtility _AddDrivingLIcenseUtility;
        public AddLocalDrivingLicenseApplicationForm(IAddDrivingLIcenseUtility addDrivingLIcenseUtility)
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);

            _AddDrivingLIcenseUtility = addDrivingLIcenseUtility;
            personCardWithFilter1.SetUtility(_AddDrivingLIcenseUtility.PersonCardUtility());
            personCardWithFilter1.UserFound += personCardWithFilter1_UserFound;
        }

  
        private void FillTheApplicationInformation()
        {
            ApplicationDateLabel.Text = DateTime.Now.ToString();
            CreatedByLabel.Text = _AddDrivingLIcenseUtility.GetUserName();
            FillTheLicenseClassType();
            ApplicationFeesLabel.Text = _AddDrivingLIcenseUtility.ApplicationFees(1).ToString();
        }
        private void FillTheLicenseClassType()
        {

            foreach (DataRow Row in _AddDrivingLIcenseUtility.GetData().Rows)
            {
                LicenseClass.Items.Add(Row["ClassName"]);

            }

        }

        private bool IsValidSave()
        {

            bool ISValid = true;
            if (LicenseClass.SelectedItem == null)
            {
                ISValid = false;
                MessageBox.Show("Please Choose a License Type");
            }
            return ISValid;
        }






        private void AddDrivingLicenseForm_Load(object sender, EventArgs e)
        {
            FillTheApplicationInformation();
            LicenseClass.SelectedIndex = 0;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            LicenseInformation.SelectedIndex = 1;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!_AddDrivingLIcenseUtility.IsPersonHasTheSameLicense(personCardWithFilter1.GetThePerson().NationalNo, LicenseClass.SelectedItem.ToString()))
            {
                if (IsValidSave())
                {
                    ApplicationIDLabel.Text = _AddDrivingLIcenseUtility.SaveToTheLocalLicenseApplications(personCardWithFilter1.GetThePerson().PersonID, ApplicationFeesLabel.Text, LicenseClass.SelectedIndex.ToString()).ToString();
                    MessageBox.Show("Added Successfully");
                    SaveButton.Enabled = false;
                    RefreshLicenseData?.Invoke(this);

                }

            }
            else
            {
                MessageBox.Show("You Can not Add Many The Same License For The Same Person ");
            }

        }

        private void personCardWithFilter1_UserFound(int obj)
        {
            SaveButton.Enabled = true;
        }
    }
}