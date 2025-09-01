using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Drivers;
using ThePusnissLayer.License;
using ThePusnissLayer.License.InternationalLicense;
using ThePusnissLayer.People;

namespace TheSereens
{
    public partial class PersonLicenseHistory : Form
    {
        string NationalNo;
        ClassPersonInformation person;
        public PersonLicenseHistory(string nationalNo)
        {
            InitializeComponent();
            NationalNo = nationalNo;
        }

        private void FillThePersonInformation()
        {
            ClassPersonInformation person = ClassDealWithDataFromThePeople.FindByNationalID(NationalNo);
            personCard1.FillThePersonInformation(person);  
            this.person = person;
        }

        private DataTable ThePersonLicenseInformations(ClassPersonInformation person)
        {
            ClassDealWithDataOfTheDrivers Driver = ClassDealWithDataOfTheDrivers.FindDriverByID(person.PersonID);
            DataTable DriverLicenses = ClassDealWithLicenseData.PassAllLicenseForTheDriver(Driver.ID);
            if(DriverLicenses.Rows.Count > 0)
            {
                DataTable LicensesData = DriverLicenses.DefaultView.ToTable(false, "LicenseID", "ApplicationID", "IssueDate", "ExpirationDate", "IsActive");
                return LicensesData;
            }
            return null;

        }
        private DataTable ThePersonInternatinalLicenseInformations(ClassPersonInformation person)
        {
            ClassDealWithDataOfTheDrivers Driver = ClassDealWithDataOfTheDrivers.FindDriverByID(person.PersonID);
            DataTable DriverLicenses = ClassDealWithInternationalLicenseData.PassAllInterNationalLicensesForOneDriver(Driver.ID);
            if (DriverLicenses.Rows.Count > 0)
            {
                DataTable LicensesData = DriverLicenses.DefaultView.ToTable(false, "LicenseID", "ApplicationID", "IssueDate", "ExpirationDate", "IsActive");
                return LicensesData;
            }
            return null;

        }
       
        private void FillAllTheInformations()
        {
           PersonLicenses.DataSource= ThePersonLicenseInformations(person);
           InternationalLicenses.DataSource= ThePersonInternatinalLicenseInformations(person);
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void PersonLicenseHistory_Load(object sender, EventArgs e)
        {
            FillThePersonInformation();
            FillAllTheInformations();

        }
    }
}
