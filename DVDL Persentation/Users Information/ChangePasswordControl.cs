using DVDL_Business.After.DTOs;
using DVDL_Business.After.User;
using DVDL_InfrastructureLayer;
using FormsUtilities.PersonInformation.PersonCard;
using FormsUtilities.UserInformation.ChangePasssword;
using FormsUtilities.UserInformation.UserCard;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class ChangePasswordControl : UserControl
    {
        public event EventHandler RefreshTheDataInManageUsers;


        IChangePasswordUtility _userService;
        public ChangePasswordControl()
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);

        }


        private void FillThePersonData(int id)
        {
            personCard1.FillThePersonInformation(id);
        }

        private void FillTheUserLoginData(UserDto User)
        {
            FillThePersonData(User.PersonID);
            UserIdText.Text = User.UserID.ToString();
            UserNameText.Text = User.UserName;
            IsActiveText.Text = (User.IsActive == true ? "Yes" : "No");

        }

   
        
        
        public void FillTheData(int Userid)
        {
            FillTheUserLoginData(_userService.GetUser(Userid));
        }

        public void SetUtility(IChangePasswordUtility User)
        {
            this._userService = User;
            personCard1.SetUtility(_userService.GetPersonCardUtility());
        }

        private bool ValidatePasswords()
        {
            if (NewPassWordTextBox.Text != ConfirmNewPassWordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            if (_userService.GetUserbyPersonID(personCard1.Person.PersonID).Password !=_userService.EncryptPassword( CurrentPassWordTextbox.Text))
            {
                errorProvider1.SetError(CurrentPassWordTextbox, "Current password is wrong");
                return false;
            }

            return true;
        }


        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (!ValidatePasswords()) return;

            bool isAffected = _userService.UpdateUser(
                UserNameText.Text,
               _userService.EncryptPassword( ConfirmNewPassWordTextBox.Text),
                IsActiveText.Text,
                int.Parse(UserIdText.Text),
                personCard1.Person.PersonID);

            MessageBox.Show(isAffected ? "The password updated successfully" : "Password update failed");
            if (isAffected) RefreshTheDataInManageUsers?.Invoke(this, EventArgs.Empty);
        }

        private void CurrentPassWordTextbox_Validating(object sender, CancelEventArgs e)
        {
           
            
            if (_userService.GetUserbyPersonID(personCard1.Person.PersonID).Password !=_userService.EncryptPassword( CurrentPassWordTextbox.Text))
            {
                errorProvider1.SetError(CurrentPassWordTextbox, "This Password is wrong");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false;

            }
        }


    }
}
