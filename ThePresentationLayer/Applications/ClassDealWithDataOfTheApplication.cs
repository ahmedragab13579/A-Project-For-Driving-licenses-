using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.Applications
{
    public class ClassDealWithDataOfTheApplication
    {
        public static DataTable PassAllTheApplicationData()
        {
            return ClassDataFromApplicationTypes.TheApplicationData();
        }

        public static TheApplicationTypeInformation FindApplicationByID(int ID)
        {
            decimal Fees = 0;
            string ApplicationTypeTitle = "";

            if (ClassDataFromApplicationTypes.FindApplicationByID(ref ID,ref ApplicationTypeTitle,ref Fees))
            {
                TheApplicationTypeInformation Application = new TheApplicationTypeInformation(ID,ApplicationTypeTitle,Fees);
                return Application;
            }
            else
            {
                return null;

            }

        }








    }


}
