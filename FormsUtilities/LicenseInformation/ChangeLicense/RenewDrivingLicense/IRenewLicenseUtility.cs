using DVDL_Business.After.DOTs;
using DVDL_Business.After.DTOs;
using DVDL_Persentation.License_Information.ChangeLicense.Models;
using FormsUtilities.LicenseInformation.ChangeLicense.RenewDrivingLicense.Models;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.ChangeLicense.RenewDrivingLicense
{
    public interface IRenewLicenseUtility
    {

        void DeactivatedTheOldLicense();
        bool IsLicenseExpired();
        IFindLicenserWithFilterUtility GetLicenserWithFilterUtility();
        public int prepareTheNewApplication(string AppFees);
        public int prepareTheNewLicense(string Notes);
        string NationalID();
        RenewLicenseViewModel Create(ApplicationDtos application, LicenseDto license, string currentUserName, string oldLicenseID);  
           RenewLicenseViewModel FillTheInformationLabels();
        public LocalDrivingLicenseApplication_ViewDto GetLocalLicense(int ID);
   }
}
