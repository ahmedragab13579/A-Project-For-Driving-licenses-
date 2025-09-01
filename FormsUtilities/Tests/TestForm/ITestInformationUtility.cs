using DVDL_Business.After.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.Tests.TestForm
{
    public interface ITestInformationUtility
    {
        AppointmentDto GetAppointment(int id);
        void GetLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID);
        string ClassName();
        string FullName();
        int SaveTheTestInfomation(string Notes, bool Pass);
        void SetAppointmentId(int Id);

    }
}
