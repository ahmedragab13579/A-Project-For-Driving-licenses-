using DVDL_Business.After.User;
using DVDL_InfrastructureLayer;
using FormsUtilities.LoginScreen;
namespace DVDL_Persentation
{
    public partial class TheLoginScreenForm : Form
    {
        ILoginScreenUtility _loginScreen;
        private bool IsUserExist=false;
        public TheLoginScreenForm(ILoginScreenUtility _loginScreen)
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);

            this.  _loginScreen = _loginScreen;
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Please Write The username and password");
            }
            else
            {
                var User = _loginScreen.GetTheUser( UserNameTextBox.Text, _loginScreen.EncryptPassword(  PasswordTextBox.Text));
                if (User.Result != null)
                {
                    _loginScreen.SetUpCurrentUser(User.Result);
                    if (RememberMe.Checked && !IsUserExist)
                    {
                       _loginScreen.WriteLoginInformationInData();
                    }
                    else
                    {
                        if (_loginScreen.IsTheUserExist().Success)
                        {
                            _loginScreen.CleanTheLoginData();

                        }

                    }
                  
                    Form TheMainMenuScreen = new TheMainMenuForm();
                    TheMainMenuScreen.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User Name or Password Is Wrong");
                }


            }
        }
        private void TheLoginScreenForm_Load(object sender, EventArgs e)
        {
        
            IsUserExist = _loginScreen.IsTheUserExist().Success;
            if (IsUserExist)
            {

                var LoginInfo = _loginScreen.LoadLoginDataIfExist();

                if (LoginInfo.Success != false)
                {
                    UserNameTextBox.Text = LoginInfo.Result[0];
                    PasswordTextBox.Text = LoginInfo.Result[1];
                }
            }
           
        }
    }
}
