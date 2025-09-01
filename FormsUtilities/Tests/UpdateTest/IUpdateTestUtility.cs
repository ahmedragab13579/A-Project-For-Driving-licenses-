using DVDL_Business.After.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.Tests.UpdateTest
{
    public interface IUpdateTestUtility
    {
        bool IsValidInputs(string Title, string Fees, string Description);

        TestTypeDtos GetTestType(int id);

        void FillTheTestInformationAfterUpdate(string Fees, string Description);
    }
}
