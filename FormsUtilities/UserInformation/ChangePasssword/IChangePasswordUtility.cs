using DVDL_Business.After.DTOs;
using FormsUtilities.PersonInformation.PersonCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.UserInformation.ChangePasssword
{
    public interface IChangePasswordUtility
    {
        UserDto GetUser(int id);
        UserDto GetUserbyPersonID(int id);
        string EncryptPassword(string text);
        IPersonCardUtility GetPersonCardUtility();
        bool UpdateUser(string UserName,string Password,string isActive,int Usernaem,int PersonID);
    }
}
