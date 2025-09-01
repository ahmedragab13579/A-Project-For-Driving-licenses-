using DVDL_Business.After.User;
using DVDL_InfrastructureLayer;
using System.Data;
using System.Reflection;


namespace FormsUtilities.ManageScreens.ManageUsers
{
    public class ManageUsersUtility : IManageUsersUtility
    {
        IUserService _UserService;
        DataTable UsersDataTable;
        public ManageUsersUtility(IUserService _UserService)
        {
            this._UserService = _UserService;   
            UsersDataTable=new DataTable();
            
        }

        public DataView MakeIsActiveFilter(string TheFilterVariable, bool TheFilter)
        {
            DataView TheFilterData = UsersDataTable.DefaultView;

               TheFilterData.RowFilter = $"{TheFilterVariable} = {TheFilter}";
         
            return TheFilterData;
        }

        public void LoadData()
        {
            UsersDataTable = ChangeDataType.ToDataTable(_UserService.GetAll())
            ?? throw new Exception("No data returned from UserService.");
        }


        public DataTable GetData()
        {
            if (UsersDataTable == null)
                LoadData();
            return UsersDataTable;  
        }

        public void Delete(int id)
        {
            _UserService.Delete(id);        }

        public List<string> AddAllFilters()
        {
            List<string> Filters= new List<string>();
            Filters.Add("None");
            foreach (var Column in UsersDataTable.Columns)
            {
                Filters.Add(Column.ToString());

            }
            return Filters;
        }

        public int FillRecordes()
        {
            return UsersDataTable.Rows.Count;
        }
    }
}
