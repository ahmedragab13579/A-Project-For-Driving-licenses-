using DVDL_Business.After.Appointment;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.LocalDrivingLIcense.LocalDrivingLicense_View;
using DVDL_Business.After.Test;
using DVDL_Business.After.Users;
namespace FormsUtilities.Tests.TestForm
{
    public class TestInformationUtility : ITestInformationUtility
    {
        int AppointmentID;
        LocalDrivingLicenseApplication_ViewDto LocalDrivingLicenseApplication_ViewDto;
        private readonly ITestService _ITestService;
        private readonly ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService;
        private readonly IAppointmentService _AppointmentsService;

        public TestInformationUtility(ITestService _ITestService,
         ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService,
         IAppointmentService _AppointmentsService)
        {
            this._ITestService = _ITestService;
            this._LocalDrivingLicenseViewService = _LocalDrivingLicenseViewService; 
            this._AppointmentsService = _AppointmentsService;
            
        }

        public string ClassName()
        {
            return LocalDrivingLicenseApplication_ViewDto.ClassName;
        }

        public string FullName()
        {
            return LocalDrivingLicenseApplication_ViewDto.FullName;
        }

        public AppointmentDto GetAppointment(int id)
        {
            AppointmentID= id;
            return _AppointmentsService.GetById(id);
        }

        public void GetLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            LocalDrivingLicenseApplication_ViewDto = _LocalDrivingLicenseViewService.
                                GetByID(LocalDrivingLicenseApplicationID);
        }

        public int  SaveTheTestInfomation(string Notes,bool Pass)
        {
            TestDtos test = new TestDtos();
            test.Notes = Notes;
            test.TestResult = (Pass == true ? true : false);
            test.TestAppointmentID = AppointmentID;
            test.UserID = ClassCurrentUserInformation.CurrentUser.UserID;
            test.ID= _ITestService.Add(test);
            AppointmentDto appointment = _AppointmentsService.GetById(AppointmentID);
            appointment.IsLocked = true;
            _AppointmentsService.Update(appointment);
             return test.ID;
        }

      
        public void SetAppointmentId(int Id)
        {
            AppointmentID = Id;        }
    }
    }

