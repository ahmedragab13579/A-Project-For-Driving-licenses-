using DVDL_Business.After.Country;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDataLayer_For_Project.Models.Person;

namespace FormsUtilities.PersonInformation.PersonCard
{
    public class PersonCardUtility:IPersonCardUtility
    {

        private PersonDto person;
        private readonly ICountryService _CountrySevice;
                         IPersonService _PersonService;

  

        public PersonCardUtility(ICountryService _CountrySevice, IPersonService _PersonService)
        {                 
            this._CountrySevice = _CountrySevice;
            this._PersonService = _PersonService;
            person = new PersonDto();
        }


        public bool ThePersonInformation(int ID)
        {
            person = _PersonService.GetById(ID);
            if (person == null)
            {
               return false;
            }
            return true;

        }
        public bool ThePersonInformation(string NationalNumber)
        {
            person = _PersonService.GetByNationalId(NationalNumber);
            if (person == null)
            {
                return false;
            }
            return true;
        }
        public string GetTheCountryName(int index)
        {
            var CountryData = _CountrySevice.GetAll();

            if (CountryData != null)
            {
                return CountryData[index].Name;
            }

            return "";
        }
        public void ResetPersonObject()
        {
            person.PersonID = -1;
            person.Email = "";
            person.Address = "";
            person.NationalityCountryID = -1;
            person.FirstName = "";
            person.SecondName = "";
            person.ThirdName = "";
            person.LastName = "";
            person.Phone = "";
            person.Gendor = -1;
            person.DateOfBirth = DateTime.Now;
        }
        private void LoadPersonInformation(int id)
        {
            person= _PersonService.GetById(id); 

        }
        private void LoadPersonInformation(string NationalNo)
        {
            person= _PersonService.GetByNationalId(NationalNo); 

        }
        public PersonDto GetPerson(int id)
        {
            LoadPersonInformation(id);
            return person;
        }
        public PersonDto GetPerson(string NationalNO)
        {
            LoadPersonInformation(NationalNO);
            return person;
        }

        public int GetPersonID()
        {
            return person.PersonID;
        }
    }
}
