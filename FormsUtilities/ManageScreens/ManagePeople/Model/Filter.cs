using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManagePeople.Model
{
    public class Filter
    {
        public DataTable Table { get; set; }
        public string ColumnName { get; set; }
        public string FilterParameter { get; set; }
    }
}
