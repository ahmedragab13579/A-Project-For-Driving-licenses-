using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project;

namespace ThePusnissLayer.Applications.LocalLisense
{
    public class ClassLocalLicenseApplicationInfomation
    {
        enum EnumMode { Add = 1, Update = 2 }
        EnumMode Mode = EnumMode.Add;
        public int ID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }


        public ClassLocalLicenseApplicationInfomation()
        {

            this.ID = 0;
            this.ApplicationID = 0;
            this.LicenseClassID = 0;

        }

        public ClassLocalLicenseApplicationInfomation(int ID,int ApplicationID,int LicenseClassID)
        {
          this.ID = ID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            Mode=EnumMode.Update;
        }



        private int AddNewLocalLicenseApplication()
        {

            ID = ClassdataFromLocalLicenseApplication.AddLocalLicenseApplication(ApplicationID,LicenseClassID);

            return ID;
        }


        private int UpdateLocalLicenseApplication()
        {

            int numberwillupdate = ClassdataFromLocalLicenseApplication.UpdateLocalLicenseApplicationInfo(ID, ApplicationID, LicenseClassID);

            return numberwillupdate;
        }


        public static bool DeleteLocalLicenseApplication(int id)
        {
            int number = ClassdataFromLocalLicenseApplication.DeleteApplicationInfo(id);
            return number != 0;
        }



        public int Save()
        {
            int id = 0;
            switch (Mode)
            {

                case EnumMode.Add:
                    id = AddNewLocalLicenseApplication();
                    if (id != -1)
                    {

                        Mode = EnumMode.Update;

                    }
                    break;
                case EnumMode.Update:

                    id = UpdateLocalLicenseApplication();
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
