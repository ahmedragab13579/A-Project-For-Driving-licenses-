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
using ThePusnissLayer.License_Application;
using ThePusnissLayer.People;
using ThePusnissLayer.Users;
using static System.Net.Mime.MediaTypeNames;

namespace TheSereens
{
    public partial class ChangeLicenseForLostOrDamage : Form
    {
        ApplicationsInformation Application = new ApplicationsInformation();
        ClassDealWithLicenseData License ;
        ClassDealWithLicenseData LocalLicense;
        int TypeId;
        int localID;
        public ChangeLicenseForLostOrDamage()
        {
            InitializeComponent();
        }

        private void FillTheLicenseInformation()
        {
            ClassDealWithLicenseData License = ClassDealWithLicenseData.FindLicenseByID(int.Parse(FilterTextBox.Text));
            if (License != null)
            {
                LocalLicense = License;
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
                localID = License.ID;
            }

            else
            {
                MessageBox.Show("There Is No User Have This LicenseID");
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


        private void search_Click_1(object sender, EventArgs e)
        {
            if(IsValidText())
            {
                if (IsActiveLicense())
                {

                    FillTheLicenseInformation();
                    FillTheReplaceApplicationID();
                    Issue.Enabled = true;
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTheReplaceApplicationID()
        {
            RepAppDate.Text = DateTime.Now.ToString();
            OldLicId.Text = LicenseID.Text;
            CreatedUser.Text=ClassCurrentUserInformation.CurrentUser.UserName;

        }

        private void Damage_CheckedChanged(object sender, EventArgs e)
        {
            decimal fees = 0;
            if(Damage.Checked==true)
            {
                fees=ClassDealWithDataOfTheApplication.FindApplicationByID(4).Fees;
                TypeId = 4;
                RepAppFees.Text=fees.ToString();
            }
            else
            {
                fees = ClassDealWithDataOfTheApplication.FindApplicationByID(3).Fees;
                TypeId = 3;
                RepAppFees.Text = fees.ToString();
            }
            RepAppFees.Text=fees.ToString();
        }

        private void Lost_CheckedChanged(object sender, EventArgs e)
        {
            decimal fees = 0;
            if (Damage.Checked == true)
            {
                fees = ClassDealWithDataOfTheApplication.FindApplicationByID(4).Fees;
                TypeId = 4;
                RepAppFees.Text = fees.ToString();
            }
            else
            {
                fees = ClassDealWithDataOfTheApplication.FindApplicationByID(3).Fees;
                TypeId = 3;
                RepAppFees.Text = fees.ToString();
            }
            RepAppFees.Text = fees.ToString();
        }

        private void DeactivatedTheOldLicense()
        {
            ClassDealWithLicenseData.DeactivateTheOldLicense(int.Parse(FilterTextBox.Text));
        }

        private void prepareTheNewApplication()
        {
            ClassPersonInformation person = ClassDealWithDataFromThePeople.FindByNationalID(NationalID.Text);
            /* = new ApplicationsInformation(person.PersonID,DateTime.Now,TypeId,3,DateTime.Now,
             * decimal.Parse(RepAppFees.Text),ClassCurrentUserInformation.CurrentUser.UserID);*/
            Application.PersonID = person.PersonID;
            Application.Date = DateTime.Now;
            Application.LastStatusDate= DateTime.Now;
            Application.Fees = decimal.Parse(RepAppFees.Text);
            Application.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
            Application.Type = TypeId;
            Application.ID = 0;
        }
     
        private void prepareTheNewLicense()
        {
            prepareTheNewApplication();
            ReplaceAppID.Text = Application.Save().ToString();
            DataTable dt = ClassDealWithDataOfLicenseClass.PassAllLicenseClassData();
            DataView LicenseRow = dt.DefaultView;
            LicenseRow.RowFilter = $"LicenseClassID = {int.Parse(Class.Text)}";
            DataRow DR = LicenseRow[0].Row;
            DateTime ExDate = DateTime.Now.AddYears(int.Parse(DR["DefaultValidityLength"].ToString()));

            License = new ClassDealWithLicenseData(0, int.Parse(DriverID.Text), int.Parse(Class.Text), TypeId,
                Application.ID, ClassCurrentUserInformation.CurrentUser.UserID,
                DateTime.Now, ExDate, null, true, decimal.Parse(DR["ClassFees"].ToString()));
        }
        private void Issue_Click(object sender, EventArgs e)
        {
           
            prepareTheNewLicense();
            RepLicID.Text=License.AddLicense().ToString();

            Issue.Enabled = false;
            FilterTextBox.Enabled = false;
            search.Enabled = false;
            DeactivatedTheOldLicense();
            MessageBox.Show("Added Sucseccfuly");

        }

        private void ShowHistoryLicenses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form History = new PersonLicenseHistory(NationalID.Text);
            History.ShowDialog();

        }

        private void ShowNewLicenseInformarion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form LIcenese = new LicenseInformations(ClassDealWithDataOfTheLocalLicenseApplication.
            PassRowFromTheLocalLicenseApplicationData(this.localID));
            LIcenese.ShowDialog();


        }
    }
}
