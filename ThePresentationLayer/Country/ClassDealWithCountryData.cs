using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.Country
{
    public class ClassDealWithCountryData
    {
        public static DataTable PassAllCountryData()
        {
            DataTable data = ClassDataFromTheCountry.GetAllInformationFromTheCountry();
            return data;
        }
    }
}
