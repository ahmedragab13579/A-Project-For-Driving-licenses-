using DVDL_Business.After.DTOs;
using TheDataLayer_For_Project.Models.Person;
using TheDataLayer_For_Project.Repositories.Person;

namespace DVDL_Business.After.People
{
    public class PersonService : IPersonService
    {
        private readonly PersonRepository _PersonRepository;

        public PersonService()
        {
            _PersonRepository = new PersonRepository();
        }
        public int Add(PersonDto person)
        {
            return _PersonRepository.Add(Map(person));
        }

        public bool Delete(int id)
        {
            return _PersonRepository.Delete(id);
        }

        public List<PersonDto> GetAll()
        {
            var persons = new List<PersonDto>();
            foreach (var i in _PersonRepository.GetAll())
            {
                persons.Add(Map(i));

            }
            return persons;
        }

        public PersonDto GetById(int id)
        {
            return Map(_PersonRepository.GetById(id));
        }

        public PersonDto GetByNationalId(string nationalId)
        {
            return Map(_PersonRepository.GetByNationalId(nationalId));
        }

        public bool IsNationalIdExist(string nationalId)
        {
            return _PersonRepository.IsNationalIdExist(nationalId);
        }

        public bool Update(PersonDto person)
        {
            return _PersonRepository.Update(Map(person));
        }



        private Person Map(PersonDto Person)
        {
            if (Person != null)
            {
                return new Person
                {
                    PersonID = Person.PersonID,
                    NationalityCountryID = Person.NationalityCountryID,
                    NationalNo = Person.NationalNo,
                    FirstName = Person.FirstName,
                    LastName = Person.LastName,
                    SecondName = Person.SecondName,
                    DateOfBirth = Person.DateOfBirth,
                    Address = Person.Address,
                    ThirdName = (Person.ThirdName == null ? "" : Person.ThirdName),
                    Email = (Person.Email == null ? "" : Person.Email),
                    Gendor = Person.Gendor,
                    ImagePath = Person.ImagePath,
                    Phone = Person.Phone,

                };
            }
            return null;

        }
        private PersonDto Map(Person Person)
        {
            if (Person != null)
            {
                return new PersonDto
                {
                    PersonID = Person.PersonID,
                    NationalityCountryID = Person.NationalityCountryID,
                    NationalNo = Person.NationalNo,
                    FirstName = Person.FirstName,
                    LastName = Person.LastName,
                    SecondName = Person.SecondName,
                    DateOfBirth = Person.DateOfBirth,
                    Address = Person.Address,
                    ThirdName = (Person.ThirdName == null ? "" : Person.ThirdName),
                    Email = (Person.Email == null ? "" : Person.Email),
                    Gendor = Person.Gendor,
                    ImagePath = Person.ImagePath,
                    Phone = Person.Phone,

                };
            }
            return null;
        }
    }
}
