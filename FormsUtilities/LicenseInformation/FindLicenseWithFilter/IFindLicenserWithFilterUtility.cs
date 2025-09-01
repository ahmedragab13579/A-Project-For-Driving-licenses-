using DVDL_Business.After.DTOs;
using DVDL_Persentation.License_Information.ChangeLicense.Models;

namespace FormsUtilities.LicenseInformation.FindLicenseWithFilter
{
    public interface IFindLicenserWithFilterUtility
    {
        bool IsValidText(string Text);
        bool IsActive(string LicenseID);
        string PersonImagePath();
        bool IsDetained();
        LicenseDto GetLicense();
        void SetNationalID(string NationalID);
        string GetNationalID();
        LicenseViewModel GetLicenseInfo(string licenseNo);
   
    }
}
