using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;
using ThePusnissLayer.Applications;

namespace ThePusnissLayer.Appointments
{
    public class ClassDealWithAppointmentData
    {
      
        enum EnumMode { Add = 1, Update = 2 }
        EnumMode Mode = EnumMode.Add;
        public int ID { get; set; }
        public int TestTypeID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
     



        public ClassDealWithAppointmentData()
        {
            this.ID = 0;
            this.TestTypeID = 0;
            this.AppointmentDate = DateTime.Now;
            this.IsLocked = false;
            this.CreatedByUserID = 0;
            this.LocalDrivingLicenseApplicationID = 0;
            this.PaidFees = 0;


        }

        public ClassDealWithAppointmentData(int ID,int TestTypeID, DateTime AppointmentDate,
            int LocalDrivingLicenseApplicationID, decimal PaidFees, 
            int CreatedByUserID, bool IsLocked)
        {
            this.ID = ID;
            this.TestTypeID = TestTypeID;
            this.AppointmentDate = AppointmentDate;
            this.IsLocked = IsLocked;
            this.CreatedByUserID = CreatedByUserID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.PaidFees = PaidFees;
            Mode=EnumMode.Update;
          
        }


        public static DataTable PassAllAppointmentData(int LocalID)
        {
            return ClassDataFromAppointments.TheAppointmentData(LocalID);
        }
        public static bool IsAppointmentExist(int LocalID,int Type )
        {
            return ClassDataFromAppointments.IsAppointmentExist(LocalID,Type);
        }
        public static bool IsAppointmentActive(int LocalID,int Type )
        {
            return ClassDataFromAppointments.IsAppointmentActive(LocalID,Type);
        }
        

        public static DataRow AppointmentRow(int Id)
        {
            return ClassDataFromAppointments.TheAppointmentRowData(Id);

        }
        
        public static DataRow AppointmentRow(int LocalId,int TestType)
        {
            return ClassDataFromAppointments.TheAppointmentRowData(LocalId, TestType);

        }


       
        public static ClassDealWithAppointmentData FindAppointmentByID(int ID)
        {
            int AppID = 0, TestTypeID = 0, LocalID = 0, UserID = 0;
            decimal fees = 0;
            DateTime AppDate= DateTime.Now;
            bool IsLocked = false;
            if (ClassDataFromAppointments.GetAnAppointmentByID(ref ID, ref TestTypeID,ref LocalID, ref AppDate, ref fees, ref UserID, ref IsLocked))
            {
                ClassDealWithAppointmentData Application = new ClassDealWithAppointmentData( ID,  TestTypeID,  AppDate, LocalID, fees,  UserID,  IsLocked);
                return Application;
            }
            else
            {
                return null;

            }

        }

       
        private int AddNewAppointment()
        {

            ID = ClassDataFromAppointments.AddAnAppointment(TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees, CreatedByUserID, IsLocked);

            return ID;
        }


        private int UpdateAppointment()
        {

            int numberwillupdate = ClassDataFromAppointments.UpdateAnAppointment(ID,TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);

            return numberwillupdate;
        }



        public int Save()
        {
            int id = 0;
            switch (Mode)
            {

                case EnumMode.Add:
                    id = AddNewAppointment();
                    if (id != -1)
                    {

                        Mode = EnumMode.Update;

                    }
                    break;
                case EnumMode.Update:

                    id = UpdateAppointment();
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
