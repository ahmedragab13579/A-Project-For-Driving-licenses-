using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.InternationalLicense;
using DVDL_Business.After.License;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.People;
using DVDL_Business.After.Users;
using DVDL_Persentation.License_Information.ChangeLicense.Models;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using TheDataLayer_For_Project.Models.Licenses;


namespace FormsUtilities.LicenseInformation.InternationalLicense.InternationalLicense
{
    public class InternationalLicenseUtility: IInternationalLicenseUtility
    {
        LicenseDto LocalLicense;
        IDriverService _DriverService;
        IPersonService _PersonService;
        IInternationalService _InternationalService;
        ILicenseService _ILicenseService;
        ILicenseInformationUtility _LicenseInformationUtility;
        ILocalDrivingLicenseService _LocalDrivingLicenseService;
        IFindLicenserWithFilterUtility _FindLicenserWithFilterUtility;
        public InternationalLicenseUtility(IDriverService _DriverService,
        IPersonService _PersonService, IFindLicenserWithFilterUtility _FindLicenserWithFilterUtility,
        IInternationalService _InternationalService,
        ILicenseService _ILicenseService,
        ILocalDrivingLicenseService _LocalDrivingLicenseService, ILicenseInformationUtility _LicenseInformationUtility)
        {
            this._DriverService = _DriverService;
            this._PersonService = _PersonService;
            this._ILicenseService = _ILicenseService;
            this._InternationalService= _InternationalService;
            this._LicenseInformationUtility = _LicenseInformationUtility;
            this._LocalDrivingLicenseService = _LocalDrivingLicenseService;
            this._FindLicenserWithFilterUtility= _FindLicenserWithFilterUtility;
            LocalLicense = new LicenseDto();
        }




        public bool IsValidText(string Text)
        {

            if (Text.Length == 0)
                if (!int.TryParse(Text, out int licenseId))
                    return false;
            return true;
        }
        public LicenseViewModel GetLicenseInfo()
        {
            if (LocalLicense == null) return null;

            var driver = GetDriver(LocalLicense.DriverID);
            var person = GetPerson(driver.PersonID);

            return new LicenseViewModel
            {
                LicenseId = LocalLicense.ID.ToString(),
                DriverId = LocalLicense.DriverID.ToString(),
                PersonName = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}",
                NationalId = person.NationalNo,
                Gender = person.Gendor == 1 ? "Male" : "Female",
                Class = LocalLicense.LicenseClass.ToString(),
                Notes = string.IsNullOrWhiteSpace(LocalLicense.Notes) ? "No Notes" : LocalLicense.Notes,
                ExpirationDate = LocalLicense.ExpirationDate.ToString(),
                IssueDate = LocalLicense.IssueDate.ToString(),
                DateOfBirth = person.DateOfBirth.ToString(),
                IsActive = LocalLicense.IsActive
            };
        }
        private LicenseDto GetDrivingLicense(string Id)
        {
            return _ILicenseService.GetById(int.Parse(Id));
        }
        private DriverDto GetDriver(int ID)
        {
            return _DriverService.GetById(ID);
        }
        private PersonDto GetPerson(int ID)
        {
            return _PersonService.GetById(ID);
        }
        public   ILicenseInformationUtility LicenseInformation()
        {
            return _LicenseInformationUtility;
        }
        public bool AddInternationalLicense()
        {
            if (!_InternationalService.IsLicenseExist(LocalLicense.ApplicationID))
            {
                InternationalLicenseDto InterLicense = new InternationalLicenseDto();
                InterLicense.ApplicationID = LocalLicense.ApplicationID;
                InterLicense.DriverID = LocalLicense.DriverID;
                InterLicense.IssueData = LocalLicense.IssueDate;
                InterLicense.ExpirationDate = LocalLicense.ExpirationDate;
                InterLicense.IsActive = LocalLicense.IsActive;
                InterLicense.CreatedByuserID = ClassCurrentUserInformation.CurrentUser.UserID;
                InterLicense.IssueUsingLicalLicenseID = LocalLicense.ID;
                _InternationalService.Add(InterLicense);
                return true;
            }
            return false;
           
        }

        public void PrepareTheLicense(string id)
        {
            LocalLicense = GetDrivingLicense(id.ToString());
        }

        public bool IsLicenseOrdenaryDrivingLicense()
        {
            return LocalLicense.LicenseClass == 3;
        }

        public int GetLocalDrivingLicenseApplicationID()
        {
            LocalLicense = _FindLicenserWithFilterUtility.GetLicense();
         return   _LocalDrivingLicenseService.GetByApplicationID(LocalLicense.ApplicationID).ID;
        }
     public   IFindLicenserWithFilterUtility findLicenserWithFilterUtility()
        {
            return _FindLicenserWithFilterUtility;
        }
        public int GetLocalDrivingLicenseID()
        {
            return LocalLicense.ID;      
        }
     
    }
}
