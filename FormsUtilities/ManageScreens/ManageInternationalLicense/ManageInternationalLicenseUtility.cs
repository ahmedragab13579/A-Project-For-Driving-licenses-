using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.InternationalLicense;
using DVDL_Business.After.License;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.LocalDrivingLIcense.LocalDrivingLicense_View;
using DVDL_Business.After.People;
using DVDL_InfrastructureLayer;
using System.Data;


namespace FormsUtilities.ManageScreens.ManageInternationalLicense
{
    public class ManageInternationalLicenseUtility: IManageInternationalLicenseUtility
    {
        IDriverService _DriverService;
        IPersonService _PersonService;
        IInternationalService _InternationalService;
        ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService;
        ILocalDrivingLicenseService localDrivingLicenseService;
        ILicenseService licenseService;
        DataTable InternationalLicenses;
        public ManageInternationalLicenseUtility(ILicenseService licenseService,ILocalDrivingLicenseService localDrivingLicenseService,IDriverService _DriverService, ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService,
        IPersonService _PersonService,
        IInternationalService _InternationalService)
        {
            this._DriverService = _DriverService;
            this._PersonService = _PersonService;
            this._LocalDrivingLicenseViewService = _LocalDrivingLicenseViewService;
            this._InternationalService=_InternationalService;
            this.licenseService = licenseService;
            this.localDrivingLicenseService = localDrivingLicenseService;
            InternationalLicenses=new DataTable();
        }

        public DataTable GetData()
        {
            return InternationalLicenses;        }

        private DriverDto GetDriver(int id)
        {
            return _DriverService.GetById(id);      
        }
        public LocalDrivingLicenseApplication_ViewDto GetLocalDrivingLicense(int id)
        {
            int Localid = LocalLicenseApplicationID(id);
            return _LocalDrivingLicenseViewService.GetByID(Localid);
        }
        private int LocalLicenseApplicationID(int LocalLIcensId)
        {
            int ApplicationID = licenseService.GetById(LocalLIcensId).ApplicationID;
            int LocalLIcensApplicationID = localDrivingLicenseService.GetByApplicationID(ApplicationID).ID;
            return LocalLIcensApplicationID;
        }
        public int PersonID(int id)
        {
            return GetDriver(id).PersonID;
        }
    
        public string PersonNationalNo(int id)
        {
            return GetPerson(GetDriver(id).PersonID).NationalNo;
        }
        private PersonDto GetPerson(int id)
        {
            return _PersonService.GetById(id);
        }


        public void LoadData()
        {
            InternationalLicenses =ChangeDataType.ToDataTable(_InternationalService.GetAll());
        }
        public bool IsNumcericalCoulumn(string name)
        {
            if (name == "ID" || name == "ApplicationID" || name == "DriverID" || name == "IssueUsingLicalLicenseID" || name == "CreatedByuserID")
            {
                return true;
            }
            return false;
        }

        public int RecordesNumber()
        {
            return InternationalLicenses.Rows.Count;        }
    }
}
