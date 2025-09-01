using FormsUtilities.PersonInformation.PersonCard;
using System.Data;


namespace FormsUtilities.LicenseInformation.LocalLicense.AddDrivingLicense
{
    public interface IAddDrivingLIcenseUtility
    {
        DataTable GetData();
        bool IsPersonHasTheSameLicense(string NationalNo, string LicenseClass);
        decimal ApplicationFees(int ApplicationId);
       int   SaveToTheLocalLicenseApplications(int PersonID, string ApplicationFees, string LicenseClass);
        int SaveTheApplication(int PersonID, string ApplicationFees);
        public IPersonCardUtility PersonCardUtility();

        string GetUserName();
    }
}
