using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;
using ThePusnissLayer.People;

namespace ThePusnissLayer.Applications
{
    public class ApplicationsInformation
    {

        public enum EnumMode { Add = 1, Update = 2 }
        public EnumMode Mode = EnumMode.Add;
        public int ID { get; set; }
        public int PersonID { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; }
        public int StatusID { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal Fees { get; set; }
        public int CreatedByUserID { get; set; }





        public ApplicationsInformation()
        {
            this.ID = 0;
            this.PersonID = 0;
            this.StatusID = 0;
            this.LastStatusDate = DateTime.Now;
            this.Fees = 0;
            this.CreatedByUserID = 0;
            this.Date = DateTime.Now;
            this.Type = 0;




        }

        public ApplicationsInformation(int PersonID, DateTime Date,int Type,int StatusIDDateTime,DateTime LastStatusDate,decimal Fees,int CreatedByUserID)
        {
            this.PersonID = PersonID;
            this.StatusID = StatusID;
            this.LastStatusDate = LastStatusDate;
            this.Fees = Fees;
            this.CreatedByUserID = CreatedByUserID;
            this.Date = Date;
            this.Type= Type;
            this.Mode= EnumMode.Update;
        }
        


        public static DataTable PassAllDataFromTheApplication()
        {
            return ClassDataFromApplication.TheApplicationsData();
        }

        public static ApplicationsInformation FindApplicationByID(int ID)
        {
            int PersonID=0,  CreatedByUserID = 0, Type = 0;
            byte StatusID = 0;
            decimal Fees = 0;
            DateTime Date=DateTime.Now, LastDate= DateTime.Now;
            if (ClassDataFromApplication.GetApplicationById(ref ID, ref PersonID,ref Date,ref Type,ref StatusID,ref LastDate,ref Fees,ref CreatedByUserID))
            {
                ApplicationsInformation Application = new ApplicationsInformation(PersonID, Date, Type, StatusID, LastDate, Fees, CreatedByUserID);
                Application.ID = ID;
                return Application;
            }
            else
            {
                return null;

            }

        }
        
        public static int CancelAnApplication(int applicationID)
        {
            return ClassDataFromApplication.CancelAnApplication(applicationID);

        }


        public static bool DeleteApplication(int id)
        {
            int number = ClassDataFromApplication.DeleteApplicartionInfo(id);
            return number != 0;
        }


        private int AddNewApplication()
        {

            ID = ClassDataFromApplication.AddApplication(   PersonID,  Date,  Type,  StatusID,  LastStatusDate,  Fees,  CreatedByUserID);

            return ID;
        }


        private int UpdateApplication()
        {

            int numberwillupdate = ClassDataFromApplication.UpdateApplication( ID,  PersonID,  Date,  Type,  StatusID,  LastStatusDate,  Fees,  CreatedByUserID);

            return numberwillupdate;
        }

     

        public int Save()
        {
            int id = 0;
            switch (Mode)
            {

                case EnumMode.Add:
                    id = AddNewApplication();
                    if (id != -1)
                    {

                        Mode = EnumMode.Update;

                    }
                    break;
                case EnumMode.Update:

                    id = UpdateApplication();
                    if (id != -1)
                    {

                        Mode = EnumMode.Update;
                    }
                    break;

            }

            return id;
        }


    }
}
