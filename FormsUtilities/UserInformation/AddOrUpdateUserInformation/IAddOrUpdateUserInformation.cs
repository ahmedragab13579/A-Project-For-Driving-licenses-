using DVDL_Business.After.DTOs;
using FormsUtilities.PersonInformation.PersonCard;

namespace FormsUtilities.UserInformation.AddOrUpdateUserInformation
{
    public interface IAddOrUpdateUserInformation
    {
        bool ValidateInputs(string Username, string Password, string CPassword);
        bool CanAddNewUser(int id);
        bool ShowError(string message);
        void MakeANewUser(int userid,int PersonID, string UserName, string Password, bool Checked);
        IPersonCardUtility PersonCardUtility();
        UserDto GetUserbyPersonID(int UserID);
        UserDto GetUserbyID(int UserID);
        public UserDto GetUser();
        public int Save();
    
    }
}
