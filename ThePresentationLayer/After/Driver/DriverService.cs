using DVDL_Business.After.DTOs;
using System.Data;
using TheDataLayer_For_Project.Models.Drivers;
using TheDataLayer_For_Project.Repositories.Drivers;

namespace DVDL_Business.After.Driver
{
    public class DriverService : IDriverService
    {
        private readonly DriverRepository _repository;
        public DriverService()
        {
            _repository = new DriverRepository();
        }
        public int Add(DriverDto driver)
        {
            return _repository.Add(Map(driver));
        }

        public List<DriverViewDto> GetAll()
        {
            var drivers = new List<DriverViewDto>();
            foreach (var Driver in _repository.GetAll())
            {
                drivers.Add(Map(Driver));

            }
            return drivers;
        }

        public DriverDto GetById(int id)
        {
            return Map(_repository.GetById(id));
        }

        public DriverDto GetByPersonId(int personId)
        {
            return Map(_repository.GetByPersonId(personId));
        }

        private DriverDto Map(TheDataLayer_For_Project.Models.Driver.Driver driver)
        {
            return new DriverDto
            {
                ID = driver.ID,
                CreatedDate = driver.CreatedDate,
                CreatedByUserID = driver.CreatedByUserID,
                PersonID = driver.PersonID,

            };

        }

        private TheDataLayer_For_Project.Models.Driver.Driver Map(DriverDto driver)
        {
            return new TheDataLayer_For_Project.Models.Driver.Driver
            {
                ID = driver.ID,
                CreatedDate = driver.CreatedDate,
                PersonID = driver.PersonID,
                CreatedByUserID = driver.CreatedByUserID,

            };
        }

        private DriverViewDto Map(DriverView Driver)
        {
            return new DriverViewDto
            {
                DriverID=Driver.DriverID,
                CreatedDate=Driver.CreatedDate,
                FullName = Driver.FullName,
                NationalNo = Driver.NationalNo,
                PersonID=Driver.PersonID,
                NumberOfActiveLicenses = Driver.NumberOfActiveLicenses,

            };
        }

    }
}
