using DVDL_Business.After.DTOs;
using DVDL_Persentation.License_Information.ChangeLicense.Models;
using FormsUtilities.LicenseInformation.DetainLicense.Release.viewModels;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.DetainLicense.Release
{
    public interface IReleaseLicenseUtility
    {
        public int LicenseID();
        public bool IsDetained();
        int PerpareTheApplication(string Fees);
        void PrepareRelaseDetain(string ApplicationID);
        IFindLicenserWithFilterUtility findLicenserWithFilterUtility();
        public DetainLicenseViewModel GetDetainLicenseInfo();
         void FillTheDetainInfo();
    }
}
    
    