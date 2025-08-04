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
using ThePusnissLayer.Appointments;
using ThePusnissLayer.Tests;
using ThePusnissLayer.Users;

namespace TheSereens.Tests
{
    public partial class TestForm : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheLicense;
        int AppointmentID;
        public TestForm(int AppointmentID)
        {
            InitializeComponent();
            this.AppointmentID = AppointmentID;
        }

        public void ChangeTheImage(Image image)
        {
            pictureBox1.BackgroundImage = image;

        }
      
        private void FillTheAppointmentInformaion()
        {
            ClassDealWithAppointmentData Appointment = ClassDealWithAppointmentData.FindAppointmentByID(AppointmentID);
            IDLabel.Text = Appointment.ID.ToString();
            DataRow row = ClassDealWithDataOfTheLocalLicenseApplication.
            PassRowFromTheLocalLicenseApplicationData(Appointment.LocalDrivingLicenseApplicationID);
            LicenseClass.Text = row["ClassName"].ToString();
            PersonNameLabel.Text = row["FullName"].ToString();
            TrailLabel.Text = "0";
            AppointmentDate.Value = Appointment.AppointmentDate;
            AppointmentDate.Enabled = false;
            FeesLabel.Text = Appointment.PaidFees.ToString();
        }

        private void SaveTheTestInfomation()
        {
            ClassDealWithDataOfTheTestType test=new ClassDealWithDataOfTheTestType();
            test.Notes=textBox1.Text;
            test.TestResult = (Pass.Checked == true ? true : false);
            test.TestAppointmentID=AppointmentID;
            test.UserID=ClassCurrentUserInformation.CurrentUser.UserID;
            test.ID=test.AddNewTest();
            TestIDLabel.Text = test.ID.ToString();
            ClassDealWithAppointmentData appointment = ClassDealWithAppointmentData.FindAppointmentByID(AppointmentID);
           appointment.IsLocked = true; 
            appointment.Save();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            AppointmentDate.Enabled = false;
            FillTheAppointmentInformaion();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveTheTestInfomation();
            RefreshTheLicense?.Invoke(this);
            MessageBox.Show("Save Successfuly");
            this.Close();

        }
    }
}
