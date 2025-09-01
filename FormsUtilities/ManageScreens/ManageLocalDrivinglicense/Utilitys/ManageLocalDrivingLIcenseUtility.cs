using DVDL_Business.After.Application;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.LocalDrivingLIcense.LocalDrivingLicense_View;
using FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Status.Model;
using FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Status.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Utilitys
{
    public class ManageLocalDrivingLIcenseUtility : IManageLocalDrivingLIcenseUtility
    {
        IApplicationService _ApplicationService;
        ILocalDrivingLicenseService _LocalDrivingLicenseService;
        ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService;
        IManageLocalDrivingLicenseStatus _ManageLocalDrivingLicenseStatus;
        ILicenseService _LicenseService;
        DataTable _LocalDrivingLicenseDataTable;
        public ManageLocalDrivingLIcenseUtility(IApplicationService _ApplicationService,
        ILocalDrivingLicenseService _LocalDrivingLicenseService,
        ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService,
        IManageLocalDrivingLicenseStatus _ManageLocalDrivingLicenseStatus,
        ILicenseService _LicenseService)
        {
            this._ApplicationService = _ApplicationService;
            this._LocalDrivingLicenseService = _LocalDrivingLicenseService;
            this._LocalDrivingLicenseViewService = _LocalDrivingLicenseViewService;
            this._ManageLocalDrivingLicenseStatus = _ManageLocalDrivingLicenseStatus;
            this._LicenseService=_LicenseService;
            _LocalDrivingLicenseDataTable=new DataTable();
        }
        public List<string> AddAllFilters()
        {
            List<string> filters = new List<string>();
          filters.Add("None");
          filters.Add("LocalDrivingLicenseApplicationID");
          filters.Add("NationalNo");
          filters.Add("FullName");
            filters.Add("Status");
            return filters; 
        }

        public int ApplicationID(int ApplicationId)
        {
            return _LocalDrivingLicenseService.GetByID(ApplicationId).ApplicationID;      }

        public bool CancelApplication(int ApplicationId)
        {
           return   _ApplicationService.Cancel(ApplicationId);
        }

        public bool DeleteApplication(int ApplicationId)
        {
            return _LocalDrivingLicenseService.Delete(ApplicationId);
        }

        public bool DeleteLocalApplication(int ApplicationId)
        {
            return _LocalDrivingLicenseService.Delete(ApplicationId);
        }

        public int FillRecoreds()
        {
            return _LocalDrivingLicenseDataTable.Rows.Count;        }

        public DataTable GetData()
        {
            return _LocalDrivingLicenseDataTable;        }

        public LocalDrivingLicenseApplication_ViewDto GetLocalDrivingLicense(int id)
        {
            return _LocalDrivingLicenseViewService.GetByID(id);        }

        public LocalLIcenseStatus GetState(int passedTestCount, string status)
        {
            return _ManageLocalDrivingLicenseStatus.GetState(passedTestCount, status); }

        public void LoadData()
        {
            _LocalDrivingLicenseDataTable = _LocalDrivingLicenseService.GetAll();        }

        public int LocalDrivingLicenseID(int LocalDrivingLicenseApplicationID)
        {
            LocalDrivingLicenseDto LocalApp = _LocalDrivingLicenseService.GetByID(LocalDrivingLicenseApplicationID);
            LicenseDto LocalLicense= _LicenseService.GetByApplicationId(LocalApp.ApplicationID);
            return LocalLicense.ID;

        }


    }
}
