using DVDL_Business.After.Appointment;
using DVDL_Business.After.Test;
using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using System.Data;

namespace FormsUtilities.Appointments.AddAppointment
{
    public class AddAnAppointmentUtility: IAddAnAppointmentUtility
    {
        private readonly IAppointmentService _AppointmentsService;
        private ILicenseInformationUtility _licenseInformationUtility;
        private readonly ITestService _TestService;
        DataTable _AppointmentData;
        public AddAnAppointmentUtility(ILicenseInformationUtility _licenseInformationUtility,IAppointmentService _AppointmentsService, ITestService _TestService)
        {
            this._AppointmentsService = _AppointmentsService;
            this._TestService = _TestService;
            this._licenseInformationUtility = _licenseInformationUtility;
            _AppointmentData= new DataTable();
        }



        public    ILicenseInformationUtility licenseInformationUtility()
        {
            return _licenseInformationUtility;
        }
        public IAddAnAppointmentUtility.AppointmentActionResult CanScheduleAppointment(int localLicenseID, int type)
        {
        
            if (!IsTheAppointmentIsExist(localLicenseID, type))
                return IAddAnAppointmentUtility.AppointmentActionResult.NewAppointmentAllowed;

            if (IsTheAppointmentIsActive(localLicenseID, type))
                return IAddAnAppointmentUtility.AppointmentActionResult.HasActiveAppointment;

            if (!IsPassTheTest(localLicenseID, type))
                return IAddAnAppointmentUtility.AppointmentActionResult.RetestAllowed;

            return IAddAnAppointmentUtility.AppointmentActionResult.AlreadyPassed;
        
        }
            

        public DataTable GetData()
        {
            return _AppointmentData;  
        }

        public bool IsPassTheTest(int LocalLicenseID,int Type)
        {
            var row = _AppointmentsService.GetByLocalAndType(LocalLicenseID, Type);
            if (row == null) return false;

            if (row.ID != 0 && int.TryParse(row.ID.ToString(), out int id))
            {
                var test = _TestService.GetByAppointmentID(id);
                return test != null && test.TestResult == true;
            }

            return false;
        }

        public bool IsTheAppointmentIsActive(int LocalLicenseID, int Type)
        {
            return _AppointmentsService.IsAppointmentActive(LocalLicenseID, Type);
        }

        public bool IsTheAppointmentIsExist(int LocalLicenseID, int Type)
        {
            return _AppointmentsService.IsAppointmentExist(LocalLicenseID, Type);
        }

        public void LoadData(int LocalID)
        {
            _AppointmentData =ChangeDataType. ToDataTable(_AppointmentsService.GetAllByLocalId(LocalID));
            if (_AppointmentData.Rows.Count > 0)
            {
                _AppointmentData = _AppointmentData.DefaultView.ToTable(false, "ID", "AppointmentDate", "PaidFees", "IsLocked");
            }
        }

        public int RecordsNumber()
        {
            return _AppointmentData.Rows.Count;
        }

    
    }
}
