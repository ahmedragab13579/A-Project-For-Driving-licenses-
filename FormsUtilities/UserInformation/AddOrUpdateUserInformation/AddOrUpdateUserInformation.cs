using DVDL_Business.After.DTOs;
using DVDL_Business.After.User;
using DVDL_InfrastructureLayer;
using FormsUtilities.PersonInformation.PersonCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDataLayer_For_Project.Models.Person;

namespace FormsUtilities.UserInformation.AddOrUpdateUserInformation
{
    public class AddOrUpdateUserInformation: IAddOrUpdateUserInformation
    {
        UserDto User;
        IUserService _UserService;
        IPersonCardUtility _PersonCardUtility;
        Encrypt _Encrypt;
        Decrypt _Decrypt;

        public AddOrUpdateUserInformation(IUserService _UserService, IPersonCardUtility _PersonCardUtility)
        {
            this._UserService = _UserService;
            this._PersonCardUtility = _PersonCardUtility;
            User=new UserDto();
            _Encrypt = new Encrypt();
            _Decrypt = new Decrypt();
        }
        public bool ValidateInputs(string Username,string Password,string CPassword)
        {
            if (string.IsNullOrWhiteSpace(Username))
                return ShowError("Please enter the user name");

            if (string.IsNullOrWhiteSpace(Password))
                return ShowError("Please write the password");

            if (string.IsNullOrWhiteSpace(CPassword))
                return ShowError("Please write the confirm password");

            if (Password != CPassword)
                return ShowError("Password and confirm password must match");

            return true;
        }


        public bool CanAddNewUser(int personId)
        {
            return (_UserService.GetByPersonId(personId) == null);
           
        }


        public bool ShowError(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        public void MakeANewUser( int Userid,int PersonID,string UserName,string Password,bool Checked)
        {
            User.PersonID = PersonID;
            User.UserName = UserName;
            User.Password = Password;
            User.IsActive = Checked;
             User.UserID = Userid;
           
        }

        public UserDto GetUserbyPersonID(int Personid)
        {
            return _UserService.GetByPersonId(Personid);
        }

        public UserDto GetUserbyID(int UserID)
        {
            User = _UserService.GetById(UserID);
            User.Password = DecryptPassword(User.Password);
            return User;
        }
        public int  Save()
        {
            User.Password = EncryptPassword(User.Password);
            if(User.UserID==-1)
            {
                User.UserID = _UserService.Add(User);


                return User.UserID;
            }
            _UserService.Update(User);
            return User.UserID;
        }
        public UserDto GetUser()
        {
            return User;
        }
  
        public IPersonCardUtility PersonCardUtility()
        {
            return _PersonCardUtility;
        }

        private string EncryptPassword(string Text)
        {
            return _Encrypt.EncryptText(Text);
        }
        private string DecryptPassword(string text)
        {
            return _Decrypt.DecryptText(text);  
        }
    }
}
