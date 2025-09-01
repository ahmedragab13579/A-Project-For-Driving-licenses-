using DVDL_Business.After.Application;
using DVDL_Business.After.DOTs;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.LicenseType;
using DVDL_Business.After.LocalDrivingLIcense.LocalDrivingLicense_View;
using DVDL_Business.After.People;
using DVDL_Business.After.Users;
using FormsUtilities.LicenseInformation.ChangeLicense.RenewDrivingLicense.Models;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;

namespace FormsUtilities.LicenseInformation.ChangeLicense.RenewDrivingLicense
{
    public class RenewLicenseUtility : IRenewLicenseUtility
    {
        private readonly IApplicationService _Application;
        private readonly IFindLicenserWithFilterUtility _FindLicenserWithFilterUtility;
        private readonly ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService;
        private readonly IPersonService _PersonService;
        private readonly ILicenseTypeService _ILicenseTypeService;
        private readonly ILicenseService _ILicenseService;
        LicenseDto License;
        public RenewLicenseUtility(IApplicationService _Application, IFindLicenserWithFilterUtility _FindLicenserWithFilterUtility,
        ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService,
        IPersonService _PersonService,
        ILicenseTypeService _ILicenseTypeService,
        ILicenseService _ILicenseService)
        {
            this._Application = _Application;
           this._FindLicenserWithFilterUtility= _FindLicenserWithFilterUtility;
            this._PersonService = _PersonService;
            this._ILicenseService = _ILicenseService;
            this._LocalDrivingLicenseViewService = _LocalDrivingLicenseViewService;
            this._ILicenseTypeService = _ILicenseTypeService;
            License=new LicenseDto();
        }
        
        public int  prepareTheNewApplication(string Fees)
        {
            PersonDto person = _PersonService.GetByNationalId(_FindLicenserWithFilterUtility.GetNationalID());
            _Application.Application.PersonID = person.PersonID;
            _Application.Application.Fees = decimal.Parse(Fees);
            _Application.Application.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
            _Application.Application.Type = 5;
            _Application.Application.ID = 0;
           return _Application.Save();
        }

        public int prepareTheNewLicense(string Notes)
        {
            var LicenseType = _ILicenseTypeService.GetById(License.LicenseClass);
            var DefaultValidityLength = LicenseType.DefaultValidityLength;
            DateTime ExDate = DateTime.Now.AddYears(DefaultValidityLength);
            decimal ClassFees = LicenseType.ClassFees;

            License.ID = 0;
            License.ExpirationDate = ExDate;
            License.Fees = ClassFees;
            License.Notes = (string.IsNullOrEmpty(Notes) ?null: Notes);
          return  _ILicenseService.Add(License);
        
        }
        public void DeactivatedTheOldLicense()
        {
            _ILicenseService.DeactivateLicense(License.ID);
        }
        public bool IsLicenseExpired()
        {
            DateTime expDate = License.ExpirationDate;
            return DateTime.Now > expDate;
        }
    

        public RenewLicenseViewModel FillTheInformationLabels()
        {
            License = _FindLicenserWithFilterUtility.GetLicense();
            var vm = Create(
                _Application.FindById(License.ApplicationID),
                License,
                ClassCurrentUserInformation.CurrentUser.UserName,
                License.ID.ToString()
            );
            return vm;
        }

        public RenewLicenseViewModel Create(ApplicationDtos application, LicenseDto license, string currentUserName, string oldLicenseID)
        {
            return new RenewLicenseViewModel
            {
                RenewAppID = application.ID.ToString(),
                AppDate = application.Date.ToString("dd/MM/yyyy"),
                NewLicenseIssueDate = application.Date.ToString("dd/MM/yyyy"),
                AppFees = application.Fees.ToString(),
                LicenseFees = license.Fees.ToString(),
                RenewLicenseID = license.ID.ToString(),
                OldLicenseID = oldLicenseID,
                ExpirationDate = license.ExpirationDate.ToString("dd/MM/yyyy"),
                CreatedBy = currentUserName,
                TotalFees = (application.Fees + license.Fees).ToString()
            };
        }
        public LocalDrivingLicenseApplication_ViewDto GetLocalLicense(int ID)
        {
            return _LocalDrivingLicenseViewService.GetByID(ID);
        }

        public IFindLicenserWithFilterUtility GetLicenserWithFilterUtility()
        {
            return _FindLicenserWithFilterUtility;
        }

        public string NationalID()
        {
            return _FindLicenserWithFilterUtility.GetNationalID();
        }
    }
}
