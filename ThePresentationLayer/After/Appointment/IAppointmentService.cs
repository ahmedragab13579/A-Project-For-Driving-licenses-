using DVDL_Business.After.DTOs;

namespace DVDL_Business.After.Appointment
{
    public interface IAppointmentService
    {
        public List<AppointmentDto> GetAllByLocalId(int localId);
        public AppointmentDto GetById(int id);
        public AppointmentDto GetByLocalAndType(int localId, int testTypeId);
        public bool IsAppointmentExist(int localId, int testTypeId);
        public bool IsAppointmentActive(int localId, int testTypeId);

        public int Add(AppointmentDto appointment);
        public bool Update(AppointmentDto appointment);



    }
}
