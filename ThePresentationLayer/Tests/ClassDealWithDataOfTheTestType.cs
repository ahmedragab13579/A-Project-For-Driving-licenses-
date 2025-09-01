using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;
using ThePusnissLayer.Appointments;

namespace ThePusnissLayer.Tests
{
    public class ClassDealWithDataOfTheTestType
    {
        //ref int TestAppointmentID,
        //  ref int TestID, ref bool TestResult, ref string Notes, ref int UserID
       
            enum EnumMode { Add = 1, Update = 2 }
        EnumMode Mode = EnumMode.Add;
        public int ID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int UserID { get; set; }



        public ClassDealWithDataOfTheTestType()
        {
            this.ID = 0;
            this.TestAppointmentID = 0;
            this.Notes = "";
            this.UserID = 0;
            this.TestResult = false;

        }

        public ClassDealWithDataOfTheTestType(int ID,int TestAppointmentID, string Notes, bool TestResult, int UserID)
        { 
            this.ID = ID;
            this.TestAppointmentID = TestAppointmentID;
            this.Notes = Notes;
            this.UserID = UserID;
            this.TestResult = TestResult;
             

        }

        public static DataTable PassAllTheTestData()
        {
            return ClassDataFromTheTestsType.TheTestsTypeData();
        }

        public static ClassTheTestTypeInformation FindTestByID(int ID)
        {
            decimal Fees = 0;
            string TestTypeTitle = "";
            string Description = "";

            if (ClassDataFromTheTestsType.FindTestByID(ref ID, ref TestTypeTitle,ref Description, ref Fees))
            {
                ClassTheTestTypeInformation Test = new ClassTheTestTypeInformation(ID, TestTypeTitle, Description, Fees);
                return Test;
            }
            else
            {
                return null;

            }

        }

        public static ClassDealWithDataOfTheTestType FindATestByAppointmentID(int ID)
        {
            int TestID = 0, TestAppointmentID = 0;bool Result = false; int UserID = 0;
            string Notes = "";
            if (ClassDataFromTheTest.GetATestAppointmentByID(ref ID, ref TestID, ref Result, ref Notes, ref UserID))
            {
                ClassDealWithDataOfTheTestType Application = new ClassDealWithDataOfTheTestType( TestAppointmentID,  ID,  Notes, Result,  UserID);
                return Application;
            }
            else
            {
                return null;

            }

        }

        public int AddNewTest()
        {

            ID = ClassDataFromTheTest.AddATest(TestAppointmentID,TestResult,Notes,UserID);

            return ID;
        }


       
        
        
        //private int UpdateTest()
        //{

        //    int numberwillupdate = ClassDataFromAppointments.UpdateAnAppointment(ID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);

        //    return numberwillupdate;
        //}



        //public int Save()
        //{
        //    int id = 0;
        //    switch (Mode)
        //    {

        //        case EnumMode.Add:
        //            id = AddNewAppointment();
        //            if (id != -1)
        //            {

        //                Mode = EnumMode.Update;

        //            }
        //            break;
        //        case EnumMode.Update:

        //            id = UpdateAppointment();
        //            if (id != -1)
        //            {

        //                Mode = EnumMode.Update;
        //            }
        //            break;

        //    }

        //    return id;
        //}


    }
}
