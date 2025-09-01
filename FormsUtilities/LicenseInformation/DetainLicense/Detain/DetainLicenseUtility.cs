using DVDL_Business.After.DetainLicense;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.Users;
using DVDL_Persentation.License_Information.ChangeLicense.Models;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;

namespace FormsUtilities.LicenseInformation.DetainLicense.Detain
{
    public class DetainLicenseUtility: IDetainLicenseUtility
    {
        DetainLicenseDto DetainLicenses;
        LicenseDto License;
    
        IDetainLicenseService _DetainLicenseService;
        IFindLicenserWithFilterUtility _FindLicenserWithFilterUtility;

        public DetainLicenseUtility(
       
        IDetainLicenseService _DetainLicenseService,
     
        IFindLicenserWithFilterUtility _FindLicenserWithFilterUtility)
        {
           License=new LicenseDto();
         
            this._DetainLicenseService = _DetainLicenseService;
            this._FindLicenserWithFilterUtility= _FindLicenserWithFilterUtility;
        }

     
         public bool IsDetained()
        {
            License = _FindLicenserWithFilterUtility.GetLicense();
            return _DetainLicenseService.IsDetained(License.ID);

        }

        public string GetCurrentUserName()
        {
            return ClassCurrentUserInformation.CurrentUser.UserName;
        }

         public int PrepareDetainLicese(string Fees)
        {
            DetainLicenses = new DetainLicenseDto
            {
                LicenseID = License.ID,
                FineFees = decimal.Parse(Fees),
                User = ClassCurrentUserInformation.CurrentUser.UserID,
                Date = DateTime.Now,
                IsRelesd = false

            };
          return _DetainLicenseService.Add(DetainLicenses);
        }

        public IFindLicenserWithFilterUtility findLicenserWithFilterUtility()
        {
            return _FindLicenserWithFilterUtility;     
        }

        public int LicenseID()
        {
            return License.ID;
        }

        public LicenseViewModel GetLicenseInfo(string licenseNo)
        {
            throw new NotImplementedException();
        }
    }
}
