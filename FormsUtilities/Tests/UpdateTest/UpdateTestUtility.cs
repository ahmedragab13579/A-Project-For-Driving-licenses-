using DVDL_Business.After.DTOs;
using DVDL_Business.After.TestType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.Tests.UpdateTest
{
    public class UpdateTestUtility: IUpdateTestUtility
    {
        TestTypeDtos Test;

        private readonly ITestTypeService _TestTypeService;
        public UpdateTestUtility(ITestTypeService _TestTypeService)
        {
            this._TestTypeService = _TestTypeService;   
        }

        public bool IsValidInputs(string Title,string Fees,string Description)
        {
            bool isValid = true;
            if (Title == string.Empty)
            {
                isValid = false;

            }
            if (Fees == string.Empty)
            {
                isValid = false;

            }
            if (Description == string.Empty)
            {
                isValid = false;

            }
            return isValid;
        }

        public TestTypeDtos GetTestType(int id)
        {
            Test = _TestTypeService.GetByID(id);
            return Test;
        }

        public void FillTheTestInformationAfterUpdate(string Fees,string Description)
        {
            Test.Fees = int.Parse(Fees);
            Test.Description = Description;
            _TestTypeService.Update(Test);
        }

    }
}
