using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.LocalLicense.ViewModels
{
    public class LocalLicenseViewModel
    {
        public int LocalLicenseID { get; set; }
        public string LicenseClassName { get; set; }
        public int PassedTestCount { get; set; }

        public int ApplicationID { get; set; }
        public decimal Fees { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime StatusDate { get; set; }
        public string Status { get; set; }

        public string CreatedByUserName { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public int PersonID { get; set; }
        public string ApplicantFullName { get; set; }
    }
}
