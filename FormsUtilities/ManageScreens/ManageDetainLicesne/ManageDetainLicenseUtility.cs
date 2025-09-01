using DVDL_Business.After.DetainLicense;
using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.LocalDrivingLIcense.LocalDrivingLicense_View;
using DVDL_Business.After.People;
using DVDL_InfrastructureLayer;
using System.Data;


namespace FormsUtilities.ManageScreens.ManageDetainLicesne
{
    public class ManageDetainLicenseUtility : IManageDetainLicenseUtility
    {
        IDetainLicenseService _DetainLicenseService;
        IDriverService _DriverService;
        ILicenseService _ILicenseService;
        ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService;
        IPersonService _PersonService;
        List<DetainLicenseDto> detainLicenseDtos;
        DataTable licenseDataTable;
        public ManageDetainLicenseUtility(IDetainLicenseService _DetainLicenseService,
                                    IDriverService _DriverService,
                                    ILicenseService _ILicenseService,
                                    ILocalDrivingLicenseViewService _LocalDrivingLicenseService,
                                    IPersonService _PersonService)
        {
            this._DetainLicenseService = _DetainLicenseService;
            this._DriverService = _DriverService;
            this._ILicenseService = _ILicenseService;
            this._LocalDrivingLicenseViewService = _LocalDrivingLicenseService;
            this._PersonService = _PersonService;
            licenseDataTable = new DataTable();
            detainLicenseDtos = new List<DetainLicenseDto>();
        }

        public List<DetainLicenseDto> FillTheDetainLicenseData()
        {
            return detainLicenseDtos;
        }

        public int FillTheRecordesNumber()
        {
            return detainLicenseDtos.Count;
        }

        public DriverDto GetDriverById(int id)
        {
            return _DriverService.GetById(id);//<--;
        }

        public LicenseDto GetLicenseById(int id)
        {
            return _ILicenseService.GetById(id);//<--;
        }

        public LocalDrivingLicenseApplication_ViewDto GetLocalDrivingLicenseById(int id)
        {
            return _LocalDrivingLicenseViewService.GetByID(id);
        }

        public PersonDto GetPersonById(int id)
        {
            return _PersonService.GetById(id);
        }

        public bool IsNumericalColumn(string Text)
        {
            if (Text == "LicenseID" || Text == "ID" || Text == "User" || Text == "RelaisByUser" || Text == "RelaisAppID")
            {
                return true;
            }
            return false;
        }

        public void LoadData()
        {
            detainLicenseDtos = _DetainLicenseService.GetAll();
            licenseDataTable = ChangeDataType.ToDataTable(detainLicenseDtos);
        }
        public DataTable GetData()
        {
            return licenseDataTable;
        }
    }
}
