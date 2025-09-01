using DVDL_Business.After.DTOs;
using TheDataLayer_For_Project.Repositories.Licenses.DetainLicense;

namespace DVDL_Business.After.DetainLicense
{
    public class DetainLicenseService : IDetainLicenseService
    {
        private readonly DetainLicenseRepository _DetainLicenseRepository;

        public DetainLicenseService()
        {
            _DetainLicenseRepository = new DetainLicenseRepository();
        }
        public int Add(DetainLicenseDto model)
        {
            return _DetainLicenseRepository.Add(Map(model));
        }

        public List<DetainLicenseDto> GetAll()
        {
            List<DetainLicenseDto> detainLicenseDtos = new List<DetainLicenseDto>();
            foreach (var i in _DetainLicenseRepository.GetAll())
            {
                detainLicenseDtos.Add(Map(i));

            }
            return detainLicenseDtos;
        }

        public DetainLicenseDto GetById(int licenseId)
        {
            return Map(_DetainLicenseRepository.GetById(licenseId));
        }

        public bool IsDetained(int licenseId)
        {
            return _DetainLicenseRepository.IsDetained(licenseId);
        }

        public bool UpdateReleaseInfo(DetainLicenseDto detainLicenseDto)
        {
            return _DetainLicenseRepository.UpdateReleaseInfo(Map(detainLicenseDto));
        }


        private TheDataLayer_For_Project.Models.DetainedLicense Map(DetainLicenseDto license)
        {
            return new TheDataLayer_For_Project.Models.DetainedLicense
            {
                RelaisAppID = license.RelaisAppID,
                Date = license.Date,
                FineFees = license.FineFees,
                ID = license.ID,
                IsRelesd = license.IsRelesd,
                LicenseID = license.LicenseID,
                RelaseDate = license.RelaseDate,
                RelaisByuser = license.RelaisByuser,
                User = license.User


            };

        }
        private DetainLicenseDto Map(TheDataLayer_For_Project.Models.DetainedLicense license)
        {
            return new DetainLicenseDto
            {

                RelaisAppID = license.RelaisAppID,
                Date = license.Date,
                FineFees = license.FineFees,
                ID = license.ID,
                IsRelesd = license.IsRelesd,
                LicenseID = license.LicenseID,
                RelaseDate = license.RelaseDate,
                RelaisByuser = license.RelaisByuser,
                User = license.User
            };

        }







    }
}
