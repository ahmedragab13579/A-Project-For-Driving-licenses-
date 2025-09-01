using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer_For_Project.Models.Drivers
{
    public class DriverView
    {
        public string NationalNo { get; set; }
        public int PersonID { get; set; }
        public int DriverID { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int NumberOfActiveLicenses { get; set; }
    }

}

