using DVDL_Business.After.DTOs;
using TheDataLayer_For_Project.Repositories.Licenses.InternationalLicense;

namespace DVDL_Business.After.InternationalLicense
{
    public class InternationalService : IInternationalService
    {
        private readonly InternationalRepository _InternationalRepository;
        public InternationalService()
        {
            _InternationalRepository = new InternationalRepository();


        }

        public int Add(InternationalLicenseDto license)
        {
            return _InternationalRepository.Add(Map(license));
        }

        public List<InternationalLicenseDto> GetAll()
        {
            List<InternationalLicenseDto> internationalLicenseDtos = new List<InternationalLicenseDto>();
            foreach (var i in _InternationalRepository.GetAll())
            {
                internationalLicenseDtos.Add(Map(i));
            }
            return internationalLicenseDtos;
        }

        public List<InternationalLicenseDto> GetByDriverId(int driverId)
        {
            List<InternationalLicenseDto> internationalLicenseDtos = new List<InternationalLicenseDto>();
            foreach (var i in _InternationalRepository.GetByDriverId(driverId))
            {
                internationalLicenseDtos.Add(Map(i));
            }
            return internationalLicenseDtos;
        }

        public bool IsLicenseExist(int applicationId)
        {
            return _InternationalRepository.IsLicenseExist(applicationId);
        }



        private InternationalLicenseDto Map(TheDataLayer_For_Project.Models.Licenses.InternationalLicense.InternationalLicense internationalLicense)
        {
            return new InternationalLicenseDto
            {
                IssueUsingLicalLicenseID = internationalLicense.IssueUsingLicalLicenseID,
                ApplicationID = internationalLicense.ApplicationID,
                CreatedByuserID = internationalLicense.CreatedByuserID,
                DriverID = internationalLicense.DriverID,
                ExpirationDate = internationalLicense.ExpirationDate,
                ID = internationalLicense.ID,
                IsActive = internationalLicense.IsActive,
                IssueData = internationalLicense.IssueData

            };

        }
        private TheDataLayer_For_Project.Models.Licenses.InternationalLicense.InternationalLicense Map(InternationalLicenseDto internationalLicense)
        {
            return new TheDataLayer_For_Project.Models.Licenses.InternationalLicense.InternationalLicense
            {
                IssueUsingLicalLicenseID = internationalLicense.IssueUsingLicalLicenseID,
                ApplicationID = internationalLicense.ApplicationID,
                CreatedByuserID = internationalLicense.CreatedByuserID,
                DriverID = internationalLicense.DriverID,
                ExpirationDate = internationalLicense.ExpirationDate,
                ID = internationalLicense.ID,
                IsActive = internationalLicense.IsActive,
                IssueData = internationalLicense.IssueData

            };

        }






    }
}
