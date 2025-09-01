using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDataLayer_For_Project.Models.Driver;

namespace FormsUtilities.ManageScreens.ManageDrivers
{
    public interface IManageDriversUtility
    {
        DataTable FillTheDrivers();

        void LoadData();
         int FillTheRecords();

         bool IsNumericColumnName(string ColumnName);

        
    }
}
