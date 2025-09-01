using DVDL_Business.After.DTOs;

namespace DVDL_Business.After.Test
{
    public interface ITestService
    {
        public TestDtos GetByAppointmentID(int TestDtosAppointmentID);
        public TestDtos GetByID(int id);
        public int Add(TestDtos TestDtos);
        public bool Update(TestDtos TestDtos);
    }
}
