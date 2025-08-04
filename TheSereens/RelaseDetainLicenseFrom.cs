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
using ThePusnissLayer.Drivers;
using ThePusnissLayer.License;
using ThePusnissLayer.License.DetainLicenses;
using ThePusnissLayer.People;
using ThePusnissLayer.Users;

namespace TheSereens
{
    public partial class RelaseDetainLicenseFrom : Form
    {
        ApplicationsInformation Application = new ApplicationsInformation();
        public RelaseDetainLicenseFrom()
        {
            InitializeComponent();
        }


        private void PerpareTheApplication()
        {
            ClassPersonInformation person = ClassDealWithDataFromThePeople.FindByNationalID(NationalID.Text);
            Application.PersonID = person.PersonID;
           
            Application.Date=DateTime.Now;
            
            Application.Type = 5;
            
            Application.StatusID = 3;
           
            Application.Fees = decimal.Parse(AppFees.Text);
           
            
            Application.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;

        }
     
        
        private void PrepareRelaseDetain()
        {
            ClassDealWithDetainLicenses Licese = ClassDealWithDetainLicenses.FindLicenseByID(int.Parse(LicenseID.Text));
            Licese.IsRelesd = true;
            Licese.RelaseDate = DateTime.Now;
            Licese.RelaisByuser=ClassCurrentUserInformation.CurrentUser.UserID;
            Licese.RelaisAppID=int.Parse(AppRElID.Text);
            Licese.UpdateLicense();
        }
        
        private void FillTheDetainInfo()
        {
            ClassDealWithDetainLicenses Licese = ClassDealWithDetainLicenses.FindLicenseByID(int.Parse(LicenseID.Text));
            TheApplicationTypeInformation App = ClassDealWithDataOfTheApplication.FindApplicationByID(5);
            AppFees.Text=App.Fees.ToString();
            DetainID.Text= Licese.ID.ToString();
            DetainFees.Text =Licese.FineFees.ToString();
            ID.Text = LicenseID.Text;
            User.Text = ClassCurrentUserInformation.CurrentUser.UserName;
            DetainDate.Text = DateTime.Now.ToString();
        }

        private bool IsDetaind()
        {
            if (int.TryParse(FilterTextBox.Text, out int licenseId))
            {
                return ClassDealWithDetainLicenses.ISDetain(licenseId);
            }
            else
            {
                MessageBox.Show("Wrong Number");
                return false;
            }
        }

        private bool IsValidText()
        {
            if (FilterTextBox.Text.Length == 0)
                return false;
            return true;
        }

        private bool IsActiveLicense()
        {
            if (!int.TryParse(FilterTextBox.Text, out int licenseId))
            {
                MessageBox.Show("Please Write  a Number");
                return false;
            }

            return ClassDealWithLicenseData.ISActive(licenseId);
        }

        private void FillTheLicenseInformation()
        {
            ClassDealWithLicenseData License = ClassDealWithLicenseData.FindLicenseByID(int.Parse(FilterTextBox.Text));
            if (License != null)
            {
                ExpirationDate.Text = License.ExpirationDate.ToString();
                IssueDate.Text = License.IssueDate.ToString();
                LicenseID.Text = License.ID.ToString();
                Notes.Text = (Notes.Text == null ? "No Notes" : Notes.Text);
                DriverID.Text = License.DriverID.ToString();
                IsDetaided.Text = false.ToString();
                IsActive.Text = License.IsActive.ToString();
                ClassDealWithDataOfTheDrivers Driver = ClassDealWithDataOfTheDrivers.FindDriverByDriverID(License.DriverID);

                ClassPersonInformation Person = ClassDealWithDataFromThePeople.FindByID(Driver.PersonID);
                string FullName = Person.FirstName + Person.SecondName + Person.ThirdName + Person.LastName;
                PersonName.Text = FullName;
                NationalID.Text = Person.NationalNo;
                Gendor.Text = (Person.Gendor == 1 ? "Male" : "Female");
                DateOfBirth.Text = Person.DateOfBirth.ToString();

                Class.Text = License.LicenseClass.ToString();
                Application.ID = License.ApplicationID;

                ClassLocalLicenseApplicationInfomation LocalLicese =
                ClassDealWithDataOfTheLocalLicenseApplication.
                FindApplicationByApplicationID(License.ApplicationID);
            }

            else
            {
                MessageBox.Show("There Is No User Have This LicenseID");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {

            if (IsValidText())
            {
                if (IsActiveLicense() && !IsDetaind())
                {

                    FillTheLicenseInformation();
                    FillTheDetainInfo();
                    Save.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The License is not active you can not make any operation on it");
                }
            }
            else
            {
                MessageBox.Show("Please Write The License Number");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            PerpareTheApplication();
            AppRElID.Text=Application.Save().ToString();
            PrepareRelaseDetain();
            MessageBox.Show("Relased Sucssesfuly");
        }
    }
}
