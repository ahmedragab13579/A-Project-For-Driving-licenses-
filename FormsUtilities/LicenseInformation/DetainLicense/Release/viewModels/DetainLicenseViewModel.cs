using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.DetainLicense.Release.viewModels
{
    public class DetainLicenseViewModel
    {
        public decimal AppFees { get; set; }
        public int DetainID { get; set; }
        public decimal DetainFees { get; set; }
        public int LicenseID { get; set; }
        public string User { get; set; }
        public DateTime DetainDate { get; set; }
    }
}
