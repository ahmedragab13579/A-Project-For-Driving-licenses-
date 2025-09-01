using DVDL_InfrastructureLayer;
using FormsUtilities.UserInformation.ChangePasssword;
using FormsUtilities.UserInformation.UserCard;
using System;
using System.Windows.Forms;
using TheDataLayer_For_Project.Models.Tests;

namespace DVDL_Persentation
{
    public partial class UserInformationForm : Form
    {
        int ID;
        IUsercardUtility _UserCardUtility;

        public UserInformationForm(IUsercardUtility _UserCardUtility, int ID)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this.ID = ID;
            this._UserCardUtility = _UserCardUtility;
            SetUserUtility();
        }

        private void SetUserUtility()
        {

            userCardControl1.SetUtility(_UserCardUtility);
        }


  
        private void UserInformationForm_Load_1(object sender, EventArgs e)
        {
            userCardControl1.FillTheInformation(ID);

        }
    }
}
