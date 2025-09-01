using DVDL_Persentation.License_Information.ChangeLicense.Models;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.DetainLicense.Detain
{
    public interface IDetainLicenseUtility
    {
        IFindLicenserWithFilterUtility findLicenserWithFilterUtility();
         LicenseViewModel GetLicenseInfo(string licenseNo);

        string GetCurrentUserName();
        int LicenseID();
        bool IsDetained();
        int PrepareDetainLicese(string Fees);
    }
}
