using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.Applications.LocalLisense
{
    public class ClassDealWithDataOfTheLocalLicenseApplication
    {
        public static DataTable PassAllTheLocalLicenseApplicationData()
        {
            return ClassdataFromLocalLicenseApplication.TheLocalLicenseApplicationData();
        }
        public static DataRow PassRowFromTheLocalLicenseApplicationData(int id)
        {
            return ClassdataFromLocalLicenseApplication.RowFromLicenseApplicationData(id);
        }

        public static ClassLocalLicenseApplicationInfomation FindApplicationByID(int ID)
        {
            int ApplicationID = 0, LicenseClassID = 0;
            if (ClassdataFromLocalLicenseApplication.GetLocalLicenseApplicationById(ref ID,ref  ApplicationID,ref LicenseClassID))
            {
                ClassLocalLicenseApplicationInfomation Application = new ClassLocalLicenseApplicationInfomation(ID, ApplicationID, LicenseClassID);
                return Application;
            }
            else
            {
                return null;

            }

        }
       
        public static ClassLocalLicenseApplicationInfomation FindApplicationByApplicationID(int ApplicationID)
        {
            int ID = 0, LicenseClassID = 0;
            if (ClassdataFromLocalLicenseApplication.GetLocalLicenseApplicationByApplicationId(ref ApplicationID,ref ID, ref LicenseClassID))
            {
                ClassLocalLicenseApplicationInfomation Application = new ClassLocalLicenseApplicationInfomation(ID, ApplicationID, LicenseClassID);
                return Application;
            }
            else
            {
                return null;

            }

        }

        public static bool IsTheLicenseExist(string NationalNo,string Classtype)
        {
            return ClassdataFromLocalLicenseApplication.ISTheLicenseExist(NationalNo,Classtype);
        }
    }
}
