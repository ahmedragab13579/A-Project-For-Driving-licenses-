using DVDL_Business.After.DTOs;
using TheDataLayer_For_Project.Repositories.Licenses;

namespace DVDL_Business.After.LicenseType
{
    public class LicenseTypeService : ILicenseTypeService
    {
        private readonly LicenseTypeRepository _LicenseTypeRepository;
        public LicenseTypeService()
        {
            _LicenseTypeRepository = new LicenseTypeRepository();
        }
        public List<LicenseTypeDto> GetAll()
        {
            List<LicenseTypeDto> result = new List<LicenseTypeDto>();
            foreach (var i in _LicenseTypeRepository.GetAll())
            {
                result.Add(Map(i));
            }
            return result;
        }

        public LicenseTypeDto GetById(int id)
        {
            return Map(_LicenseTypeRepository.GetById(id));
        }


        private LicenseTypeDto Map(TheDataLayer_For_Project.Models.Licenses.LicenseType licenseType)
        {
            return new LicenseTypeDto
            {
                LicenseClassID = licenseType.LicenseClassID,
                ClassDescription = licenseType.ClassDescription,
                ClassFees = licenseType.ClassFees,
                ClassName = licenseType.ClassName,
                DefaultValidityLength = licenseType.DefaultValidityLength,
                MinimumAllowedAge = licenseType.MinimumAllowedAge,

            };

        }
        private TheDataLayer_For_Project.Models.Licenses.LicenseType Map(LicenseTypeDto licenseType)
        {
            return new TheDataLayer_For_Project.Models.Licenses.LicenseType
            {
                LicenseClassID = licenseType.LicenseClassID,
                ClassDescription = licenseType.ClassDescription,
                ClassFees = licenseType.ClassFees,
                ClassName = licenseType.ClassName,
                DefaultValidityLength = licenseType.DefaultValidityLength,
                MinimumAllowedAge = licenseType.MinimumAllowedAge,

            };
        }





    }
}
