using DVDL_Business.After.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.Appointments.AppointmentInformation
{
    public interface IAppointmentInformationUtility
    {
        LocalDrivingLicenseApplication_ViewDto LicenseView();
        AppointmentDto appointmentDto();
        decimal ApplicationFees();
        int MaketheRetakeTestApplication();
        int FillTheAppointmentInfomationAfterWriteToAddorUpdate(DateTime AppointmentDate, string Fees);
        int Mode();
        void SetAppointmentInformation(int LocalId,int testTypeID,int Mode);
    }
}
