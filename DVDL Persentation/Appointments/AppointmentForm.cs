using DVDL_Business.After.DTOs;
using DVDL_InfrastructureLayer;
using FormsUtilities.Appointments.AppointmentInformation;

namespace DVDL_Persentation.Tests
{
    public partial class AppointmentForm : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheAppointmentsInformation;
     
        private readonly IAppointmentInformationUtility _AppointmentInformationUtility;

        public AppointmentForm(IAppointmentInformationUtility _AppointmentInformationUtility,int LocalID = -1, int mode = -1, int TestTypeID = 1)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._AppointmentInformationUtility = _AppointmentInformationUtility;
            this._AppointmentInformationUtility.SetAppointmentInformation(LocalID, TestTypeID, mode);
        }






        private void FillTheInformaionForAdd(LocalDrivingLicenseApplication_ViewDto license)
        {

            LicenseClass.Text = license.ClassName;
            PersonNameLabel.Text = license.FullName;
            TrailLabel.Text = "0";
            AppointmentDate.MinDate = DateTime.Now;
            FeesLabel.Text = "60";
        }
     
        private void FillTheInformaionForUpdate(AppointmentDto UpdateAppointment, LocalDrivingLicenseApplication_ViewDto license)
        {
            IDLabel.Text = UpdateAppointment.ID.ToString();
            LicenseClass.Text = license.ClassName;
            PersonNameLabel.Text = license.FullName;
            TrailLabel.Text = "0";
            AppointmentDate.MinDate = DateTime.Now.AddYears(-22);
            AppointmentDate.Value = UpdateAppointment.AppointmentDate;
            FeesLabel.Text = UpdateAppointment.PaidFees.ToString();
        }
        
        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            if (_AppointmentInformationUtility.Mode() == -1)
            {
                FillTheInformaionForAdd(_AppointmentInformationUtility.LicenseView());
            }
            else
            {
                FillTheInformaionForUpdate(_AppointmentInformationUtility.appointmentDto(), _AppointmentInformationUtility.LicenseView());
            }
            FillTheRetestInforamation(IsTheRetestIsAvilable(),_AppointmentInformationUtility.ApplicationFees());
        }
   
        public void EnapledTheRetestAction()
        {
            RetakeTest.Enabled = true;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsTheRetestIsAvilable()
        {
            return RetakeTest.Enabled;
        }
        public void ChangeTheAppointmentImage(Image image)
        {
            pictureBox1.Image = image;

        }
        public void FillTheRetestInforamation(bool IsTheRetestIsValid, decimal Fees)
        {
            if (IsTheRetestIsValid)
            {
                   RetaskAppointmentFees.Text = Fees.ToString();
                   TotalFeesLabel.Text = (decimal.Parse(RetaskAppointmentFees.Text) +
                    decimal.Parse(FeesLabel.Text)).ToString();

            }

        }
        public void SaveTheAppointmentTest(string Fees)
        {
            _AppointmentInformationUtility.FillTheAppointmentInfomationAfterWriteToAddorUpdate(AppointmentDate.Value, Fees);
            MessageBox.Show("Sucsessful Process");
        }
        
        private string Fees()
        {
            if (RetakeTest.Enabled == true)
            {
                return TotalFeesLabel.Text;
               
            }
            return FeesLabel.Text;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (RetakeTest.Enabled == true)
            {
                RetaskApplicationID.Text=_AppointmentInformationUtility. MaketheRetakeTestApplication().ToString();
            }
             SaveTheAppointmentTest(Fees());
            RefreshTheAppointmentsInformation.Invoke(this);
            MessageBox.Show("Save Successfuly");
            this.Close();
        }

        
        
        
        


    }
}
