using DVDL_Business.After.DTOs;
using DVDL_Business.After.User;
using FormsUtilities.PersonInformation.PersonCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.UserInformation.UserCard
{
    public class UsercardUtility: IUsercardUtility
    {
        IUserService userService;
        IPersonCardUtility personCardUtility;
        public UsercardUtility(IUserService userService, IPersonCardUtility personCardUtility)
        {
            this.userService = userService;
            this.personCardUtility = personCardUtility;
        }

        public UserDto GetUser(int id)
        {
            return userService.GetById(id);
        }
        public PersonDto GetPerson(int id)
        {
          return  personCardUtility.GetPerson(id);
        }
   
        public IPersonCardUtility GetPersonCardUtility()
        {
            return personCardUtility;
        }
    }
}
