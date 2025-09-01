using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.ChangeLicense.RenewDrivingLicense.Models
{
    public class RenewLicenseViewModel
    {
        public string RenewAppID { get; set; }
        public string AppDate { get; set; }
        public string NewLicenseIssueDate { get; set; }
        public string AppFees { get; set; }
        public string LicenseFees { get; set; }
        public string RenewLicenseID { get; set; }
        public string OldLicenseID { get; set; }
        public string ExpirationDate { get; set; }
        public string CreatedBy { get; set; }
        public string TotalFees { get; set; }
    }
}
