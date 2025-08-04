using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.Drivers
{
    public class ClassDealWithDataOfTheDrivers
    {
        public int PersonID;
        public int ID;
        public int CreatedByUserID;
        public DateTime CreatedDate;
         

        public ClassDealWithDataOfTheDrivers(int PersonID,
        int CreatedByUserID,
        DateTime CreatedDate)
        {
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            
        }
    
    
        public int AddDriver()
        {
            this.ID = ClassDataFromTheDrivers.AddDriver(this.PersonID,this.CreatedByUserID,this.CreatedDate);
            return this.ID;
        }
       
        public static DataTable PassAllTheDrivers()
        {
            return ClassDataFromTheDrivers.GetAllDriver();
        }
        public static ClassDealWithDataOfTheDrivers FindDriverByID(int ID)
        {
            int DriverID = 0, CreatedByUserID=0;
            DateTime CreateDate= DateTime.Now;
            if( ClassDataFromTheDrivers.GetDriverByPersonID( ref ID, ref DriverID, ref CreatedByUserID, ref CreateDate))
            {
                ClassDealWithDataOfTheDrivers Driver = new ClassDealWithDataOfTheDrivers(ID,CreatedByUserID,CreateDate);
                Driver.ID = DriverID;
                return Driver;

            }
            else
            {
                return null;
            }

        }
        
        public static ClassDealWithDataOfTheDrivers FindDriverByDriverID(int ID)
        {
            int PersonID = 0, CreatedByUserID=0;
            DateTime CreateDate= DateTime.Now;
            if( ClassDataFromTheDrivers.GetDriverByID( ref PersonID, ref ID, ref CreatedByUserID, ref CreateDate))
            {
                ClassDealWithDataOfTheDrivers Driver = new ClassDealWithDataOfTheDrivers(PersonID, CreatedByUserID,CreateDate);
                Driver.ID = ID;
                return Driver;

            }
            else
            {
                return null;
            }

        }


    }
}
