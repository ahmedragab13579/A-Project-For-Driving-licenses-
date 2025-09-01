using DVDL_Business.After.DTOs;
using System.Data;
using TheDataLayer_For_Project.Models.Applications.LocalApplication;
using TheDataLayer_For_Project.Repositories.Applications.LocalApplication;

namespace DVDL_Business.After.LocalDrivingLIcense
{
    public class LocalDrivingLicenseService : ILocalDrivingLicenseService
    {
        private readonly LocalDrivingLicenseApplicationRepository _repository;

        public LocalDrivingLicenseService()
        {
            _repository = new LocalDrivingLicenseApplicationRepository();
        }

        public DataTable GetAll()
        {
            return _repository.GetAll();
        }

        public LocalDrivingLicenseDto GetByID(int id)
        {
            return Map(_repository.GetByID(id));
        }

        public LocalDrivingLicenseDto GetByApplicationID(int applicationID)
        {
            return Map(_repository.GetByApplicationID(applicationID));
        }

        public bool IsLicenseExist(string nationalNo, string className)
        {
            return _repository.IsLicenseExist(nationalNo, className);
        }

        public int Add(LocalDrivingLicenseDto application)
        {
            return _repository.Add(Map(application));
        }

        public bool Update(LocalDrivingLicenseDto application)
        {
            return _repository.Update(Map(application));
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        private LocalDrivingLicenseDto Map(LocalDrivingLicenseApplication localDrivingLicenseApplication)
        {
            return new LocalDrivingLicenseDto
            {
                ID = localDrivingLicenseApplication.ID,
                ApplicationID = localDrivingLicenseApplication.ApplicationID,
                LicenseClassID = localDrivingLicenseApplication.LicenseClassID,

            };

        }
        private LocalDrivingLicenseApplication Map(LocalDrivingLicenseDto localDrivingLicenseDto)
        {
            return new LocalDrivingLicenseApplication
            {
                ID = localDrivingLicenseDto.ID,
                LicenseClassID = localDrivingLicenseDto.LicenseClassID,
                ApplicationID = localDrivingLicenseDto.ApplicationID,

            };

        }


    }
}
