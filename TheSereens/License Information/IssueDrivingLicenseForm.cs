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
using ThePusnissLayer.Users;

namespace TheSereens.License_Information
{
    public partial class IssueDrivingLicenseForm : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheLicense;
       
        ClassDealWithLicenseData License;
        
        ClassDealWithDataOfTheDrivers Driver;

        int Local;
        public IssueDrivingLicenseForm(int local)
        {
            InitializeComponent();
            Local = local;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MakeTheApplicationCompleted()
        {
            ClassLocalLicenseApplicationInfomation LocalLicense = ClassDealWithDataOfTheLocalLicenseApplication.FindApplicationByID(Local);
            ApplicationsInformation Application = ApplicationsInformation.FindApplicationByID(LocalLicense.ApplicationID);
            Application.StatusID = 3;
            Application.Save();
        }
      
       
        private int PrepareTheDriverInfomation()
        {
           var Driver= ClassDealWithDataOfTheDrivers.FindDriverByID(licenseInfomations1.PersonID);
            if (Driver == null)
            {
                Driver = new ClassDealWithDataOfTheDrivers(licenseInfomations1.PersonID, ClassCurrentUserInformation.CurrentUser.UserID, DateTime.Now);
                return Driver.AddDriver();
            }
            else
            {
                return Driver.ID;

            }
        }

        private void PrepareTheLicense()
        {
            int DriverID=PrepareTheDriverInfomation();
            ClassLocalLicenseApplicationInfomation LocalLicense = ClassDealWithDataOfTheLocalLicenseApplication.FindApplicationByID(Local);
           DataTable dt= ClassDealWithDataOfLicenseClass.PassAllLicenseClassData();
            DataView LicenseRow = dt.DefaultView;
           LicenseRow.RowFilter = $"LicenseClassID = {LocalLicense.LicenseClassID}";
            DataRow DR = LicenseRow[0].Row;
            DateTime ExDate = DateTime.Now.AddYears(int.Parse(DR["DefaultValidityLength"].ToString()));

            ClassDealWithLicenseData License = new ClassDealWithLicenseData(0,DriverID,LocalLicense.LicenseClassID,LocalLicense.LicenseClassID,
                LocalLicense.ApplicationID,ClassCurrentUserInformation.CurrentUser.UserID,
                DateTime.Now, ExDate,
                (NotesTextBox.Text==""?null: NotesTextBox.Text), true,decimal.Parse( DR["ClassFees"].ToString()) );
                License.AddLicense();
        }
        
        private void IssueDrivingLicenseForm_Load(object sender, EventArgs e)
        {
            licenseInfomations1.FillAllTheInfomation(Local);
        }

        private void Issue_Click(object sender, EventArgs e)
        {
            PrepareTheLicense();
            MakeTheApplicationCompleted();
            RefreshTheLicense?.Invoke(this);
            MessageBox.Show("Wellcome In The Street 👌");
        }
    }
}
