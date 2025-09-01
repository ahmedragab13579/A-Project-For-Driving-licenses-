using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Users;

namespace TheSereens
{
    public partial class AddOrUpdateUserForm : Form
    {
        public delegate void returndatatoformone(object sender);
        public event returndatatoformone RefreshTheManageDataInformation;

        ClassTheUserInformation User = new ClassTheUserInformation();
        private int id;
        public AddOrUpdateUserForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ChangePagebutton_Click(object sender, EventArgs e)
        {
            if(!ClassDealWithDataOfTheUsers.FindUserByPersonID(personCardWithFilter1.GetThePersonId()))
            PagesControl.SelectedIndex = 1;
            else
            {
                MessageBox.Show("this Person is a user You can not add him more than one time");
            }
        }


        private void MakeANewUser()
        {
            if (id == -1)
            {
                User.PersonID = personCardWithFilter1.GetThePersonId();
                User.UserName = UserNameTextBox.Text;
                User.IsActive = checkBox1.Checked;
                User.Password = PasswordTB.Text;
            }
            else
            {
                User = new ClassTheUserInformation(UserNameTextBox.Text,PasswordTB.Text,id,personCardWithFilter1.GetThePersonId(),checkBox1.Checked);

            }
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

        private void ConfirmPassWordtextBox_Validating(object sender, CancelEventArgs e)
        {
            if(PasswordTB.Text==""||ConfirmPasswordTB.Text=="")
            {
                Validating.SetError(PasswordTB, "Please Write The Password and the confirm Password");
                Validating.SetError(ConfirmPasswordTB, "Please Write The Password and the confirm Password");
            }
            else
            Validating.Clear();


        }

        private void PagesControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PagesControl.SelectedIndex == 1)
            {
                button4.Enabled=true;
            }
            else
            {
                button4.Enabled=false;
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (CanAddNewUser())
            {
                MakeANewUser();
                id = User.Save();
                UserIdLabel.Text = id.ToString();
                RefreshTheManageDataInformation?.Invoke(this);
            }
            else
            {
                ShowError("This person is already a user. You cannot add them more than once.");
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTheUserInformation(ClassTheUserInformation User)
        {
            UserIdLabel.Text=User.UserID.ToString();
            PasswordTB.Text = User.Password;
            ConfirmPasswordTB.Text = User.Password;
            UserNameTextBox.Text = User.UserName;
            checkBox1.Checked=User.IsActive;


        }
        
        private void AddOrUpdateUserForm_Load(object sender, EventArgs e)
        {
             if(id!=-1)
            {
                personCardWithFilter1.DisableTheFilter();
                TheProcesLabel.Text = "Update the User";
                ClassTheUserInformation User = ClassDealWithDataOfTheUsers.FindByID(id);
                personCardWithFilter1.FillThePersonInformation(User.PersonID);
                FillTheUserInformation(User);
            }
        }

        
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(UserNameTextBox.Text))
                return ShowError("Please enter the user name");

            if (string.IsNullOrWhiteSpace(PasswordTB.Text))
                return ShowError("Please write the password");

            if (string.IsNullOrWhiteSpace(ConfirmPasswordTB.Text))
                return ShowError("Please write the confirm password");

            if (PasswordTB.Text != ConfirmPasswordTB.Text)
                return ShowError("Password and confirm password must match");

            return true;
        }

       
        private bool CanAddNewUser()
        {
            return !ClassDealWithDataOfTheUsers.FindUserByPersonID(personCardWithFilter1.GetThePersonId()) || id != -1;
        }

        
        private bool ShowError(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }




    }
}
