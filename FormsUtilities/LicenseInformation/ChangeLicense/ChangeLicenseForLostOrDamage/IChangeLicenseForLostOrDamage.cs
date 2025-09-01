using DVDL_Business.After.DTOs;
using DVDL_Persentation.License_Information.ChangeLicense.Models;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.ChangeLicense.ChangeLicenseForLostOrDamage
{
    public interface IChangeLicenseForLostOrDamage
    {

        void DeactivatedTheOldLicense();
        public IFindLicenserWithFilterUtility GetLicenserWithFilterUtility();
        string CurruntUserName();

        void prepareTheNewApplication(string Fees);
        void prepareTheNewLicense();
        decimal ApplicationFees(bool DamageChecked);
        public int SaveApplication();
        bool IsActiveLicense();

        int GetLicenseID();
        string NationalNumber();

        int AddLicense();
    }
}
