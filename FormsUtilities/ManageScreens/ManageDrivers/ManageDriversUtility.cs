using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_InfrastructureLayer;
using FormsUtilities.ManageScreens.ManagePeople.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManageDrivers
{
    public class ManageDriversUtility: IManageDriversUtility
    {
        IDriverService _DriverService;
        DataTable Drivers =null;
        public ManageDriversUtility(IDriverService _DriverService)
        {
            this._DriverService = _DriverService;
        }

        public void LoadData()
        {
            Drivers = ChangeDataType.ToDataTable(_DriverService.GetAll());
        }
    
        public DataTable FillTheDrivers()
        {
            return Drivers;  
        }

        public int FillTheRecords()
        {
            return Drivers.Rows.Count; 
        }

    
        

        public bool IsNumericColumnName(string ColumnName)
        {
            if (ColumnName == "PersonID" ||
                ColumnName == "DriverID" ||
                ColumnName == "NumberOfActiveLicenses")
                return true;
            return false;
        }

    }
}
