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
    public partial class TheLoginScreenForm : Form
    {
        public TheLoginScreenForm()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Please Write The username and password");
            }
            else
            {
                ClassTheUserInformation User= ClassDealWithDataOfTheUsers.FindUserByUserNameAndPassWord(UserNameTextBox.Text, PasswordTextBox.Text);
                if (User!=null)
                {
                   
                    ClassCurrentUserInformation.CurrentUser = User;
                    Form TheMainMenuScreen = new TheMainMenuForm();
                    TheMainMenuScreen.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This User is not in our system");
                }
                

            }
        }
    }
}
