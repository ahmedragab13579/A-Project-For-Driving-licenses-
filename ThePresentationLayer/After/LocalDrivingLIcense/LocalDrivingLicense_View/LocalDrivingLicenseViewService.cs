using DVDL_Business.After.DTOs;
using TheDataLayer_For_Project.Models.Applications.LocalApplication;
using TheDataLayer_For_Project.Repositories.Applications.LocalApplication;

namespace DVDL_Business.After.LocalDrivingLIcense.LocalDrivingLicense_View
{
    public class LocalDrivingLicenseViewService : ILocalDrivingLicenseViewService
    {
        private readonly LocalDrivingLicenseApplication_ViewRepository _localDrivingLicenseService;

        public LocalDrivingLicenseViewService()
        {
            _localDrivingLicenseService = new LocalDrivingLicenseApplication_ViewRepository();
        }
        public LocalDrivingLicenseApplication_ViewDto GetByID(int id)
        {
            return Map(_localDrivingLicenseService.GetByID(id));
        }

        private LocalDrivingLicenseApplication_ViewDto Map(LocalDrivingLicenseApplication_View License)
        {
            return new LocalDrivingLicenseApplication_ViewDto
            {
                ApplicationDate = License.ApplicationDate,
                LocalDrivingLicenseApplicationID= License.LocalDrivingLicenseApplicationID,
                Status = License.Status,
                ClassName = License.ClassName,
                FullName = License.FullName,
                NationalNo = License.NationalNo,
                PassedTestCount = License.PassedTestCount,
                

            };

        }
    }
}
