using DVDL_Business.After.DTOs;

namespace DVDL_Business.After.DetainLicense
{
    public interface IDetainLicenseService
    {
        public List<DetainLicenseDto> GetAll();
        public DetainLicenseDto GetById(int licenseId);

        public int Add(DetainLicenseDto model);

        public bool UpdateReleaseInfo(DetainLicenseDto model);
        public bool IsDetained(int licenseId);

    }
}
