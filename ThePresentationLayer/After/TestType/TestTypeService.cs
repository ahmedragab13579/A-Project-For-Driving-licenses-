using DVDL_Business.After.DTOs;
using TheDataLayer_For_Project.Repositories.Tests;

namespace DVDL_Business.After.TestType
{
    public class TestTypeService : ITestTypeService
    {
        private readonly TestTypeRepository _TestTypeRepository;
        public TestTypeService()
        {
            _TestTypeRepository = new TestTypeRepository();

        }

        public List<TestTypeDtos> GetAll()
        {
            List<TestTypeDtos> countryDtos = new List<TestTypeDtos>();
            foreach (var Country in _TestTypeRepository.GetAll())
            {
                countryDtos.Add(Map(Country));
            }
            return countryDtos;
        }

        public TestTypeDtos GetByID(int id)
        {
            return Map(_TestTypeRepository.GetById(id));
        }

        public bool Update(TestTypeDtos testType)
        {
            return _TestTypeRepository.Update(MaptoTestType(testType));

        }
        private TestTypeDtos Map(TheDataLayer_For_Project.Models.Tests.TestType TestType)
        {
            return new TestTypeDtos
            {
                Id = TestType.Id,
                Title = TestType.Title,
                Description = TestType.Description,
                Fees = TestType.Fees
            };
        }
        private TheDataLayer_For_Project.Models.Tests.TestType MaptoTestType(TestTypeDtos TestType)
        {
            return new TheDataLayer_For_Project.Models.Tests.TestType
            {
                Id = TestType.Id,
                Title = TestType.Title,
                Description = TestType.Description,
                Fees = TestType.Fees
            };
        }
    }
}
