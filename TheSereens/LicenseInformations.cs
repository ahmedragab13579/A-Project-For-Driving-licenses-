using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Applications.LocalLisense;
using ThePusnissLayer.Drivers;
using ThePusnissLayer.License;
using ThePusnissLayer.People;

namespace TheSereens
{
    public partial class LicenseInformations : Form
    {
        DataRow LocalLicenseRow;
        public LicenseInformations(DataRow localLicenseRow)
        {
            InitializeComponent();
            LocalLicenseRow = localLicenseRow;
        }

        private void FillTheLicenseInformation()
        {
            Class.Text = LocalLicenseRow["ClassName"].ToString();
            Name.Text = LocalLicenseRow["FullName"].ToString();
            NationalID.Text = LocalLicenseRow["NationalNo"].ToString();
            ClassPersonInformation person = ClassDealWithDataFromThePeople.FindByNationalID(LocalLicenseRow["NationalNo"].ToString());
            Gendor.Text=(person.Gendor==1?"Male":"Female");
            DateOfBirth.Text=person.DateOfBirth.ToString();
            ClassDealWithDataOfTheDrivers Driver = ClassDealWithDataOfTheDrivers.FindDriverByID(person.PersonID);
            DriverID.Text=Driver.ID.ToString();
            ClassLocalLicenseApplicationInfomation LocalLicense = ClassDealWithDataOfTheLocalLicenseApplication.
            FindApplicationByID(int.Parse(LocalLicenseRow["LocalDrivingLicenseApplicationID"].ToString()));
            ClassDealWithLicenseData License = ClassDealWithLicenseData.FindLicenseByApplicationID(LocalLicense.ApplicationID);
            LicenseID.Text=License.ID.ToString();
            IssueDate.Text=License.IssueDate.ToString();
            IsssueReason.Text=License.IssueReason.ToString();
            Notes.Text=(License.Notes==null?"No Notes": License.Notes);
            IsActive.Text=License.IsActive.ToString();
            ExpirationDate.Text=License.ExpirationDate.ToString();
            IsDetaided.Text=false.ToString();
            if (File.Exists(person.ImagePath))
            {
                pictureBox2.BackgroundImage = Image.FromFile(person.ImagePath);
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LicenseInformations_Load(object sender, EventArgs e)
        {
            FillTheLicenseInformation();
        }
    }
}
