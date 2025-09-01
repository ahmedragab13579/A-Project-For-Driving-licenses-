using DVDL_Business.After.DTOs;

namespace DVDL_Business.After.TestType
{
    public interface ITestTypeService
    {
        public List<TestTypeDtos> GetAll();
        public TestTypeDtos GetByID(int id);
        public bool Update(TestTypeDtos testType);
    }
}
