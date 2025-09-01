using DVDL_Business.After.DTOs;

namespace DVDL_Business.After.LocalDrivingLIcense.LocalDrivingLicense_View
{
    public interface ILocalDrivingLicenseViewService
    {
        public LocalDrivingLicenseApplication_ViewDto GetByID(int id);

    }
}
