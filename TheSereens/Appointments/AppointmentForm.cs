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
using ThePusnissLayer.People;
using ThePusnissLayer.Tests;
using ThePusnissLayer.Users;

namespace TheSereens.Tests
{
    public partial class AppointmentForm : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheAppointmentsInformation;
        int LocalID;
        int UpdateMode ;
        int TestTypeID;
        ClassDealWithAppointmentData Appointment = new ClassDealWithAppointmentData();
        public AppointmentForm(int LocalID=-1, int mode=-1,int TestTypeID=1)
        {
            InitializeComponent();
            this.LocalID = LocalID;
            UpdateMode = mode;
            this.TestTypeID = TestTypeID;
        }

        private void FillTheInformaionForAdd()
        {
            DataRow row = ClassDealWithDataOfTheLocalLicenseApplication.
             PassRowFromTheLocalLicenseApplicationData(LocalID);
            LicenseClass.Text = row["ClassName"].ToString();
            PersonNameLabel.Text = row["FullName"].ToString();
            TrailLabel.Text = "0";
            AppointmentDate.MinDate=DateTime.Now;
            FeesLabel.Text=
                ClassDealWithDataOfTheTestType.FindTestByID(1).Fees.ToString();
        }
     
        public void ChangeTheAppointmentImage(Image image)
        {
            pictureBox1.Image = image;

        }
       
        public void EnapledTheRetestAction()
        {
            RetakeTest.Enabled = true;
        }
        
        private void FillTheInformaionForUpdate()
        {
            ClassDealWithAppointmentData UpdateAppointment= ClassDealWithAppointmentData.FindAppointmentByID(UpdateMode);
            Appointment = UpdateAppointment;
            IDLabel.Text = UpdateAppointment.ID.ToString();
            DataRow row = ClassDealWithDataOfTheLocalLicenseApplication.
            PassRowFromTheLocalLicenseApplicationData(UpdateAppointment.LocalDrivingLicenseApplicationID);
            LocalID = UpdateAppointment.LocalDrivingLicenseApplicationID;
            LicenseClass.Text = row["ClassName"].ToString();
            PersonNameLabel.Text = row["FullName"].ToString();
            TrailLabel.Text = "0";
            AppointmentDate.MinDate= DateTime.Now;
            AppointmentDate.Value = UpdateAppointment.AppointmentDate;
            FeesLabel.Text=UpdateAppointment.PaidFees.ToString();
        }


        private bool IsTheRetestIsAvilable()
        {
            return RetakeTest.Enabled;
        }
       
        public void FillTheRetestInforamation()
        {
            if(IsTheRetestIsAvilable())
            {
                TheApplicationTypeInformation App = ClassDealWithDataOfTheApplication.FindApplicationByID(6);
                RetaskAppointmentFees.Text = App.Fees.ToString();
                TotalFeesLabel.Text=(decimal.Parse(RetaskAppointmentFees.Text)+
                    decimal.Parse(FeesLabel.Text)).ToString();

            }
           
        }
        
        private void MaketheRetakeTestApplication()
        {
            DataRow row = ClassDealWithDataOfTheLocalLicenseApplication.
                PassRowFromTheLocalLicenseApplicationData(LocalID);
            ClassPersonInformation person = ClassDealWithDataFromThePeople.FindByNationalID(row["NationalNo"].ToString());
            TheApplicationTypeInformation Apptype = ClassDealWithDataOfTheApplication.FindApplicationByID(6);
            ApplicationsInformation App = new ApplicationsInformation
                (person.PersonID,DateTime.Now,8,1,DateTime.Now, Apptype.Fees,ClassCurrentUserInformation.CurrentUser.UserID);
            App.Save();

        }
       
        private void FillTheAppointmentInfomationAfterWriteToAddorUpdate()
        {
            if (UpdateMode==-1)
            {
                Appointment.TestTypeID = TestTypeID;
                Appointment.LocalDrivingLicenseApplicationID = LocalID;
                Appointment.AppointmentDate = AppointmentDate.Value;
                Appointment.IsLocked = false;
                Appointment.PaidFees = decimal.Parse(FeesLabel.Text);
                Appointment.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
            }
            else
            {
                FillTheAppointmentInfomationAfterWriteToUpdate();
            }
           
        }
       
        private void FillTheAppointmentInfomationAfterWriteToUpdate()
        {
                Appointment = new ClassDealWithAppointmentData(Appointment.ID, Appointment.TestTypeID, AppointmentDate.Value,Appointment.LocalDrivingLicenseApplicationID,Appointment.PaidFees,Appointment.CreatedByUserID,Appointment.IsLocked);
        }
      
        private void SaveTheAppointmentTest()
        {
            FillTheAppointmentInfomationAfterWriteToAddorUpdate();
            IDLabel.Text = Appointment.Save().ToString();
            RefreshTheAppointmentsInformation?.Invoke(this);
            MessageBox.Show("Sucsessful Process");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(RetakeTest.Enabled==true)
            {
                MaketheRetakeTestApplication();
            }
            SaveTheAppointmentTest();
            MessageBox.Show("Save Successfuly");
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            if (UpdateMode == -1)
            {
                FillTheInformaionForAdd();
                FillTheRetestInforamation();
            }
            else
            {
                FillTheInformaionForUpdate();
                FillTheRetestInforamation();
            }
        }
    }
}
