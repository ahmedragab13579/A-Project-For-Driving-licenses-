using DVDL_Business.After.Application;
using DVDL_Business.After.ApplicationType;
using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.LicenseType;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.LocalDrivingLIcense.LocalDrivingLicense_View;
using DVDL_Business.After.People;
using DVDL_Business.After.User;
using DVDL_Persentation.License_Information.ChangeLicense.Models;
using FormsUtilities.LicenseInformation.LocalLicense.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation
{
    public class LicenseInformationUtility: ILicenseInformationUtility
    {
        public int PersonID;
        public int LocalLicenseID;
        IDriverService _DriverService;
        ILicenseService _ILicenseService;
        private IApplicationService _ApplicationService;
        private IApplicationTypeService _ApplicationTypeService;
        private ILocalDrivingLicenseService _LocalDrivingLicenseService;
        private ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService;
        IPersonService _PersonService;
        IUserService _UserService;
        ILicenseTypeService licenseTypeService;
        string ImagePath = "";
        public LicenseInformationUtility(IApplicationService _ApplicationService,
         IApplicationTypeService _ApplicationTypeService,
         ILocalDrivingLicenseService _LocalDrivingLicenseService,
         ILocalDrivingLicenseViewService _LocalDrivingLicenseViewService,
        IPersonService _PersonService, 
        IDriverService _DriverService,
        ILicenseService _ILicenseService,
        ILicenseTypeService licenseTypeService,
        IUserService _UserService)
        {
            this._ApplicationService = _ApplicationService;
            this._ApplicationTypeService = _ApplicationTypeService;
            this._LocalDrivingLicenseViewService = _LocalDrivingLicenseViewService;
            this._LocalDrivingLicenseService = _LocalDrivingLicenseService;
            this._PersonService= _PersonService;
            this._UserService = _UserService;
            this._DriverService = _DriverService;
            this._ILicenseService = _ILicenseService;
            this.licenseTypeService = licenseTypeService;
        }
        public LocalLicenseViewModel GetLocalLicenseInfo(int localLicenseId)
        {
            var localApplication = _LocalDrivingLicenseService.GetByID(localLicenseId);
            var row = _LocalDrivingLicenseViewService.GetByID(localApplication.ID);
            var app = _ApplicationService.FindById(localApplication.ApplicationID);
            var user = _UserService.GetById(app.CreatedByUserID);
            var appType = _ApplicationTypeService.GetById(app.Type);
            var person = _PersonService.GetById(app.PersonID);
            ImagePath = person.ImagePath;
            PersonID = person.PersonID;

            return new LocalLicenseViewModel
            {
                LocalLicenseID = localApplication.ID,
                LicenseClassName = row.ClassName,
                PassedTestCount = row.PassedTestCount,
                ApplicationID = app.ID,
                Fees = app.Fees,
                ApplicationDate = app.Date,
                StatusDate = app.LastStatusDate,
                Status = row.Status.ToString(),
                CreatedByUserName = user.UserName,
                ApplicationTypeTitle = appType.Title,
                PersonID = person.PersonID,
                ApplicantFullName = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}"
            };
        }
        public LicenseDto GetDrivingLicense(string Id)
        {
            return _ILicenseService.GetById(int.Parse(Id));
        }
        public DriverDto GetDriver(int ID)
        {
            return _DriverService.GetById(ID);
        }
        public PersonDto GetPerson(int ID)
        {
            return _PersonService.GetById(ID);
        }

        public LicenseViewModel GetLicenseInfo(string licenseNo)
        {
            var license = GetDrivingLicense(licenseNo);
            if (license == null) return null;

            var driver = GetDriver(license.DriverID);
            var person = GetPerson(driver.PersonID);

            return new LicenseViewModel
            {
                LicenseId = license.ID.ToString(),
                DriverId = license.DriverID.ToString(),
                PersonName = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}",
                NationalId = person.NationalNo,
                Gender = person.Gendor == 1 ? "Male" : "Female",
                Class = license.LicenseClass.ToString(),
                Notes = string.IsNullOrWhiteSpace(license.Notes) ? "No Notes" : license.Notes,
                ExpirationDate = license.ExpirationDate.ToString(),
                IssueDate = license.IssueDate.ToString(),
                DateOfBirth = person.DateOfBirth.ToString(),
                IsActive = license.IsActive
            };
        }
     
        public string IssueReason(int id)
        {
            return licenseTypeService.GetById(id).ClassName.ToString();
        }
        public int GetPersonID()
        {
            return PersonID;        }
        public string PersonImagePath()
        {
            return ImagePath;
        }
    }
}
