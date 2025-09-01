using DVDL_DTOs;
using TheDataLayer_For_Project.Repositories.Applications;

namespace DVDL_Business.After.ApplicationType
{
    public class ApplicationTypeService : IApplicationTypeService
    {
        private readonly ApplicationTypeRepository _repo;

        public ApplicationTypeService()
        {
            _repo = new ApplicationTypeRepository();
        }
        public List<ApplicationTypeDto> GetAll()
        {
            var apps = _repo.GetAll();
            return apps.Select(app => MapToDto(app)).ToList();
        }

        public ApplicationTypeDto GetById(int id)
        {
            var app = _repo.GetById(id);
            return app == null ? null : MapToDto(app);
        }

        public bool Update(ApplicationTypeDto dto)
        {
            var entity = MapToEntity(dto);
            return _repo.Update(entity);
        }

        private ApplicationTypeDto MapToDto(TheDataLayer_For_Project.Models.Applications.ApplicationType app)
        {
            return new ApplicationTypeDto
            {
                ID = app.ID,
                Title = app.Title,
                Fees = app.Fees
            };
        }

        private TheDataLayer_For_Project.Models.Applications.ApplicationType MapToEntity(ApplicationTypeDto dto)
        {
            return new TheDataLayer_For_Project.Models.Applications.ApplicationType
            {
                ID = dto.ID,
                Title = dto.Title,
                Fees = dto.Fees
            };
        }
    }
}
