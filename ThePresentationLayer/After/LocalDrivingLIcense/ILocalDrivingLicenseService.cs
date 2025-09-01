using DVDL_Business.After.DTOs;
using System.Data;

namespace DVDL_Business.After.LocalDrivingLIcense
{
    public interface ILocalDrivingLicenseService
    {
        DataTable GetAll();
        LocalDrivingLicenseDto GetByID(int id);
        LocalDrivingLicenseDto GetByApplicationID(int applicationID);
        bool IsLicenseExist(string nationalNo, string className);
        int Add(LocalDrivingLicenseDto application);
        bool Update(LocalDrivingLicenseDto application);
        bool Delete(int id);
    }
}
