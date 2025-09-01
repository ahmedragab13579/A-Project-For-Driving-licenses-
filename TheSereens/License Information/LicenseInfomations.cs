using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Applications;
using ThePusnissLayer.Applications.LocalLisense;
using ThePusnissLayer.People;
using ThePusnissLayer.Users;

namespace TheSereens.License_Information
{
    public partial class LicenseInfomations : UserControl
    {
        public int PersonID;
        public int LocalLicenseID;
        public LicenseInfomations()
        {
            InitializeComponent();
        }

        private void FillTheLocalLicenseInformation(int id)
        {
           ClassLocalLicenseApplicationInfomation LocalApplication= ClassDealWithDataOfTheLocalLicenseApplication.FindApplicationByID(id);
            DataRow Row = ClassDealWithDataOfTheLocalLicenseApplication.PassRowFromTheLocalLicenseApplicationData(LocalApplication.ID);
            LocalLicenseIDLabel.Text=LocalApplication.ID.ToString();
            LocalLicenseID = LocalApplication.ID;
            LicenseClassLabel.Text= Row[1].ToString();
            PassedTestLabel.Text= Row[5].ToString();
            FillTheApplicationInformation(LocalApplication.ApplicationID, Row[6].ToString());
        }
        private void FillTheApplicationInformation(int id,string status)
        {
            ApplicationsInformation Application = ApplicationsInformation.FindApplicationByID(id);
            ApplicationID.Text= Application.ID.ToString();
            FeesLabel.Text=Application.Fees.ToString();
            DateLabel.Text= Application.Date.ToString();    
            StatusDateLabel.Text=Application.LastStatusDate.ToString();
           
            ClassTheUserInformation User = ClassDealWithDataOfTheUsers.FindByID(Application.CreatedByUserID);
            UserLabel.Text= User.UserName;
            StatusLabel.Text= status;
            TypeLabel.Text = ClassDealWithDataOfTheApplication.FindApplicationByID(Application.Type).Title;
            ClassPersonInformation Person = ClassDealWithDataFromThePeople.FindByID(Application.PersonID);
            PersonID=Person.PersonID;
            string FullName = Person.FirstName + Person.SecondName + Person.ThirdName + Person.LastName ;
            ApplicantLabel.Text = FullName;

        }

        public void FillAllTheInfomation(int LocalLicenseid)
        {
            FillTheLocalLicenseInformation(LocalLicenseid);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Person = new ThePersonInformationForm(PersonID);
            Person.ShowDialog();
        }
    }

    
}