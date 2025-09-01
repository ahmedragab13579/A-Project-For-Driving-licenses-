using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;
using static System.Net.Mime.MediaTypeNames;

namespace ThePusnissLayer.License.DetainLicenses
{
    public class ClassDealWithDetainLicenses
    {

  
        public int LicenseID { get;  set; }
        public decimal FineFees { get;  set; }
        public int ID { get;  set; }
        public int User { get;  set; }
        public bool IsRelesd { get;  set; }
        public int RelaisByuser { get;  set; }
        public DateTime Date { get;  set; }
        public DateTime RelaseDate { get;  set; }
        public int RelaisAppID { get;  set; }



        public ClassDealWithDetainLicenses(int LicenseID,decimal Fees,int ID,int User,
            bool IsRelesd,int RelaisByuser,DateTime Date,DateTime RelaisDate,int RelaisAppID)
        {
            this.LicenseID = LicenseID;
            this.RelaseDate= RelaseDate;
            this.Date = Date;
            this.LicenseID= LicenseID;
           this.User = User;
            this.ID = ID;
            this.FineFees = Fees;
            this.RelaisAppID = RelaisAppID;
            this.RelaisByuser = RelaisByuser;
            
        }

        public ClassDealWithDetainLicenses(int LicenseID,decimal Fees,int User, DateTime Date,
            bool IsRelesd)
        {
            this.LicenseID = LicenseID;
            this.Date = Date;
            this.LicenseID= LicenseID;
           this.User = User;
            this.FineFees = Fees;
            
        }


    
        public static ClassDealWithDetainLicenses FindLicenseByID(int LicenseID)
        {
            int lID = 0, ID = 0, user = 0, RelaseUser = 0, RelaseAppID = 0;
            DateTime date = DateTime.Now,RelaisDate=DateTime.Now;
            bool isrelase = false;
            decimal Fees = 0;

            if (ClassDataFromDetainLiceses.GetDetainLicenseByLicenseID(ref LicenseID,ref ID,ref Fees,ref date,ref user,ref isrelase,ref RelaisDate, ref RelaseUser, ref RelaseAppID))
            {
                ClassDealWithDetainLicenses License = new ClassDealWithDetainLicenses(LicenseID,Fees,ID,user,isrelase,RelaseUser,date,RelaisDate,RelaseAppID);
                return License;
            }
            return null;
        }


        public int AddLicense()
        {
            ID = ClassDataFromDetainLiceses.AddDetainLicense(LicenseID, FineFees, Date, User, IsRelesd
               
            );

            return ID;
        }
        public bool UpdateLicense()
        {

            return ClassDataFromDetainLiceses.UpdateDetainLicense(ID, IsRelesd, RelaseDate, RelaisByuser, RelaisAppID);
        }


        public static bool ISDetain(int id)
        {
            return ClassDataFromDetainLiceses.IsDetain(id);
        }


        public static DataTable PassAllTheDetainedLicenses()
        {
            return ClassDataFromDetainLiceses.TheDetainedLicenses();
        }
    }
}
