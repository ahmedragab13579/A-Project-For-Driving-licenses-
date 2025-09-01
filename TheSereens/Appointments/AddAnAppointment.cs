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
using TheSereens.Properties;
using TheSereens.Tests;

namespace TheSereens.Appointments
{
    public partial class AddAnAppointment : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheLicense;
        private int LocalLicenseID;
        private int Type;
        public AddAnAppointment(int localLicenseID, int type)
        {
            InitializeComponent();
            this.LocalLicenseID = localLicenseID;
            Type = type;
        }

        public void ChangetheTitleAndTheImage(string TestTitle,Image image)
        {
            TheTitleLabel.Text = TestTitle; 
            pictureBox1.BackgroundImage = image;
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void FillTheAppointmentData()
        {
            DataTable Appointments = ClassDealWithAppointmentData.PassAllAppointmentData(LocalLicenseID);
          if(Appointments.Rows.Count>0)
            {
                DataTable AppointmentViewInformation = Appointments.DefaultView.ToTable(false, "TestAppointmentID", "AppointmentDate", "PaidFees", "IsLocked");
                AppointmentData.DataSource = AppointmentViewInformation;
            }

        }


        private void FillTheRecordes()
        {
            RecordesNumber.Text=AppointmentData.Rows.Count.ToString();
        }

        private void AddAnAppointment_Load(object sender, EventArgs e)
        {
            licenseInfomations1.FillAllTheInfomation(LocalLicenseID);
            FillTheAppointmentData();
            FillTheRecordes();
        }


        private bool IsPasstheTest()
        {
            DataRow row = ClassDealWithAppointmentData.AppointmentRow(LocalLicenseID, Type);
            if (row == null) return false;

            if (row["TestAppointmentID"] != DBNull.Value && int.TryParse(row["TestAppointmentID"].ToString(), out int id))
            {
                var test = ClassDealWithDataOfTheTestType.FindATestByAppointmentID(id);
                return test != null && test.TestResult == true;
            }

            return false;
        }


        private bool IsTheAppointmentIsExist()
        {
            return ClassDealWithAppointmentData.IsAppointmentExist(LocalLicenseID,Type);
        }
       
        private bool IsTheAppointmentIsActive()
        {
            return ClassDealWithAppointmentData.IsAppointmentActive(LocalLicenseID,Type);
        }
     
        private void AddAnAppointmentButton_Click(object sender, EventArgs e)
        {
            if (IsTheAppointmentIsExist() == false)
            {
                AppointmentForm Appointment = new AppointmentForm(LocalID: LocalLicenseID, TestTypeID: Type);
                Appointment.RefreshTheAppointmentsInformation += RefreshtheAppointmentsData;
                Appointment.ShowDialog();
            }
            else
            {
                if (IsTheAppointmentIsActive() == false)
                {
                    if (IsPasstheTest() == false)
                    {
                        AppointmentForm Appointment = new AppointmentForm(LocalID: LocalLicenseID, TestTypeID: Type);
                        Appointment.EnapledTheRetestAction();
                        Appointment.RefreshTheAppointmentsInformation += RefreshtheAppointmentsData;
                        Appointment.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("you pass this test");
                    }


                }
                else
                {
                    MessageBox.Show("you have an Active Appointment ");
                }
            }
        }



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (AppointmentData.SelectedRows.Count==0)
            {
                MessageBox.Show("Please Select An Appointment");
                e.Cancel = true;
               
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bool.Parse(AppointmentData.SelectedRows[0].Cells["IsLocked"].Value.ToString())==false)
            {

                int.TryParse(AppointmentData.SelectedRows[0].Cells["TestAppointmentID"].Value.ToString(), out int result);
                AppointmentForm Appointment = new AppointmentForm(mode: result);
                Appointment.RefreshTheAppointmentsInformation += RefreshtheAppointmentsData;
                Appointment.ShowDialog();
            }
            else
            {
                MessageBox.Show("this test was took you can not edit it");
            }
        }
       
        private void RefreshtheAppointmentsData(object sender)
        {
            AppointmentData.DataSource = null;
            DataTable Appointments = ClassDealWithAppointmentData.PassAllAppointmentData(LocalLicenseID);
            if (Appointments.Rows.Count > 0)
            {
                DataTable AppointmentViewInformation = Appointments.DefaultView.ToTable(false, "TestAppointmentID", "AppointmentDate", "PaidFees", "IsLocked");
                AppointmentData.DataSource = AppointmentViewInformation;
            }
            RefreshTheLicense?.Invoke(this);

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bool.Parse(AppointmentData.SelectedRows[0].Cells["IsLocked"].Value.ToString()) == false)
            {

            int.TryParse(AppointmentData.SelectedRows[0].Cells["TestAppointmentID"].Value.ToString(), out int result);
            TestForm Test = new TestForm(result);
                Test.ChangeTheImage(pictureBox1.BackgroundImage);
            Test.RefreshTheLicense += RefreshtheAppointmentsData;
            Test.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("This test was took you can not Take it again");
            }
        }

      
    }
}
