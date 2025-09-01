using DVDL_Business.After.Application;
using DVDL_Business.After.ApplicationType;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.LicenseType;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.Users;
using DVDL_InfrastructureLayer;
using FormsUtilities.PersonInformation.PersonCard;
using System.Data;
using System.Reflection;

namespace FormsUtilities.LicenseInformation.LocalLicense.AddDrivingLicense
{
    public class AddDrivingLIcenseUtility: IAddDrivingLIcenseUtility
    {
        int ApplicationID;
        LocalDrivingLicenseDto LocalLicenseApplication;
        IApplicationService _Application;
        IApplicationTypeService _ApplicationType;
        ILocalDrivingLicenseService _LocalDrivingLicenseService;
        ILicenseTypeService _LicenseTypeService;
        IPersonCardUtility _PersonCardUtility;
        DataTable LicenseTypeDataTabel;

        public AddDrivingLIcenseUtility(IApplicationService _Application,
        IApplicationTypeService _ApplicationType,
        ILocalDrivingLicenseService _LocalDrivingLicenseService,
        ILicenseTypeService _LicenseTypeService, IPersonCardUtility _PersonCardUtility)
        {
            this._Application = _Application;
            this._ApplicationType= _ApplicationType;
            this._LocalDrivingLicenseService= _LocalDrivingLicenseService;
            this._LicenseTypeService= _LicenseTypeService;
            this._PersonCardUtility= _PersonCardUtility;
            LocalLicenseApplication=new LocalDrivingLicenseDto();
            LicenseTypeDataTabel = new DataTable();
            
        }

        private void LoadData()
        {
            LicenseTypeDataTabel =ChangeDataType.ToDataTable(_LicenseTypeService.GetAll());
        }
        public DataTable GetData()
        {
            LoadData();
            return LicenseTypeDataTabel;
        }
        public decimal ApplicationFees(int ApplicationId)
        {
            ApplicationID=ApplicationId;
            var Application = _ApplicationType.GetById(ApplicationID);
            return Application.Fees;
        }
        public int SaveTheApplication(int PersonID,string ApplicationFees)
        {
            var Application = _ApplicationType.GetById(ApplicationID);

            _Application.Application.PersonID = PersonID;
            _Application.Application.Date = DateTime.Now;
            _Application.Application.Type = Application.ID;
            _Application.Application.LastStatusDate = DateTime.Now;
            _Application.Application.Fees = decimal.Parse(ApplicationFees);
            _Application.Application.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
            _Application.Application.StatusID = 1;
            int ID = _Application.Save();
            return ID;

        }

        public IPersonCardUtility PersonCardUtility()
        {
            return _PersonCardUtility;
        }
        public int SaveToTheLocalLicenseApplications(int PersonID, string ApplicationFees, string LicenseClass)
        {
            LocalLicenseApplication.ApplicationID = SaveTheApplication(PersonID,ApplicationFees);
            LocalLicenseApplication.LicenseClassID = int.Parse(LicenseClass);
            return _LocalDrivingLicenseService.Add(LocalLicenseApplication);
        }
        public bool IsPersonHasTheSameLicense(string NationalNo,string LicenseClass)
        {
            return _LocalDrivingLicenseService.IsLicenseExist(NationalNo, LicenseClass);
        }

        public string GetUserName()
        {
            return ClassCurrentUserInformation.CurrentUser.UserName;        }
    }
}
