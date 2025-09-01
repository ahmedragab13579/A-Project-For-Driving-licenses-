using DVDL_Business.After.DOTs;
using DVDL_Business.After.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormsUtilities.PersonInformation.AddOrUpdatePerson
{
    public interface IAddOrUpdatePersonUtility
    {
      bool IsNationalIDExists(string ID);
        public void RefreshFromDatabase();
        public void SetPerson(PersonDto dto);
      List<CountryDtos> TheCountrys();
     
      bool IsValidEmail(string email);
        PersonDto Person();
        int PersonID();
        void ImagePath(string ImagePath);
        bool UpdatePerson();
        int AddPerson();
        void SetID(int id);
    }
}
