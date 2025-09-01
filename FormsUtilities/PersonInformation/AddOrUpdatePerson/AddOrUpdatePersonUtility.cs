using DVDL_Business.After.Country;
using DVDL_Business.After.DOTs;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.People;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TheDataLayer_For_Project.Models.Person;

namespace FormsUtilities.PersonInformation.AddOrUpdatePerson
{
    public class AddOrUpdatePersonUtility :IAddOrUpdatePersonUtility
    {
        PersonDto person;
        private readonly ICountryService _CountrySevice;
        IPersonService _PersonService;

        public AddOrUpdatePersonUtility(ICountryService _CountrySevice, IPersonService _PersonService)
        {
            this._CountrySevice = _CountrySevice;
            this._PersonService = _PersonService;
            person= new PersonDto();
        }
        public bool IsNationalIDExists(string ID)
        {
            return _PersonService.IsNationalIdExist(ID);
        }
        public List<CountryDtos> TheCountrys()
        {
            return _CountrySevice.GetAll();
           
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, pattern);
        }
        public void FillThePersonAfterUpdate(PersonDto Person,bool Checked)
        {
            person.FirstName = Person.FirstName;
            person.SecondName = Person.SecondName;
            person.ThirdName = Person.ThirdName;
            person.LastName = Person.LastName;
            person.NationalNo = Person.NationalNo;
            person.DateOfBirth = Person.DateOfBirth;
            person.Phone = Person.Phone;
            person.Email = Person.Email;
            person.Address = Person.Address;
            person.NationalityCountryID = Person.NationalityCountryID;
            person.Gendor=PersonGendor(Checked);
        }

        public PersonDto Person()
        {
            return person;
        }

        public void RefreshFromDatabase()
        {
            if (person.PersonID > 0)
            {
                person = _PersonService.GetById(person.PersonID);
            }
        }

        private int PersonGendor(bool Text)
        {
            if (Text)
            {
                return 0;

            }
            return 1;

        }


        public void ImagePath(string ImagePath)
        {
            person.ImagePath=ImagePath;
        }
        public bool UpdatePerson()
        {
          return  _PersonService.Update(person);

        }

        public int AddPerson()
        {
            return _PersonService.Add(person);
        }

        public void SetID(int id)
        {
            person.PersonID = id;
        }

        public int PersonID()
        {
            return person.PersonID;
        }
        public void SetPerson(PersonDto dto)
        {
            person = dto;
        }

    }
}
