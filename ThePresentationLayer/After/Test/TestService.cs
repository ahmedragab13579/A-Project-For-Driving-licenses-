using DVDL_Business.After.DTOs;
using TheDataLayer_For_Project.Repositories.Tests;

namespace DVDL_Business.After.Test
{
    public class TestService : ITestService
    {
        private readonly TestRepository _TestReposotiory;

        public TestService()
        {
            _TestReposotiory = new TestRepository();
        }
        public int Add(TestDtos TestDtos)
        {
            return _TestReposotiory.Add(MaptoTest(TestDtos));
        }

        public TestDtos GetByAppointmentID(int TestDtosAppointmentID)
        {
            return Map(_TestReposotiory.GetByAppointmentID(TestDtosAppointmentID));
        }

        public TestDtos GetByID(int id)
        {
            return Map(_TestReposotiory.GetByID(id));
        }

        public bool Update(TestDtos TestDtos)
        {
            return _TestReposotiory.Update(MaptoTest(TestDtos));
        }


        private TestDtos Map(TheDataLayer_For_Project.Models.Tests.Test Test)
        {
            return new TestDtos
            {
                ID = Test.ID,
                TestAppointmentID = Test.TestAppointmentID,
                TestResult = Test.TestResult,
                Notes = Test.Notes,
                UserID = Test.UserID,


            };
        }
        private TheDataLayer_For_Project.Models.Tests.Test MaptoTest(TestDtos TestType)
        {
            return new TheDataLayer_For_Project.Models.Tests.Test
            {
                ID = TestType.ID,
                TestAppointmentID = TestType.TestAppointmentID,
                TestResult = TestType.TestResult,
                Notes = TestType.Notes,
                UserID = TestType.UserID,


            };
        }
    }
}
