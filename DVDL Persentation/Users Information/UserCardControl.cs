using DVDL_Business.After.DTOs;
using DVDL_Business.After.User;
using DVDL_InfrastructureLayer;
using FormsUtilities.UserInformation.UserCard;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class UserCardControl : UserControl
    {
        IUsercardUtility _usercardUtility;
        public UserCardControl()
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);

        }
        public void SetUtility(IUsercardUtility _usercardUtility)
        {
            this._usercardUtility = _usercardUtility;
          personCard1.SetUtility(  _usercardUtility.GetPersonCardUtility());
        }
        private void FillThePersonInformation(int id)
        {
            
            personCard1.FillThePersonInformation(_usercardUtility.GetPerson(id));
        }
        private void FillTheUserInformation(UserDto User)
        {
            FillThePersonInformation(User.PersonID);
            UserIDLabel.Text = User.UserID.ToString();
            UserNameLabel.Text = User.UserName;
            IsActiveLabel.Text = (User.IsActive == true ? "Yes" : "No");

        }

        public void FillTheInformation(int UserID)
        {
            FillTheUserInformation(_usercardUtility.GetUser(UserID));

        }
    }
}
