using DVDL_Business.After.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.PersonInformation.PersonCard
{
    public interface IPersonCardUtility
    {
        bool ThePersonInformation(int ID);
        bool ThePersonInformation(string NationalNumber);
        string GetTheCountryName(int index);
        public void ResetPersonObject();
        public PersonDto GetPerson(int id);
        PersonDto GetPerson(string NationalNO);
        public int GetPersonID();

    }
}
