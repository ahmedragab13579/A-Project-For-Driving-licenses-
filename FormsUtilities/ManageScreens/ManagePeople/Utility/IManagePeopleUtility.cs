using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManagePeople.Utility
{
    public interface IManagePeopleUtility
    {
        DataTable LoadData();


        void Delete(int id);

         bool IsNumericColumnName(string ColumnName);


    }
}
