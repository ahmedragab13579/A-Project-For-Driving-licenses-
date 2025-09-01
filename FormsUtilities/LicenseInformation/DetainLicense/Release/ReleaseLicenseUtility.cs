using DVDL_Business.After.Application;
using DVDL_Business.After.ApplicationType;
using DVDL_Business.After.DetainLicense;
using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.People;
using DVDL_Business.After.Users;
using DVDL_Persentation.License_Information.ChangeLicense.Models;
using FormsUtilities.LicenseInformation.DetainLicense.Release.viewModels;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;

namespace FormsUtilities.LicenseInformation.DetainLicense.Release
{
    public class ReleaseLicenseUtility:IReleaseLicenseUtility
    {
        LicenseDto License;
        IApplicationService _Application;
        IApplicationTypeService _Applicationtype;
        IPersonService _PersonService;
        IDetainLicenseService _DetainLicenseService;
        ILicenseService _ILicenseService;
        IFindLicenserWithFilterUtility _findLicenserWithFilterUtility;
        public ReleaseLicenseUtility(IApplicationService _Application,
        IApplicationTypeService _Applicationtype,
        IPersonService _PersonService,
        IDetainLicenseService _DetainLicenseService, IFindLicenserWithFilterUtility _findLicenserWithFilterUtility,
        ILicenseService _ILicenseService)
        {
            this._Application = _Application;
            this._Applicationtype = _Applicationtype;
            this._PersonService = _PersonService;
            this._DetainLicenseService = _DetainLicenseService;
            this._ILicenseService = _ILicenseService;
            this._findLicenserWithFilterUtility= _findLicenserWithFilterUtility;
            License = new LicenseDto();
        }
     
        

        public bool IsDetained()
        {
            License = _findLicenserWithFilterUtility.GetLicense();
            return _DetainLicenseService.IsDetained(License.ID);

        }
        public int PerpareTheApplication(string Fees)
        {
            PersonDto person = _PersonService.GetByNationalId(_findLicenserWithFilterUtility.GetNationalID());
            _Application.Application.PersonID = person.PersonID;

            _Application.Application.Date = DateTime.Now;

            _Application.Application.Type = 5;

            _Application.Application.StatusID = 3;

            _Application.Application.Fees = decimal.Parse(Fees);


            _Application.Application.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
           return _Application.Save();

        }
        public void PrepareRelaseDetain( string ApplicationID)
        {
            var Licese = _DetainLicenseService.GetById(License.ID);
            Licese.IsRelesd = true;
            Licese.RelaseDate = DateTime.Now;
            Licese.RelaisByuser = ClassCurrentUserInformation.CurrentUser.UserID;
            Licese.RelaisAppID = int.Parse(ApplicationID);
            _DetainLicenseService.UpdateReleaseInfo(Licese);
        }

      
        public int LicenseID()
        {
            return License.ID;
        }
        public DetainLicenseViewModel GetDetainLicenseInfo()
        {
            var Licese = _DetainLicenseService.GetById(License.ID);
            var App = _Applicationtype.GetById(5);
            return new DetainLicenseViewModel
            {
                AppFees = App.Fees,
                DetainID = _DetainLicenseService.GetById(LicenseID()).ID,
                DetainFees = Licese.FineFees,
                DetainDate = DateTime.Now,
                User = ClassCurrentUserInformation.CurrentUser.UserName
                
            };
        }

   
        public void FillTheDetainInfo()
        {
            throw new NotImplementedException();
        }

        public IFindLicenserWithFilterUtility findLicenserWithFilterUtility()
        {
            return _findLicenserWithFilterUtility;
        }
    }
}
