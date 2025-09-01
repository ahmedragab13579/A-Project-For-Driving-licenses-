using DVDL_Business.After.DOTs;
using TheDataLayer_For_Project.Repositories.Applications;

namespace DVDL_Business.After.Application
{
    public class ApplicationService : IApplicationService
    {
        private readonly ApplicationRepository _applicationRepository;
        public enum EnumMode { Add = 1, Update = 2 }
        public EnumMode Mode = EnumMode.Add;
        public ApplicationDtos Application { get; set; }

        public ApplicationService()
        {
            _applicationRepository = new ApplicationRepository();
            Application = new ApplicationDtos
            {
                Date = DateTime.Now,
                LastStatusDate = DateTime.Now
            };
        }

        public int Save()
        {
            if (Mode == EnumMode.Add)
            {
                int newId = _applicationRepository.Add(MapToEntity(Application));
                if (newId > 0)
                {
                    Application.ID = newId;
                    Mode = EnumMode.Update;
                }
                return newId;
            }
            else
            {
                bool success = _applicationRepository.Update(MapToEntity(Application));
                return success ? Application.ID : -1;
            }
        }

        public List<ApplicationDtos> GetAll()
        {
            List<ApplicationDtos> applicationDOTs = new List<ApplicationDtos>();
            var repo = new ApplicationRepository();
            foreach (var item in repo.GetAll())
            {
                applicationDOTs.Add(MapToDto(item));

            }
            return applicationDOTs;
        }

        public ApplicationDtos FindById(int id)
        {
            var repo = new ApplicationRepository();
            return MapToDto(repo.GetById(id));
        }

        public bool Delete(int id)
        {
            var repo = new ApplicationRepository();
            return repo.Delete(id);
        }

        public bool Cancel(int id)
        {
            var repo = new ApplicationRepository();
            return repo.Cancel(id);
        }

        private ApplicationDtos MapToDto(TheDataLayer_For_Project.Models.Applications.Application app)
        {
            return new ApplicationDtos
            {
                ID = app.ID,
                Fees = app.Fees,
                PersonID = app.PersonID,
                Date = app.Date,
                Type = app.Type,
                StatusID = app.StatusID,
                LastStatusDate = app.LastStatusDate,
                CreatedByUserID = app.CreatedByUserID,
            };
        }

        private TheDataLayer_For_Project.Models.Applications.Application MapToEntity(ApplicationDtos dto)
        {
            return new TheDataLayer_For_Project.Models.Applications.Application
            {
                ID = dto.ID,
                Fees = dto.Fees,
                PersonID = dto.PersonID,
                Date = dto.Date,
                Type = dto.Type,
                StatusID = dto.StatusID,
                LastStatusDate = dto.LastStatusDate,
                CreatedByUserID = dto.CreatedByUserID,
            };
        }

    }
}
