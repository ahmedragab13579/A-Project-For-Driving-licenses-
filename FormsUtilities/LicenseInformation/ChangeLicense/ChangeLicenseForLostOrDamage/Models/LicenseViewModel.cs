using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_Persentation.License_Information.ChangeLicense.Models
{
    public class LicenseViewModel
    {
        public string LicenseId { get; set; }
        public string DriverId { get; set; }
        public string PersonName { get; set; }
        public string NationalId { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public string Notes { get; set; }
        public string ExpirationDate { get; set; }
        public string IssueDate { get; set; }
        public string DateOfBirth { get; set; }
        public bool IsActive { get; set; }
    }
}
