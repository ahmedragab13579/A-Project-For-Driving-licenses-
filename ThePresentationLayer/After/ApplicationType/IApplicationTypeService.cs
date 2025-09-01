using DVDL_DTOs;

namespace DVDL_Business.After.ApplicationType
{
    public interface IApplicationTypeService
    {

        List<ApplicationTypeDto> GetAll();
        bool Update(ApplicationTypeDto app);
        ApplicationTypeDto GetById(int id);
    }
}
