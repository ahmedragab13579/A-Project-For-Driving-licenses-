using DVDL_Business.After.Application;
using DVDL_Business.After.ApplicationType;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.LicenseType;
using DVDL_Business.After.People;
using DVDL_Business.After.Users;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;

namespace FormsUtilities.LicenseInformation.ChangeLicense.ChangeLicenseForLostOrDamage
{

    public class ChangeLicenseForLostOrDamageUtility: IChangeLicenseForLostOrDamage
    {
        int TypeId;
        LicenseDto License;
        string NationalNo="";
        private readonly IApplicationService _Application;
        private readonly IApplicationTypeService _ApplicationTypeService;
        private readonly IPersonService _PersonService;
        private readonly ILicenseTypeService _ILicenseTypeService;
        private readonly ILicenseService _ILicenseService;
        private IFindLicenserWithFilterUtility _FindLicenserWithFilterUtility;
   
        public ChangeLicenseForLostOrDamageUtility(IApplicationService _Application,IApplicationTypeService _ApplicationTypeService,
        IPersonService _PersonService,
        ILicenseTypeService _ILicenseTypeService, IFindLicenserWithFilterUtility _FindLicenserWithFilterUtility,
        ILicenseService _ILicenseService)
        {
            this._Application = _Application;
            this._ApplicationTypeService = _ApplicationTypeService;
            this._PersonService = _PersonService;
            this._ILicenseService = _ILicenseService;
            this._ILicenseTypeService= _ILicenseTypeService;
            this._FindLicenserWithFilterUtility= _FindLicenserWithFilterUtility;
            TypeId = 0;
            License = new LicenseDto();
        }

        public int AddLicense()
        {
            return _ILicenseService.Add(License);        }

        public decimal ApplicationFees(bool DamageChecked)
        {
            decimal fees = 0;
            if (DamageChecked == true)
            {
                fees = _ApplicationTypeService.GetById(4).Fees;
                TypeId = 4;
            }
            else
            {
                fees = _ApplicationTypeService.GetById(3).Fees;
                TypeId = 3;
            }
            return fees;
        }

        public string CurruntUserName()
        {
            return ClassCurrentUserInformation.CurrentUser.UserName;
        }



        public void DeactivatedTheOldLicense()
        {
            _ILicenseService.DeactivateLicense(License.ID);
        }

        public   IFindLicenserWithFilterUtility GetLicenserWithFilterUtility()
        {
            return _FindLicenserWithFilterUtility;
        }



   
        public void prepareTheNewApplication(string Fees)
        {
            NationalNo = _FindLicenserWithFilterUtility.GetNationalID();
            PersonDto person = _PersonService.GetByNationalId(NationalNo);
            _Application.Application.PersonID = person.PersonID;
            _Application.Application.Fees = decimal.Parse(Fees);
            _Application.Application.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
            _Application.Application.Type = TypeId;
            _Application.Application.ID = 0;
        }
        public bool IsActiveLicense()
        {

            return _ILicenseService.IsActive(License.ID);
        }

        public int SaveApplication()
        {
            return _Application.Save();
        }
        public void prepareTheNewLicense()
        {
            var LicenseType = _ILicenseTypeService.GetById(License.LicenseClass);
            var DefaultValidityLength = LicenseType.DefaultValidityLength;
            DateTime ExDate = DateTime.Now.AddYears(DefaultValidityLength);
            decimal ClassFees = LicenseType.ClassFees;

            License.ID = 0;
            License.ApplicationID=_Application.Application.ID;
            License.IssueReason = TypeId;
            License.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
            License.IssueDate=DateTime.Now;
            License.ExpirationDate = ExDate;
            License.Fees= ClassFees;
            License.IsActive = true;

        }

        public int GetLicenseID()
        {
            License = _FindLicenserWithFilterUtility.GetLicense();

            return License.ID;
        }

        public string NationalNumber()
        {
            return NationalNo;
        }
    }
}
