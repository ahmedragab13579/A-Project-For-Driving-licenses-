using DVDL_Business.After.DTOs;
using DVDL_InfrastructureLayer;
using FormsUtilities.Tests.TestForm;


namespace DVDL_Persentation.Tests
{
    public partial class TestForm : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheLicense;
        int AppointmentID;
        private readonly ITestInformationUtility _testInformationUtility;
        public TestForm(int AppointmentID, ITestInformationUtility _testInformationUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this.AppointmentID = AppointmentID;
            this._testInformationUtility = _testInformationUtility;
            this._testInformationUtility.SetAppointmentId(AppointmentID);
        }



        
        private void FillTheAppointmentInformaion(AppointmentDto Appointment)
        {
            _testInformationUtility.GetLocalDrivingLicenseApplicationID(Appointment.LocalDrivingLicenseApplicationID);
            IDLabel.Text = Appointment.ID.ToString();
            LicenseClass.Text = _testInformationUtility.ClassName();
            PersonNameLabel.Text = _testInformationUtility.FullName();
            TrailLabel.Text = "0";
            AppointmentDate.Value = Appointment.AppointmentDate;
            AppointmentDate.Enabled = false;
            FeesLabel.Text = Appointment.PaidFees.ToString();
        }
        public void ChangeTheTitleAndTheImage(string Title,Image image)
        {
            TitleLabel.Text = Title;
            pictureBox1.BackgroundImage = image;

        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            AppointmentDate.Enabled = false;
            FillTheAppointmentInformaion(_testInformationUtility.GetAppointment(AppointmentID));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            TestIDLabel.Text =_testInformationUtility. SaveTheTestInfomation(textBox1.Text, Pass.Checked).ToString();
            RefreshTheLicense?.Invoke(this);
            MessageBox.Show("Save Successfuly");
            this.Close();

        }
    }
}
