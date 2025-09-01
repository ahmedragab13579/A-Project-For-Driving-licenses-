using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.ChangeLicense.RenewDrivingLicense;
using FormsUtilities.LicenseInformation.ChangeLicense.RenewDrivingLicense.Models;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using FormsUtilities.PersonInformation.PersonLicenseHistory;
using Microsoft.Extensions.DependencyInjection;


namespace DVDL_Persentation
{
    public partial class RenewDrivingLicenseForm : Form
    {
        IRenewLicenseUtility _IRenewLicenseUtility;
        public RenewDrivingLicenseForm(IRenewLicenseUtility _IRenewLicenseUtility)
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);

            this._IRenewLicenseUtility = _IRenewLicenseUtility;
            findLicenseWithFilter2.SetUtility(this._IRenewLicenseUtility.GetLicenserWithFilterUtility());
            findLicenseWithFilter2.LicenseInformation += findLicenseWithFilter2_LicenseInformation;
        }



        private void FillLabelsInformation(RenewLicenseViewModel vm)
        {
            RenewAppID.Text = "????";
            AppDate.Text = vm.AppDate;
            NewLiceenseIssueDate.Text = vm.NewLicenseIssueDate;
            AppFees.Text = vm.AppFees;
            LicenseFees.Text = vm.LicenseFees;
            RenewLicenseID.Text = "????";
            OldLicenseID.Text = vm.OldLicenseID;
            ExpData.Text = vm.ExpirationDate;
            CreatedID.Text = vm.CreatedBy;
            TotalFees.Text = vm.TotalFees;
            Renew.Enabled = true;
        }




    
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



   

        private void findLicenseWithFilter2_LicenseInformation(object sender, EventArgs e)
        {
            FillLabelsInformation(_IRenewLicenseUtility.FillTheInformationLabels());
            ShowHistoryLicenses.Enabled = true;
            ShowNewLicenseInformarion.Enabled = true;
        }

        private void Renew_Click_1(object sender, EventArgs e)
        {
            if (_IRenewLicenseUtility.IsLicenseExpired())
            {
               _IRenewLicenseUtility.DeactivatedTheOldLicense();
                RenewAppID.Text = _IRenewLicenseUtility.prepareTheNewApplication(AppFees.Text).ToString();
                RenewLicenseID.Text = _IRenewLicenseUtility.prepareTheNewLicense(Notes.Text).ToString();
                MessageBox.Show("Renewed Sucsessfuly ");
                ShowHistoryLicenses.Enabled = true;
                ShowNewLicenseInformarion.Enabled = true;
            }
            else
            {
                MessageBox.Show("Your License is not Expired you can not Renew it");
            }

        }

        private void ShowHistoryLicenses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formFactory = Program.ServiceProvider.GetRequiredService<IPersonLicenseHistoryUtility>();
            Form form = new PersonLicenseHistory(_IRenewLicenseUtility.NationalID(), formFactory);
            form.ShowDialog();
        }

        private void ShowNewLicenseInformarion_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formFactory = Program.ServiceProvider.GetRequiredService<ILicenseInformationUtility>();
            Form form = new LocalDrivingLicenseInformations(int.Parse(RenewLicenseID.Text), formFactory);
            form.ShowDialog();
        }
    }
}
