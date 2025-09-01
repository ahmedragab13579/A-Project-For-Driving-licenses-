using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUtilities.ManageScreens.ManageUsers
{
    public interface IManageUsersUtility
    {
        DataView MakeIsActiveFilter(string TheFilterVariable, bool TheFilter);
        void LoadData();
        DataTable GetData();
        void Delete(int id);
        int FillRecordes();
        List<string> AddAllFilters();

    }
}
