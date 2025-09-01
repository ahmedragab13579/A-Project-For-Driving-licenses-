using DVDL_Business.After.DTOs;

namespace DVDL_Business.After.InternationalLicense
{
    public interface IInternationalService
    {
        public List<InternationalLicenseDto> GetAll();
        public bool IsLicenseExist(int applicationId);
        public List<InternationalLicenseDto> GetByDriverId(int driverId);

        public int Add(InternationalLicenseDto license);



    }
}
