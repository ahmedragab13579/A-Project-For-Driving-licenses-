using DVDL_Persentation.License_Information.ChangeLicense.Models;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.InternationalLicense.InternationalLicense
{
    public interface IInternationalLicenseUtility
    {
        bool IsValidText(string Text);
        IFindLicenserWithFilterUtility findLicenserWithFilterUtility();
        int GetLocalDrivingLicenseApplicationID();
        int GetLocalDrivingLicenseID();
        LicenseViewModel GetLicenseInfo();
        public bool AddInternationalLicense();
        public ILicenseInformationUtility LicenseInformation();
        void PrepareTheLicense(string id);
        bool IsLicenseOrdenaryDrivingLicense();

    }
}
