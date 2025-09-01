using DVDL_Business.After.TestType;
using DVDL_InfrastructureLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManageTestType
{
    public class ManageTestTypeUtility : IManageTestTypeUtility
    {
        private readonly ITestTypeService _TestTypeService;
        DataTable TestsData;
        public ManageTestTypeUtility(ITestTypeService _TestTypeService)
        {
            this._TestTypeService = _TestTypeService;
            TestsData=new DataTable();
        }



        public DataTable GetData()
        {
            return TestsData;        }

        public void LoadData()
        {
            TestsData =ChangeDataType. ToDataTable( _TestTypeService.GetAll());        }

        public int RecordesNumber()
        {
            return TestsData.Rows.Count;        }
    }
}
