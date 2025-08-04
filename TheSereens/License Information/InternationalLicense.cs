using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Applications.LocalLisense;
using ThePusnissLayer.Drivers;
using ThePusnissLayer.License;
using ThePusnissLayer.License.InternationalLicense;
using ThePusnissLayer.People;
using ThePusnissLayer.Users;

namespace TheSereens.License_Information
{
    public partial class InternationalLicense : UserControl
    {
        int ApplicationID;
        ClassDealWithLicenseData LocalLicense;
        int localID;
        public InternationalLicense()
        {
            InitializeComponent();
        }


        private bool IsValidText()
        {
            if(FilterTextBox.Text.Length == 0)
                return false;
            return true;
        }
       
        private void FillTheApplicationInformation(int id)
        {
            licenseInfomations1.FillAllTheInfomation(id);
        }


        private void FillTheLicenseInformation()
        {
            ClassDealWithLicenseData License = ClassDealWithLicenseData.FindLicenseByID(int.Parse(FilterTextBox.Text));
            if(License != null)
            {
                LocalLicense = License;
                ExpirationDate.Text = License.ExpirationDate.ToString();
                IssueDate.Text = License.IssueDate.ToString();
                LicenseID.Text=License.ID.ToString();
                Notes.Text=(Notes.Text==null?"No Notes":Notes.Text);
                DriverID.Text=License.DriverID.ToString();
                IsDetaided.Text = false.ToString();
                IsActive.Text=License.IsActive.ToString();
                ClassDealWithDataOfTheDrivers Driver = ClassDealWithDataOfTheDrivers.FindDriverByDriverID(License.DriverID);
               
                    ClassPersonInformation Person = ClassDealWithDataFromThePeople.FindByID(Driver.PersonID);
                    string FullName = Person.FirstName + Person.SecondName + Person.ThirdName + Person.LastName;
                    PersonName.Text = FullName;
                    NationalID.Text = Person.NationalNo;   
                    Gendor.Text = (Person.Gendor == 1 ? "Male" : "Female");
                    DateOfBirth.Text = Person.DateOfBirth.ToString();
                    Class.Text = License.LicenseClass.ToString();
                    ApplicationID = License.ApplicationID;

                    ClassLocalLicenseApplicationInfomation LocalLicese =
                    ClassDealWithDataOfTheLocalLicenseApplication.
                    FindApplicationByApplicationID(License.ApplicationID);
                    localID = License.ID;
                    FillTheApplicationInformation(LocalLicese.ID);
            
            }

            else
            {
                MessageBox.Show("There Is No User Have This LicenseID");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if(IsValidText())
            {
                if (LocalLicense.LicenseClass==3)
                {
                    FillTheLicenseInformation();
                }
                else
                {
                    MessageBox.Show("Your license must be  Class 3 - Ordinary driving license");
                }

            }
            else
            {
                MessageBox.Show("Please Write The License ID");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!ClassDealWithInternationalLicenseData.ISTheLicenseExist(ApplicationID))
            {
                ClassDealWithInternationalLicenseData InterLicense = new ClassDealWithInternationalLicenseData();
                InterLicense.ApplicationID = ApplicationID;
                InterLicense.DriverID = LocalLicense.DriverID;
                InterLicense.IssueData=LocalLicense.IssueDate;
                InterLicense.ExpirationDate = LocalLicense.ExpirationDate;
                InterLicense.IsActive=LocalLicense.IsActive;
                InterLicense.CreatedByuserID=ClassCurrentUserInformation.CurrentUser.UserID;
                InterLicense.IssueUsingLicalLicenseID = localID;
                InterLicense.AddTheInternationalLicense();
                MessageBox.Show("Added Sucssecfuly");
                InternationalLiceseInformation.Enabled = true;

            }
            else 
            {
                MessageBox.Show("You Already Have an InternationalLicese");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form License = new LocalLicenseApplicationInfomationForm(localID);
            License.ShowDialog();
        }

        private void InternationalLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
