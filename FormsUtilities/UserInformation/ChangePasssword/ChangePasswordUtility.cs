using DVDL_Business.After.DTOs;
using DVDL_Business.After.User;
using DVDL_InfrastructureLayer;
using FormsUtilities.PersonInformation.PersonCard;
namespace FormsUtilities.UserInformation.ChangePasssword
{
    public class ChangePasswordUtility: IChangePasswordUtility
    {
        Encrypt _encrypt;
        IUserService _userService;
        IPersonCardUtility _personCardUtility;
        public ChangePasswordUtility(IUserService userService, IPersonCardUtility _personCardUtility)
        {
            _userService = userService;
            this._personCardUtility = _personCardUtility;
            this._encrypt= new Encrypt();   
        }

        public string EncryptPassword(string text)
        {
            return _encrypt.EncryptText(text);    
        }

        public IPersonCardUtility GetPersonCardUtility()
        {
            return _personCardUtility;        }

        public UserDto GetUser(int id)
        {
            return _userService.GetById(id);
        }

        public UserDto GetUserbyPersonID(int id)
        {
            return _userService.GetByPersonId(id);
        }

        public bool UpdateUser(string UserName, string Password, string isActive, int UserID, int PersonID)
        {
         
                UserDto user = new UserDto
                {
                    UserName =UserName,
                    Password =Password,
                    UserID   = UserID,
                    PersonID =PersonID,
                    IsActive = (isActive == "Yes" ? true : false)

                };

              return _userService.Update(user);
            
        }
    }
}
