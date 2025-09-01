using DVDL_Business.After.DTOs;

namespace DVDL_Business.After.Driver
{
    public interface IDriverService
    {
        public List<DriverViewDto> GetAll();
        public DriverDto GetById(int id);
        public DriverDto GetByPersonId(int personId);
        public int Add(DriverDto driver);
    }
}
