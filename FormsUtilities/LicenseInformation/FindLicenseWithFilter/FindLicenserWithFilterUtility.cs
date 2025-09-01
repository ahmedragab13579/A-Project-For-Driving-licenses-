using DVDL_Business.After.DetainLicense;
using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.People;
using DVDL_Persentation.License_Information.ChangeLicense.Models;


namespace FormsUtilities.LicenseInformation.FindLicenseWithFilter
{
    public class FindLicenserWithFilterUtility : IFindLicenserWithFilterUtility
    {
     
        private readonly IDriverService _DriverService;
        private readonly IPersonService _PersonService;
        private readonly ILicenseService _ILicenseService;
        private readonly IDetainLicenseService _IDetainLicenseService;
        LicenseDto License;
        string NationalID="";
        string ImagePath="";
        public FindLicenserWithFilterUtility(
        IDriverService _DriverService,
        IPersonService _PersonService, IDetainLicenseService _IDetainLicenseService,
        ILicenseService _ILicenseService)
        {
         
            this._DriverService = _DriverService;
            this._PersonService = _PersonService;
            this._ILicenseService = _ILicenseService;
           this._IDetainLicenseService= _IDetainLicenseService;
            License = new LicenseDto();
        }


        public bool IsValidText(string Text)
        {

            if (Text.Length != 0)
                if (int.TryParse(Text, out int licenseId))
                    return true;
            return false;
        }


        private DriverDto GetDriver(int ID)
        {
            return _DriverService.GetById(ID);
        }
        private PersonDto GetPerson(int ID)
        {
            return _PersonService.GetById(ID);
        }
        private LicenseDto GetDrivingLicense(string Id)
        {
            return _ILicenseService.GetById(int.Parse(Id));
        }
        public LicenseViewModel GetLicenseInfo(string licenseNo)
        {
            License = GetDrivingLicense(licenseNo);
            if (License == null) return null;

            var driver = GetDriver(License.DriverID);
            var person = GetPerson(driver.PersonID);
            ImagePath=person.ImagePath;

            return new LicenseViewModel
            {
                LicenseId = License.ID.ToString(),
                DriverId = License.DriverID.ToString(),
                PersonName = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}",
                NationalId = person.NationalNo,
                Gender = (person.Gendor == 1 ? "Male" : "Female"),
                Class = License.LicenseClass.ToString(),
                Notes = string.IsNullOrWhiteSpace(License.Notes) ? "No Notes" : License.Notes,
                ExpirationDate = License.ExpirationDate.ToString(),
                IssueDate = License.IssueDate.ToString(),
                DateOfBirth = person.DateOfBirth.ToString(),
                IsActive = License.IsActive
            };
        }

        public LicenseDto GetLicense()
        {
            return License;
        }




        public void SetNationalID(string NationalID)
        {
          this.  NationalID = NationalID;      
        }

        public string GetNationalID()
        {
            return NationalID;
        }

        public bool IsActive(string LicenseID)
        {
            return _ILicenseService.IsActive(int.Parse(LicenseID));
        }

        public bool IsDetained()
        {
            return _IDetainLicenseService.IsDetained(License.ID);        }

        public string PersonImagePath()
        {
            return ImagePath;        }
    }
}