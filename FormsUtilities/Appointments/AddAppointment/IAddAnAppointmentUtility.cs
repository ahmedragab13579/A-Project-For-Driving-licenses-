using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.Appointments.AddAppointment
{
    public interface IAddAnAppointmentUtility
    {

         enum AppointmentActionResult { NewAppointmentAllowed=1, RetestAllowed=2, AlreadyPassed=3, HasActiveAppointment =4};

        ILicenseInformationUtility licenseInformationUtility();
         AppointmentActionResult CanScheduleAppointment(int localLicenseId, int type);

        void LoadData(int LocalID);
        DataTable GetData();

        int RecordsNumber();

        bool IsPassTheTest(int LocalLicenseID, int Type);
        bool IsTheAppointmentIsExist(int LocalLicenseID, int Type);
        bool IsTheAppointmentIsActive(int LocalLicenseID, int Type);


    }
}
