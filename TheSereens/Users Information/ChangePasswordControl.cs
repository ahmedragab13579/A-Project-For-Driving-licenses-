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
    public partial class ChangePasswordControl : UserControl
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheDataInManageUsers;
        public ChangePasswordControl()
        {
            InitializeComponent();
        }

        private void FillThePersonData(int id)
        {
            personCard1.ThePersonInformation(id);
            personCard1.FillThePersonInformation();
        }
       
        private void FillTheUserLoginData(int id)
        {
            ClassTheUserInformation User = ClassDealWithDataOfTheUsers.FindByID(id);
            FillThePersonData(User.PersonID);
            UserIdText.Text=User.UserID.ToString();
            UserNameText.Text=User.UserName;
            IsActiveText.Text=(User.IsActive==true?"Yes":"No");

        }
        
        public void FillTheData(int Userid)
        {
            FillTheUserLoginData(Userid);
        }
        
        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (NewPassWordTextBox.Text==ConfirmNewPassWordTextBox.Text)
            {
                ClassTheUserInformation User = new ClassTheUserInformation(UserNameText.Text, NewPassWordTextBox.Text, int.Parse(UserIdText.Text), personCard1.PersonID, (IsActiveText.Text == "Yes" ? true : false));
                int TheNUmberOFRowsAffected=User.Save();
                if(TheNUmberOFRowsAffected > 0)
                {
                    MessageBox.Show("The Password Update sucsessfuly");
                    RefreshTheDataInManageUsers?.Invoke(this);

                }
            }
            else
            {
                MessageBox.Show("The Password not match the confirm password");
            }
        }

        private void CurrentPassWordTextbox_Validating(object sender, CancelEventArgs e)
        {
            ClassTheUserInformation User=ClassDealWithDataOfTheUsers.FindByPersonID(personCard1.PersonID);
            if(User.Password!=CurrentPassWordTextbox.Text)
            {
                errorProvider1.SetError(CurrentPassWordTextbox, "This Password is wrong");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                e.Cancel = false ;

            }
        }

       
    }
}
