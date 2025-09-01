using DVDL_Business.After.DTOs;
using FormsUtilities.PersonInformation.PersonCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.UserInformation.UserCard
{
    public interface IUsercardUtility
    {
        UserDto GetUser(int id);
        public PersonDto GetPerson(int id);
        public IPersonCardUtility GetPersonCardUtility();
    }
}
