using DVDL_Business.After.DTOs;

namespace DVDL_Business.After.License
{
    public interface ILicenseService
    {
        public LicenseDto GetByApplicationId(int applicationId);
        public LicenseDto GetById(int licenseId);
        public List<LicenseDto> GetByDriverId(int driverId);
        public int Add(LicenseDto license);
        public bool DeactivateLicense(int licenseId);
        public bool IsActive(int licenseId);
    }

}
