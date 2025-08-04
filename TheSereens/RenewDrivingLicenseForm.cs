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
    public partial class RenewDrivingLicenseForm : Form
    {
        int localID;
        ApplicationsInformation Application =new ApplicationsInformation();
        ClassDealWithLicenseData License;
        public RenewDrivingLicenseForm()
        {
            InitializeComponent();
        }



        private void DeactivatedTheOldLicense()
        {
            ClassDealWithLicenseData.DeactivateTheOldLicense(int.Parse(FilterTextBox.Text));
        }
     
        private bool IsTheLicenseExpired()
        {
            DateTime expDate = License.ExpirationDate;
            return DateTime.Now > expDate;
        }

        private bool IsTheLIceseActive()
        {
            return License.IsActive;
        }
       
        private bool IsValidText()
        {
            if (FilterTextBox.Text.Length == 0)
                return false;
            return true;
        }
       
        private void FillTheLicenseInformation()
        {
            ClassDealWithLicenseData License = ClassDealWithLicenseData.FindLicenseByID(int.Parse(FilterTextBox.Text));
           this. License= License;
            if (License != null)
            {
                if (IsTheLicenseExpired())
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
                   this.Application.ID = License.ApplicationID;

                    ClassLocalLicenseApplicationInfomation LocalLicese =
                    ClassDealWithDataOfTheLocalLicenseApplication.
                    FindApplicationByApplicationID(License.ApplicationID);
                    this.localID= LocalLicese.ID;
                }
                else
                {
                    MessageBox.Show($"Your License Is not Expired To : {License.ExpirationDate}");
                }
            }

            else
            {
                MessageBox.Show("There Is No Driver Have This LicenseID");
            }
        }

        private void PrepareTheNewLicese()
        {
            DataTable dt = ClassDealWithDataOfLicenseClass.PassAllLicenseClassData();
            DataView LicenseRow = dt.DefaultView;
            LicenseRow.RowFilter = $"LicenseClassID = {int.Parse(Class.Text)}";
            DataRow DR = LicenseRow[0].Row;
            DateTime ExDate = DateTime.Now.AddYears(int.Parse(DR["DefaultValidityLength"].ToString()));

            this. License = new ClassDealWithLicenseData(0,int.Parse(DriverID.Text),int.Parse(Class.Text),2,Application.ID,ClassCurrentUserInformation.CurrentUser.UserID,DateTime.Now, ExDate, (Notes.Text == "" ? null : Notes.Text), true, decimal.Parse( DR["ClassFees"].ToString()));
            this.License.AddLicense();

        }
        private void PrepareTheRenewApplicationInfomration()
        {
            ApplicationsInformation application = new ApplicationsInformation();
            ClassPersonInformation person = ClassDealWithDataFromThePeople.FindByNationalID(NationalID.Text);
            application.PersonID = person.PersonID;
            application.LastStatusDate = DateTime.Now;
            application.Date = DateTime.Now;
            application.StatusID = 3;
            application.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
            TheApplicationTypeInformation type = ClassDealWithDataOfTheApplication.FindApplicationByID(2);
            application.Fees = type.Fees;
            application.Type = type.ID;
            application.Save();
        }
     
        private void FillTheInformationLabels()
        {
            this.Application = ApplicationsInformation.FindApplicationByID(this.Application.ID);
            RenewAppID.Text=Application.ID.ToString();
            AppDate.Text=Application.Date.ToString();
            NewLiceenseIssueDate.Text=Application.Date.ToString();
            AppFees.Text=Application.Fees.ToString();
            LicenseFees.Text = License.Fees.ToString();
            RenewLicenseID.Text=License.ID.ToString();
            OldLicenseID.Text=LicenseID.Text;
            ExpData.Text=License.ExpirationDate.ToString();
            CreatedID.Text = ClassCurrentUserInformation.CurrentUser.UserName;
            TotalFees.Text=(Application.Fees+License.Fees).ToString();
            Renew.Enabled = true;
        }
        

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Click_1(object sender, EventArgs e)
        {

            if (IsValidText())
            {
                FillTheLicenseInformation();
                FillTheInformationLabels();
            }
            else
            {
                MessageBox.Show("Please Write The License ID");
            }
        }

        private void Renew_Click(object sender, EventArgs e)
        {
            if (IsTheLIceseActive())
            {
                PrepareTheRenewApplicationInfomration();
                PrepareTheNewLicese();
                DeactivatedTheOldLicense();
                MessageBox.Show("Renewed Sucsessfuly ");
                ShowHistoryLicenses.Enabled = true;
                ShowNewLicenseInformarion.Enabled = true;
            }
            else
            {
                MessageBox.Show("Your License is not active you can not Renew it");
            }

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
