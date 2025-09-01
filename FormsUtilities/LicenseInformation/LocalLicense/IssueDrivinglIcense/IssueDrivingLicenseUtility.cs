using DVDL_Business.After.Application;
using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.License;
using DVDL_Business.After.LicenseType;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.LocalLicense.IssueDrivinglIcense
{
    public class IssueDrivingLicenseUtility : IIssueDrivingLicenseUtility
    {
        LicenseDto License;

        DriverDto Driver;

        IApplicationService _ApplicationService;
        ILocalDrivingLicenseService _LocalDrivingLicenseService;
        IDriverService _DriverService;
        ILicenseTypeService _LicenseTypeService;
        ILicenseService _ILicenseService;

        public IssueDrivingLicenseUtility(
        IApplicationService _ApplicationService,
        ILocalDrivingLicenseService _LocalDrivingLicenseService,
        IDriverService _DriverService,
        ILicenseTypeService _LicenseTypeService,
        ILicenseService _ILicenseService)
        {
            this._ApplicationService = _ApplicationService;
            this._LocalDrivingLicenseService   = _LocalDrivingLicenseService;
            this._DriverService = _DriverService;
            this._ILicenseService = _ILicenseService;
            this._LicenseTypeService = _LicenseTypeService;
            
        }

        public void MakeTheApplicationCompleted(int Local)
        {
            var LocalLicense = _LocalDrivingLicenseService.GetByID(Local);
            var Application = _ApplicationService.FindById(LocalLicense.ApplicationID);
            Application.StatusID = 3;
            _ApplicationService.Save();
        }




        public int PrepareTheDriverInfomation(int personId)
        {
            var Driver = _DriverService.GetByPersonId(personId);
            if (Driver == null)
            {
                var newDriver = new DriverDto
                {
                    PersonID = personId,
                    CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID,
                    CreatedDate = DateTime.Now,

                };
                return _DriverService.Add(newDriver);
            }
            else
            {
                return Driver.ID;

            }
        }

        public void PrepareTheLicense(int personId,int Local,string Notes)
        {
            int DriverID = PrepareTheDriverInfomation(personId);
            var LocalLicense = _LocalDrivingLicenseService.GetByID(Local);
            var LicenseType = _LicenseTypeService.GetById(LocalLicense.LicenseClassID);

            var license = new LicenseDto
            {
                ID = 0,
                DriverID = DriverID,
                LicenseClass = LocalLicense.LicenseClassID,
                IssueReason = LocalLicense.LicenseClassID,
                ApplicationID = LocalLicense.ApplicationID,
                CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID,
                IssueDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(LicenseType.DefaultValidityLength),
                Notes = (Notes == "" ? null : Notes),
                IsActive = true,
                Fees = LicenseType.ClassFees

            };
            _ILicenseService.Add(license);
        }


    }
}
