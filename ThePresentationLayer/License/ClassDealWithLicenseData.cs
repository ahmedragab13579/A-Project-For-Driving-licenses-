using System;
using System.Data;
using System.Text;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.License
{
    public class ClassDealWithLicenseData
    {
        public int DriverID { get; private set; }
        public int LicenseClass { get; private set; }
        public int ID { get; private set; }
        public int IssueReason { get; private set; }
        public int ApplicationID { get; private set; }
        public int CreatedByUserID { get; private set; }
        public DateTime IssueDate { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public string Notes { get; private set; }
        public bool IsActive { get; private set; }
        public decimal Fees { get; private set; }

        public ClassDealWithLicenseData(
            int LicenseID,
            int driverID,
            int LicenseClass,
            int issueReason,
            int applicationID,
            int createdByUserID,
            DateTime issueDate,
            DateTime expirationDate,
            string notes,
            bool isActive,
            decimal fees)
        {
            ID = LicenseID;
            DriverID = driverID;
           this. LicenseClass = LicenseClass;
            IssueReason = issueReason;
            ApplicationID = applicationID;
            CreatedByUserID = createdByUserID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            IsActive = isActive;
            Fees = fees;
        }


        public static DataTable PassAllLicenseForTheDriver(int DriverID)
        {
            return ClassDataFromTheLicense.GetLicenseForDriverByDriverID( ref DriverID);
        }
        public static ClassDealWithLicenseData FindLicenseByApplicationID(int ApplicationID)
        {
            int DriverId = 0, LicenseClass = 0, IssueReason = 0, LicenseID = 0, CreatedByUserID = 0;
            bool IsActive = false;
            DateTime issueDate=DateTime.Now, expirationDate=DateTime.Now;
            string Notes = "";
            decimal Fees = 0;
            if(ClassDataFromTheLicense.GetLicenseByApplicationid(ApplicationID, ref LicenseID,ref LicenseClass,ref DriverId,
              ref issueDate,ref expirationDate,ref Notes,ref Fees,ref IsActive,ref IssueReason,ref CreatedByUserID))
            {
                ClassDealWithLicenseData License = new ClassDealWithLicenseData(ApplicationID, LicenseID, LicenseClass, DriverId, ApplicationID, CreatedByUserID, issueDate, expirationDate, Notes, IsActive, Fees);
                return License;
            }
            return null;
        }
        public static ClassDealWithLicenseData FindLicenseByID(int LicenseID)
        {
            int DriverId = 0, LicenseClass = 0, IssueReason = 0, ApplicationID = 0, CreatedByUserID = 0;
            bool IsActive = false;
            DateTime issueDate=DateTime.Now, expirationDate=DateTime.Now;
            string Notes = "";
            decimal Fees = 0;
            if(ClassDataFromTheLicense.GetLicenseByID(ref LicenseID, ref ApplicationID, ref LicenseClass,ref DriverId,
              ref issueDate,ref expirationDate,ref Notes,ref Fees,ref IsActive,ref IssueReason,ref CreatedByUserID))
            {
                ClassDealWithLicenseData License = new ClassDealWithLicenseData(LicenseID,DriverId,LicenseClass,IssueReason,ApplicationID,CreatedByUserID,issueDate,expirationDate,Notes,IsActive,Fees);
                return License;
            }
            return null;
        }
        public int AddLicense()
        {
            ID = ClassDataFromTheLicense.AddLicense(
                ApplicationID,
                LicenseClass,
                DriverID,
                IssueDate,
                ExpirationDate,
                Notes,
                Fees,
                IsActive,
                IssueReason,
                CreatedByUserID
            );

            return ID;
        }
        
        public static void  DeactivateTheOldLicense(int ID)
        {
            ClassDataFromTheLicense.DeactivatetheOldLicense(ID);
        }
        
        public static bool ISActive(int id)
        {
            return ClassDataFromTheLicense.IsActive(id);
        }
    
    }
}
