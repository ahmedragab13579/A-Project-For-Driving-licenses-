using DVDL_Business.After.DTOs;
using FormsUtilities.OperationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LoginScreen
{
    public interface ILoginScreenUtility
    {
        OperationResult<bool> WriteLoginInformationInData();
        OperationResult<bool> CleanTheLoginData();
        OperationResult<List<string>> LoadLoginDataIfExist( );
        OperationResult<bool> IsTheUserExist();
        OperationResult<UserDto> GetTheUser( string Username,  string Password);
        void SetUpCurrentUser( UserDto User);
        public string DecryptPassword(string Text);
        public string EncryptPassword(string Text);
    }
}
