using DVDL_Business.After.Application;
using DVDL_Business.After.ApplicationType;
using DVDL_Business.After.Appointment;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.LocalDrivingLIcense.LocalDrivingLicense_View;
using DVDL_Business.After.People;
using DVDL_Business.After.Users;

namespace FormsUtilities.Appointments.AppointmentInformation
{
    public class AppointmentInformationUtility: IAppointmentInformationUtility
    {
        int LocalID;
        int UpdateMode;
        int TestTypeID;
        AppointmentDto Appointment;
        IApplicationTypeService _ApplicationTypeService;
        IApplicationService _ApplicationService;
        ILocalDrivingLicenseViewService _LoaclDrivingLicenseViewService;
        IPersonService _PersonService;
        private readonly IAppointmentService _AppointmentsService;

        public AppointmentInformationUtility(IApplicationTypeService _ApplicationTypeService,
        IApplicationService _ApplicationService,
        ILocalDrivingLicenseViewService _LoaclDrivingLicenseViewService,
        IPersonService _PersonService,
        IAppointmentService _AppointmentsService)
        {
            this._ApplicationTypeService = _ApplicationTypeService;
            this._ApplicationService = _ApplicationService;
            this._LoaclDrivingLicenseViewService= _LoaclDrivingLicenseViewService;
            this._PersonService = _PersonService;
            this._ApplicationService= _ApplicationService;
            this._AppointmentsService = _AppointmentsService;
            Appointment = new AppointmentDto();
        }
    
        
      
        public int  MaketheRetakeTestApplication()
        {
            var row = _LoaclDrivingLicenseViewService.GetByID(LocalID);
            PersonDto person = _PersonService.GetByNationalId(row.NationalNo.ToString());
            var Apptype = _ApplicationTypeService.GetById(6);

            _ApplicationService.Application.PersonID = person.PersonID;
            _ApplicationService.Application.Type = 6;
            _ApplicationService.Application.StatusID = 1;
            _ApplicationService.Application.Fees = Apptype.Fees;
            _ApplicationService.Application.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
          return  _ApplicationService.Save();

        }
        public void SetAppointmentInformation(int LocalId, int testTypeID, int Mode)
        {
            LocalID = LocalId;
            TestTypeID = testTypeID;
            UpdateMode = Mode;
        }
        public LocalDrivingLicenseApplication_ViewDto LicenseView()
        {
            return _LoaclDrivingLicenseViewService.GetByID(LocalID);
        }

        public AppointmentDto appointmentDto()
        {
            Appointment = _AppointmentsService.GetByLocalAndType(LocalID,TestTypeID);
            return Appointment;       
        }
        public int Mode()
        {
            return UpdateMode;        }
        private void FillTheAppointmentInfomationAfterWriteToUpdate(DateTime AppointmentDate)
        {

            Appointment = new AppointmentDto
            {
                ID = Appointment.ID,
                TestTypeID = Appointment.TestTypeID,
                AppointmentDate = AppointmentDate,
                LocalDrivingLicenseApplicationID = Appointment.LocalDrivingLicenseApplicationID,
                CreatedByUserID = Appointment.CreatedByUserID,
                IsLocked = Appointment.IsLocked,
                PaidFees = Appointment.PaidFees
            };
        }
        public decimal ApplicationFees()
        {
            return _ApplicationTypeService.GetById(6).Fees;
        }
        public int FillTheAppointmentInfomationAfterWriteToAddorUpdate(DateTime AppointmentDate,string Fees)
        {
            if (UpdateMode == -1)
            {
                Appointment.TestTypeID = TestTypeID;
                Appointment.LocalDrivingLicenseApplicationID = LocalID;
                Appointment.AppointmentDate = AppointmentDate;
                Appointment.IsLocked = false;
                Appointment.PaidFees = decimal.Parse(Fees);
                Appointment.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
                return _AppointmentsService.Add(Appointment);

            }
            else
            {
                FillTheAppointmentInfomationAfterWriteToUpdate(AppointmentDate);
                 _AppointmentsService.Update(Appointment);

            }
            return Appointment.ID;

        }
    }
}
