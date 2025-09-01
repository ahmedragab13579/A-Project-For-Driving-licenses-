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
    public partial class UserCardControl : UserControl
    {
        public UserCardControl()
        {
            InitializeComponent();
        }

        private void FillThePersonInformation(int id)
        {
            personCard1.ThePersonInformation(id);
            personCard1.FillThePersonInformation();
        }
        private void FillTheUserInformation(int UserID)
        {
            ClassTheUserInformation User=ClassDealWithDataOfTheUsers.FindByID(UserID);
            FillThePersonInformation(User.PersonID);
            UserIDLabel.Text= UserID.ToString();
            UserNameLabel.Text = User.UserName;
            IsActiveLabel.Text = (User.IsActive == true ? "Yes" : "No");

        }

        public void FillTheInformation(int UserID)
        {
            FillTheUserInformation(UserID);

        }
    }
}
