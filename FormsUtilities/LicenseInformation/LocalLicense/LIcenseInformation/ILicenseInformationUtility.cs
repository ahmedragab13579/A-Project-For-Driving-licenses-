using DVDL_Business.After.DTOs;
using DVDL_Persentation.License_Information.ChangeLicense.Models;
using FormsUtilities.LicenseInformation.LocalLicense.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation
{
    public interface ILicenseInformationUtility
    {
        int GetPersonID(); 
        string PersonImagePath();

        LocalLicenseViewModel GetLocalLicenseInfo(int localLicenseId);
        LicenseViewModel GetLicenseInfo(string licenseNo);
        public string IssueReason(int id);
    }
}
