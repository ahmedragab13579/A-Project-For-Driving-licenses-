using DVDL_Business.After.DTOs;

namespace DVDL_Business.After.LicenseType
{
    public interface ILicenseTypeService
    {
        public List<LicenseTypeDto> GetAll();
        public LicenseTypeDto GetById(int id);
    }
}
