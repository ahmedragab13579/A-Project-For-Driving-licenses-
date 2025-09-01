using DVDL_Business.After.DTOs;
using DVDL_InfrastructureLayer;
using FormsUtilities.UserInformation.AddOrUpdateUserInformation;
using System.ComponentModel;

namespace DVDL_Persentation
{
    public partial class AddOrUpdateUserForm : Form
    {
        public delegate void returndatatoformone(object sender);
        public event returndatatoformone RefreshTheManageDataInformation;



        private int id;
        IAddOrUpdateUserInformation _AddOrUpdateUserInformation;
        public AddOrUpdateUserForm(int id, IAddOrUpdateUserInformation _AddOrUpdateUserInformation)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            personCardWithFilter1.UserFound += UserController_UserFound;
            this.id = id;
            this._AddOrUpdateUserInformation = _AddOrUpdateUserInformation;
            personCardWithFilter1.SetUtility(_AddOrUpdateUserInformation.PersonCardUtility());
        }

        private void UserController_UserFound(int personID)
        {

            EnabeldNextButton();
            MessageBox.Show($"Person: {personID} was found");

        }
        private void EnabeldNextButton()
        {
            Next.Enabled = true;
            Next.Visible = true;

        }
        
        
        private void FillTheUserInformation(UserDto User)
        {
            UserIdLabel.Text = User.UserID.ToString();
            PasswordTB.Text = User.Password;
            ConfirmPasswordTB.Text = User.Password;
            UserNameTextBox.Text = User.UserName;
            checkBox1.Checked = User.IsActive;

            EnabeldNextButton();
        }
        private void PassWordtextBox_Validating(object sender, CancelEventArgs e)
        {
            if (PasswordTB.Text != ConfirmPasswordTB.Text)
            {
                Validating.SetError(PasswordTB, "the Value of Password and Confirm password is not equal");
                Validating.SetError(ConfirmPasswordTB, "the Value of Password and Confirm password is not equal");
            }
            else
            {
                Validating.Clear();
            }
        }
        private void PagesControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PagesControl.SelectedIndex == 1)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }
        private void ChangePagebutton_Click(object sender, EventArgs e)
        {
            if (_AddOrUpdateUserInformation.GetUserbyPersonID(personCardWithFilter1.GetThePerson().PersonID) == null)
                PagesControl.SelectedIndex = 1;
            else
            {
                MessageBox.Show("this Person is a user You can not add him more than one time");
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddOrUpdateUserForm_Load(object sender, EventArgs e)
        {
            if (id != -1)
            {
                personCardWithFilter1.DisableTheFilter();
                TheProcesLabel.Text = "Update the User";
                personCardWithFilter1.FillThePersonInformation(_AddOrUpdateUserInformation.GetUserbyID(id).PersonID);
                FillTheUserInformation(_AddOrUpdateUserInformation.GetUser());
            }
        }





        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (!_AddOrUpdateUserInformation.ValidateInputs(UserNameTextBox.Text,PasswordTB.Text,ConfirmPasswordTB.Text))
                return;

      
              _AddOrUpdateUserInformation. MakeANewUser(id,personCardWithFilter1.GetThePerson().PersonID,UserNameTextBox.Text,ConfirmPasswordTB.Text, checkBox1.Checked);
              UserIdLabel.Text=  _AddOrUpdateUserInformation.Save().ToString();
          
              _AddOrUpdateUserInformation.ShowError("Succssecfully Operation.");
        }
    }
}
