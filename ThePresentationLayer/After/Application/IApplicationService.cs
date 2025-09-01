using DVDL_Business.After.DOTs;

namespace DVDL_Business.After.Application
{
    public interface IApplicationService
    {

        public ApplicationDtos Application { get; set; }
        public int Save();

        public List<ApplicationDtos> GetAll();

        public ApplicationDtos FindById(int id);

        public bool Delete(int id);


        public bool Cancel(int id);


    }
}
