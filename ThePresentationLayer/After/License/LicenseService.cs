using DVDL_Business.After.DTOs;
using TheDataLayer_For_Project.Repositories.Licenses;

namespace DVDL_Business.After.License
{
    public class LicenseService : ILicenseService
    {
        private readonly LicenseRepository _repository;
        public LicenseService()
        {
            _repository = new LicenseRepository();
        }
        public int Add(LicenseDto license)
        {
            return _repository.Add(Map(license));
        }

        public bool DeactivateLicense(int licenseId)
        {
            return _repository.DeactivateLicense(licenseId);
        }

        public LicenseDto GetByApplicationId(int applicationId)
        {
            return Map(_repository.GetByApplicationId(applicationId));
        }

        public List<LicenseDto> GetByDriverId(int driverId)
        {
            List<LicenseDto> licenseDtos = new List<LicenseDto>();
            foreach (var i in _repository.GetByDriverId(driverId))
            {
                licenseDtos.Add(Map(i));
            }
            return licenseDtos;
        }

        public LicenseDto GetById(int licenseId)
        {
            return Map(_repository.GetById(licenseId));
        }

        public bool IsActive(int licenseId)
        {
            return _repository.IsActive(licenseId);
        }

        private LicenseDto Map(TheDataLayer_For_Project.Models.Licenses.License license)
        {
            if(license!=null)
            {
            return new LicenseDto
            {
                ID = license.ID,
                ApplicationID = license.ApplicationID,
                CreatedByUserID = license.CreatedByUserID,
                DriverID = license.DriverID,
                ExpirationDate = license.ExpirationDate,
                Fees = license.Fees,
                IsActive = license.IsActive,
                IssueDate = license.IssueDate,
                IssueReason = license.IssueReason,
                LicenseClass = license.LicenseClass,
                Notes = license.Notes,

            };

            }
            return null;

        }
        private TheDataLayer_For_Project.Models.Licenses.License Map(LicenseDto license)
        {
            return new TheDataLayer_For_Project.Models.Licenses.License
            {
                ID = license.ID,
                ApplicationID = license.ApplicationID,
                CreatedByUserID = license.CreatedByUserID,
                DriverID = license.DriverID,
                ExpirationDate = license.ExpirationDate,
                Fees = license.Fees,
                IsActive = license.IsActive,
                IssueDate = license.IssueDate,
                IssueReason = license.IssueReason,
                LicenseClass = license.LicenseClass,
                Notes = license.Notes,


            };

        }
    }
}
