using DVDL_Business.After.DTOs;
using DVDL_Business.After.User;
using DVDL_Business.After.Users;
using DVDL_InfrastructureLayer;
using FormsUtilities.OperationResults;
using Microsoft.Win32;
namespace FormsUtilities.LoginScreen
{
    public class LoginScreenUtility:ILoginScreenUtility
    {
        private readonly   IUserService _UserService;
        private readonly ConfigManager _ConfigManager;
        private readonly Encrypt _Encrypt;
        private readonly Decrypt _Decrypt;
   
        public LoginScreenUtility(IUserService _UserService)
        {
           this. _UserService =_UserService;
            _ConfigManager = new ConfigManager();
            _Encrypt = new Encrypt();
            _Decrypt = new Decrypt();
        }

   
        private string GetRegistryValue(string key)
        {
            return _Decrypt.DecryptText(Registry.GetValue(_ConfigManager.GetAppSetting("RegistryString"), key, null) as string);
        }
    
        private void SetRegistryValue(string key,string Value)
        {
            Registry.SetValue(_ConfigManager.GetAppSetting("RegistryString"), key, _Encrypt.EncryptText(Value), RegistryValueKind.String);
        }
    
        public OperationResult<bool> CleanTheLoginData()
        {

            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey("SOFTWARE\\MyLoginInformation", true))
                    {
                        if (key != null)
                        {
                            key.DeleteValue("UserName", false);
                            key.DeleteValue("Password", false);
                            return new OperationResult<bool> { Success=true,Exception=null, Message = "Login data cleared successfully" };

                        }
                        else
                        {
                            return new OperationResult<bool> { Success = false, Exception = null,
                                Message = "Login information not found in registry"
                            };

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new OperationResult<bool> { Success = false, Exception = ex, Result = false };
                
            }
        }

        public string DecryptPassword(string Text)
        {
            return _Decrypt.DecryptText(Text);
        }
        public string EncryptPassword(string Text)
        {
            return _Encrypt.EncryptText(Text);
        }
        public OperationResult<bool> IsTheUserExist()
        {
            bool IsFound = false;

            try
            {
               
                string userName = GetRegistryValue("UserName") ;
                string password = GetRegistryValue("Password") ;

                if (userName != null && password != null)
                {
                    IsFound = true;
                    return new OperationResult<bool> { Success = IsFound, Exception = null, Message = "successfull Operation" };

                }
            }
            catch (Exception ex)
            {
                return new OperationResult<bool> { Success = false, Exception = ex, Message = "An error occured" };
            }
            return new OperationResult<bool> { Success= IsFound, Exception=null,Message= "Not Found" };
        }

        public OperationResult<List<string>> LoadLoginDataIfExist()
        {

            try
            {
                string userName = GetRegistryValue("UserName");
                string password = GetRegistryValue("Password");

                if (userName != null && password != null)
                {
                    return new OperationResult<List<string>> { Success = true, Exception = null, Result = new List<string> { userName, password }, Message = "Success" };
                }

            }
            catch (Exception ex)
            {
                return new OperationResult<List<string>> { Success = false, Exception = ex,Message="Fail"};
            }
            return new OperationResult<List<string>> { Success = false, Exception = null, Message = "Fail" };
        }

        public OperationResult<bool> WriteLoginInformationInData()
        {
            string userName = ClassCurrentUserInformation.CurrentUser.UserName;
            string password = ClassCurrentUserInformation.CurrentUser.Password;

            try
            {
                SetRegistryValue("UserName", userName);
                SetRegistryValue("Password", password);

                return new OperationResult<bool> {Success=true,Exception=null,Message="Success" };
            }
            catch (Exception ex)
            {
                return new OperationResult<bool> { Success = false, Exception = ex, Message = "Fail" };
            }
        }
        public OperationResult<UserDto> GetTheUser( string Username,  string Password)
        {
            UserDto User = _UserService.GetByUserNameAndPassword(Username, Password);
            return new OperationResult<UserDto> { Success =(User!=null?true:false), Exception = null, Message = "Success",Result=User};
        }
        public void SetUpCurrentUser( UserDto User)
        {
          
              ClassCurrentUserInformation.CurrentUser = User;

            
        }
    }
}
