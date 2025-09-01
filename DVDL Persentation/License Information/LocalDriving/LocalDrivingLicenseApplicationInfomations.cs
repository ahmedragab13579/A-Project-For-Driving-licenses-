using DVDL_Business.After.Application;
using DVDL_Business.After.ApplicationType;
using DVDL_Business.After.DOTs;
using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using FormsUtilities.PersonInformation.PersonCard;
using Microsoft.Extensions.DependencyInjection;

namespace DVDL_Persentation.License_Information
{
    public partial class LocalDrivingLicenseApplicationInfomations : UserControl
    {
     
        ILicenseInformationUtility _LicenseInformationUtility;
    
        public LocalDrivingLicenseApplicationInfomations() 
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);

        }


        public void FillTheLocalLicenseInformation(int id)
        {
            var info = _LicenseInformationUtility.GetLocalLicenseInfo(id);

            LocalLicenseIDLabel.Text = info.LocalLicenseID.ToString();
            LicenseClassLabel.Text = info.LicenseClassName;
            PassedTestLabel.Text = info.PassedTestCount.ToString();

            ApplicationID.Text = info.ApplicationID.ToString();
            FeesLabel.Text = info.Fees.ToString();
            DateLabel.Text = info.ApplicationDate.ToString();
            StatusDateLabel.Text = info.StatusDate.ToString();
            UserLabel.Text = info.CreatedByUserName;
            StatusLabel.Text = info.Status;
            TypeLabel.Text = info.ApplicationTypeTitle;
            ApplicantLabel.Text = info.ApplicantFullName;
        }


        public void SetUtility(ILicenseInformationUtility _LicenseInformationUtility)
        {
            this._LicenseInformationUtility = _LicenseInformationUtility;
        }
        public int PersonID()
        {
             return  _LicenseInformationUtility.GetPersonID();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Service = Program.ServiceProvider.GetRequiredService<IPersonCardUtility>();
            ThePersonInformationForm form = new ThePersonInformationForm(Service, _LicenseInformationUtility.GetPersonID());
            form.ShowDialog();
           
        }
    }


}