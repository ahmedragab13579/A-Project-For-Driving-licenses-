using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.License.InternationalLicense
{
    public class ClassDealWithInternationalLicenseData
    {
        public int ID;
        public int ApplicationID;
        public int DriverID;
        public int IssueUsingLicalLicenseID;
        public DateTime IssueData;
        public DateTime ExpirationDate;
        public bool IsActive; 
        public int CreatedByuserID;

        public ClassDealWithInternationalLicenseData()
        {
            ID = 0;
            this.ApplicationID = 0;
            this.DriverID = 0;
            this.IssueData = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByuserID = 0;
            this.IssueUsingLicalLicenseID = 0;

        }
        public ClassDealWithInternationalLicenseData(int ID,int ApplicationID,
        int DriverID,
        int IssueUsingLicalLicenseID,
        DateTime IssueData,
        DateTime ExpirationDate,
        bool IsActive,
        int CreatedByuserID)
        {
            this.ID = ID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssueData = IssueData;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByuserID = CreatedByuserID;
            this.IssueUsingLicalLicenseID = IssueUsingLicalLicenseID;
            
        }


        public static DataTable PassAllInterNationalLicensesForOneDriver(int DriverID)
        {
            return ClassDataFromInternationalLicense .GetLicenseForDriverByDriverID(ref DriverID);
        }

        public static DataTable PassAllInternationalLicense()
        {
            return ClassDataFromInternationalLicense.TheInternationalLicense();
        }



        //public static ClassDealWithInternationalLicenseData FindInternationalLicenseByApplicationID(int ApplicationID)
        //{
        //    int ID = 0, DriverID = 0, CreatedByUserID, IssueUsingLicalLicenseID;
        //    DateTime IssueDate=DateTime.Now,ExpirationDate=DateTime.Now;
        //    bool IsActive = false;

        //    if(ClassDataFromInternationalLicense.)
        //    {

        //    }
        //    else
        //    {
        //        return null;
        //    }

        public static bool ISTheLicenseExist(int id)
        {
            return ClassDataFromInternationalLicense.ISTheLicenseExist(id);
        }

        public int AddTheInternationalLicense()
        {
            ID = ClassDataFromInternationalLicense.AddInternationalLicense(ApplicationID,DriverID,IssueUsingLicalLicenseID,IssueData,ExpirationDate,IsActive,CreatedByuserID);
            return ID;
        }
        }

    }

