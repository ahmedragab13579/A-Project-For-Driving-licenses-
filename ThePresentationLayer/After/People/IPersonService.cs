using DVDL_Business.After.DTOs;

namespace DVDL_Business.After.People
{
    public interface IPersonService
    {
        public bool Delete(int id);
        public bool Update(PersonDto person);

        public int Add(PersonDto person);
        public bool IsNationalIdExist(string nationalId);
        public PersonDto GetByNationalId(string nationalId);
        public PersonDto GetById(int id);
        public List<PersonDto> GetAll();

    }
}
