using DVDL_Business.After.DTOs;
using TheDataLayer_For_Project.Repositories.Appointments;

namespace DVDL_Business.After.Appointment
{
    public class AppointmentService : IAppointmentService
    {
        private readonly AppointmentRepository _AppointmentRepository;
        public AppointmentService()
        {
            _AppointmentRepository = new AppointmentRepository();
        }
        public int Add(AppointmentDto appointment)
        {
            return _AppointmentRepository.Add(Map(appointment));
        }

        public List<AppointmentDto> GetAllByLocalId(int localId)
        {
            List<AppointmentDto> appointmentDtos = new List<AppointmentDto>();
            foreach (var i in _AppointmentRepository.GetAllByLocalId(localId))
            {
                appointmentDtos.Add(Map(i));

            }
            return appointmentDtos;
        }

        public AppointmentDto GetById(int id)
        {
            return Map(_AppointmentRepository.GetById(id));
        }

        public AppointmentDto GetByLocalAndType(int localId, int testTypeId)
        {
            return Map(_AppointmentRepository.GetByLocalAndType(localId, testTypeId));
        }

        public bool IsAppointmentActive(int localId, int testTypeId)
        {
            return _AppointmentRepository.IsAppointmentActive(localId, testTypeId);
        }

        public bool IsAppointmentExist(int localId, int testTypeId)
        {
            return _AppointmentRepository.IsAppointmentExist(localId, testTypeId);
        }

        public bool Update(AppointmentDto appointment)
        {
            return _AppointmentRepository.Update(Map(appointment));
        }

        private TheDataLayer_For_Project.Models.Appointment.Appointment Map(AppointmentDto appointment)
        {
            return new TheDataLayer_For_Project.Models.Appointment.Appointment
            {
                ID = appointment.ID,
                AppointmentDate = appointment.AppointmentDate,
                CreatedByUserID = appointment.CreatedByUserID,
                IsLocked = appointment.IsLocked,
                LocalDrivingLicenseApplicationID = appointment.LocalDrivingLicenseApplicationID,
                PaidFees = appointment.PaidFees,
                TestTypeID = appointment.TestTypeID,


            };

        }
        private AppointmentDto Map(TheDataLayer_For_Project.Models.Appointment.Appointment appointment)
        {
            return new AppointmentDto
            {
                ID = appointment.ID,
                AppointmentDate = appointment.AppointmentDate,
                CreatedByUserID = appointment.CreatedByUserID,
                IsLocked = appointment.IsLocked,
                LocalDrivingLicenseApplicationID = appointment.LocalDrivingLicenseApplicationID,
                PaidFees = appointment.PaidFees,
                TestTypeID = appointment.TestTypeID,
            };

        }


    }
}
