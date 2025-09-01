using DVDL_InfrastructureLayer;
using DVDL_Persentation.Tests;
using FormsUtilities.Appointments.AddAppointment;
using FormsUtilities.Appointments.AppointmentInformation;
using FormsUtilities.PersonInformation.PersonCard;
using FormsUtilities.Tests.TestForm;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace DVDL_Persentation.Appointments
{
    public partial class AddAnAppointment : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheLicense;

        private int LocalLicenseID;
        private int Type;
        private readonly IAddAnAppointmentUtility _AddAnAppointmentUtility;
        public AddAnAppointment(int localLicenseID, int type, IAddAnAppointmentUtility _AddAnAppointmentUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._AddAnAppointmentUtility = _AddAnAppointmentUtility;
            this.LocalLicenseID = localLicenseID;
            Type = type;
            licenseInfomations1.SetUtility(_AddAnAppointmentUtility.licenseInformationUtility());
        }

        public void ChangetheTitleAndTheImage(string TestTitle, System.Drawing.Image image)
        {
            TheTitleLabel.Text = TestTitle;
            pictureBox1.BackgroundImage = image;

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (AppointmentData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select An Appointment");
                e.Cancel = true;

            }
        }

        private void AddAnAppointment_Load(object sender, EventArgs e)
        {
            RefreshtheAppointmentsData(this);
        }




    
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bool.Parse(AppointmentData.SelectedRows[0].Cells["IsLocked"].Value.ToString()) == false)
            {
                var Service = Program.ServiceProvider.GetRequiredService<IAppointmentInformationUtility>();
                int.TryParse(AppointmentData.SelectedRows[0].Cells["ID"].Value.ToString(), out int result);
                AppointmentForm Appointment = new AppointmentForm(Service, LocalLicenseID,1, Type);
                Appointment.RefreshTheAppointmentsInformation += RefreshtheAppointmentsData;
                Appointment.ShowDialog();
            }
            else
            {
                MessageBox.Show("this test was took you can not edit it");
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bool.Parse(AppointmentData.SelectedRows[0].Cells["IsLocked"].Value.ToString()) == false)
            {

                int.TryParse(AppointmentData.SelectedRows[0].Cells["ID"].Value.ToString(), out int result);

                var formFactory = Program.ServiceProvider.GetRequiredService<ITestInformationUtility>();
                TestForm form = new TestForm(result,formFactory);
                form.ChangeTheTitleAndTheImage(TheTitleLabel.Text.Replace("Appointment", ""), pictureBox1.BackgroundImage);
                form.RefreshTheLicense += RefreshtheAppointmentsData;
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("This test was took you can not Take it again");
            }
        }




        private void RefreshtheAppointmentsData(object sender)
        {
            licenseInfomations1.FillTheLocalLicenseInformation(LocalLicenseID);

            _AddAnAppointmentUtility.LoadData(LocalLicenseID);
            AppointmentData.DataSource = _AddAnAppointmentUtility.GetData();
            RecordesNumber.Text = _AddAnAppointmentUtility.RecordsNumber().ToString();
            RefreshTheLicense?.Invoke(this);

        }

  
        private void AddAnAppointmentButton_Click_1(object sender, EventArgs e)
        {
            var result = _AddAnAppointmentUtility.CanScheduleAppointment(LocalLicenseID, Type);

            var actions = new Dictionary<IAddAnAppointmentUtility.AppointmentActionResult, Action>
            {
        {
            IAddAnAppointmentUtility.AppointmentActionResult.NewAppointmentAllowed,
            () =>
            {                var Service = Program.ServiceProvider.GetRequiredService<IAppointmentInformationUtility>();

                var form = new AppointmentForm(Service, LocalID: LocalLicenseID, TestTypeID: Type);
                form.RefreshTheAppointmentsInformation += RefreshtheAppointmentsData;
                form.ShowDialog();
            }
        },
        {
            IAddAnAppointmentUtility.AppointmentActionResult.RetestAllowed,
            () =>
            {                var Service = Program.ServiceProvider.GetRequiredService<IAppointmentInformationUtility>();

                var form = new AppointmentForm(Service,LocalID: LocalLicenseID, TestTypeID: Type);
                form.EnapledTheRetestAction();
                form.RefreshTheAppointmentsInformation += RefreshtheAppointmentsData;
                form.ShowDialog();
            }
        },
        {
            IAddAnAppointmentUtility.AppointmentActionResult.AlreadyPassed,
            () => MessageBox.Show("You already passed this test.")
        },
        {
            IAddAnAppointmentUtility.AppointmentActionResult.HasActiveAppointment,
            () => MessageBox.Show("You already have an active appointment.")
        }
    };

            if (actions.TryGetValue(result, out var action))
            {
                action();
            }

        }
    }


}


