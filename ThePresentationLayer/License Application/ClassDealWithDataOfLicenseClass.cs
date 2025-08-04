using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.License_Application
{
    public class ClassDealWithDataOfLicenseClass
    {
        public static DataTable PassAllLicenseClassData()
        {
            DataTable data = ClassDataFromLicenseTypes.GetAllInformationFromTheTestsClass();
            return data;
        }

    }
}
