using DVDL_Business.After.People;
using DVDL_InfrastructureLayer;
using FormsUtilities.ManageScreens.ManagePeople.Model;
using System.Data;
using System.Reflection;

namespace FormsUtilities.ManageScreens.ManagePeople.Utility
{
    public class ManagePeopleUtility : IManagePeopleUtility
    {
        private readonly IPersonService _personService;
     
        private static readonly HashSet<string> NumericColumns = new() { "PersonID", "Gendor", "NationalityCountryID" };
    
        private  DataTable DataTableOfThePeople=null;

        public ManagePeopleUtility(IPersonService _personService)
        {
           this. _personService=_personService;
        }
    
        public   DataTable LoadData()
        {
           
            DataTableOfThePeople = ChangeDataType.ToDataTable(_personService.GetAll());
          return DataTableOfThePeople;
        }


        public void Delete(int id)
        {
            _personService.Delete(id);
            DataTableOfThePeople = null;
            LoadData(); 
        }

        public bool IsNumericColumnName(string columnName) =>
            NumericColumns.Contains(columnName);
    }
}
