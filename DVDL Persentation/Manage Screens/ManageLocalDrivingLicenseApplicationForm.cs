
using DVDL_InfrastructureLayer;
using DVDL_Persentation.Appointments;
using FormsUtilities.Appointments.AddAppointment;
using FormsUtilities.LicenseInformation.LocalLicense.AddDrivingLicense;
using FormsUtilities.LicenseInformation.LocalLicense.IssueDrivinglIcense;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Utilitys;
using FormsUtilities.PersonInformation.PersonLicenseHistory;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace DVDL_Persentation.License_Information
{
    public partial class ManageLocalDrivingLicenseApplicationForm : Form
    {
        enum tests { Vision = 1, Write = 2, Street = 3 }


        IManageLocalDrivingLIcenseUtility _ManageLocalDrivingLIcenseUtility;
        public ManageLocalDrivingLicenseApplicationForm(IManageLocalDrivingLIcenseUtility _ManageLocalDrivingLIcenseUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._ManageLocalDrivingLIcenseUtility = _ManageLocalDrivingLIcenseUtility;
        }
        #region Finished
        private void ChangeMask(string TheFilterVariableInComboBox)
        {
            if (TheFilterVariableInComboBox == "Status")
            {
                StatusComboBox.Visible = true;
                StatusComboBox.Enabled = true;
                TheFilterInformationTextBox.Visible = false;
                TheFilterInformationTextBox.Enabled = false;


            }
            else
            {
                StatusComboBox.Visible = false;
                StatusComboBox.Enabled = false;
                TheFilterInformationTextBox.Visible = true;
                TheFilterInformationTextBox.Enabled = true;

            }



        }
        private int GetLocaDrivingLicenseID()
        {
            var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
            int.TryParse(selectedRow.Cells["LocalDrivingLicenseApplicationID"].Value?.ToString(), out int applicationID);
            return applicationID;
        }
        private void PrepareTheTest(int PassTestCount, string Status)
        {
            var StatusOfMenu = _ManageLocalDrivingLIcenseUtility.GetState(PassTestCount, Status);

            schedualToolStripMenuItem.Enabled = StatusOfMenu.ScheduleEnabled;
            visnToolStripMenuItem.Enabled = StatusOfMenu.VisionEnabled;
            writinToolStripMenuItem.Enabled = StatusOfMenu.WritingEnabled;
            streetTestToolStripMenuItem.Enabled = StatusOfMenu.StreetEnabled;
            issueDrivingLicenseToolStripMenuItem.Enabled = StatusOfMenu.IssueEnabled;
            sToolStripMenuItem.Enabled = StatusOfMenu.ShowLicenseInfoEnabled;
            deleteApplicationToolStripMenuItem.Enabled = StatusOfMenu.DeleteEnabled;
            cancelApplicationToolStripMenuItem.Enabled = StatusOfMenu.CancelEnabled;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ManageLocalDrivingLicenseApplicationForm_Load(object sender, EventArgs e)
        {
            RefreshTheLicenseData(sender);
            TheFiltersCommboBox.SelectedIndex = 0;
        }
        private void RefreshTheLicenseData(object sender)
        {
            TheLocalDrivingLicenseTypeData.DataSource = null;
            _ManageLocalDrivingLIcenseUtility.LoadData();
            TheLocalDrivingLicenseTypeData.DataSource = _ManageLocalDrivingLIcenseUtility.GetData();
            TheFiltersCommboBox.Items.AddRange(_ManageLocalDrivingLIcenseUtility.AddAllFilters().ToArray());
            TheRecordesLabel.Text = _ManageLocalDrivingLIcenseUtility.FillRecoreds().ToString();
        }
        private void TheFilterInformationTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if(TheFiltersCommboBox.SelectedItem.ToString()!="None")
            {
             TheLocalDrivingLicenseTypeData.DataSource = FilterTheData.MakeAFilter(_ManageLocalDrivingLIcenseUtility.GetData(),TheFiltersCommboBox.SelectedItem.ToString(), TheFilterInformationTextBox.Text);

            }

        }

        private void TheFilterInformationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TheFiltersCommboBox.SelectedItem != null
                && TheFiltersCommboBox.SelectedItem.ToString() == "LocalDrivingLicenseApplicationID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private void TheFiltersCommboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMask(TheFiltersCommboBox.SelectedItem.ToString());
            if(TheFiltersCommboBox.SelectedItem.ToString()=="None")
            {
                Refresh();
                return;

            }
            TheFilterInformationTextBox.Clear();

        }
        private void AddLocalDrivingApplicationButton_Click(object sender, EventArgs e)
        {
            var formfactor = Program.ServiceProvider.GetRequiredService<IAddDrivingLIcenseUtility>();

            AddLocalDrivingLicenseApplicationForm form = new AddLocalDrivingLicenseApplicationForm(formfactor);
            form.ShowDialog();
            form.RefreshLicenseData += RefreshTheLicenseData;
        }
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TheFiltersCommboBox.SelectedItem.ToString() != "None")
            {
               TheLocalDrivingLicenseTypeData.DataSource = FilterTheData.MakeAFilter(_ManageLocalDrivingLIcenseUtility.GetData(),TheFiltersCommboBox.SelectedItem.ToString(), StatusComboBox.SelectedItem.ToString());

            }
        }
        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                _ManageLocalDrivingLIcenseUtility.CancelApplication(_ManageLocalDrivingLIcenseUtility.ApplicationID(GetLocaDrivingLicenseID()));
                RefreshTheLicenseData(sender);
                MessageBox.Show("Cancelled Sucseccfuly");
            }
            else
            {
                MessageBox.Show("Please Select An Application To Cancel");
            }
        }
        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                try
                {
                    int AppID = GetLocaDrivingLicenseID();
                    _ManageLocalDrivingLIcenseUtility.DeleteLocalApplication(AppID);
                    _ManageLocalDrivingLIcenseUtility.DeleteApplication(AppID);
                    RefreshTheLicenseData(sender);
                    MessageBox.Show("Deleted Sucseccfuly");

                }
                catch
                {
                    MessageBox.Show("You Can NOt Delete The Application Because It has A Connected Data");

                }
            }
            else
            {
                MessageBox.Show("Please Select An Application To Cancel");
            }
        }
        private void showApplicationDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                var Service = Program.ServiceProvider.GetRequiredService<ILicenseInformationUtility>();


                Form LicenseInformation = new LocalLicenseApplicationInfomationForm(GetLocaDrivingLicenseID(), Service);
                LicenseInformation.Show();
            }
            else
            {
                MessageBox.Show("Please Select An Application To Make Details");
            }

        }

        private void OperationOnLocalDrivingLicense_Opening(object sender, CancelEventArgs e)
        {

            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {


                var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                int.TryParse(selectedRow.Cells["PassedTestCount"].Value?.ToString(), out int result);
                string Statusresult = selectedRow.Cells["Status"].Value?.ToString();
                PrepareTheTest(result, Statusresult);

            }
            else
            {
                MessageBox.Show("Please Select An Application ");
                e.Cancel = true;

            }
        }
        private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                var formFactory = Program.ServiceProvider.GetRequiredService<IIssueDrivingLicenseUtility>();
                Form form = new IssueLocalDrivingLicenseForm(GetLocaDrivingLicenseID(), formFactory);
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please Select An Application ");
            }
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                string NationalNo = selectedRow.Cells["NationalNo"].Value?.ToString();
                var formFactory = Program.ServiceProvider.GetRequiredService<IPersonLicenseHistoryUtility>();
                Form form = new PersonLicenseHistory(NationalNo, formFactory);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select An Application ");
            }

        }


        #endregion Finished

        private void visnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {

                var formFactory = Program.ServiceProvider.GetRequiredService<IAddAnAppointmentUtility>();
                AddAnAppointment form = new AddAnAppointment(GetLocaDrivingLicenseID(), (int)tests.Vision, formFactory);
                form.RefreshTheLicense += RefreshTheLicenseData;
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please Select An Application ");
            }
        }
        private void writinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                var formFactory = Program.ServiceProvider.GetRequiredService<IAddAnAppointmentUtility>();
                AddAnAppointment form = new AddAnAppointment(GetLocaDrivingLicenseID(), (int)tests.Write, formFactory);
                form.RefreshTheLicense += RefreshTheLicenseData;
                form.ChangetheTitleAndTheImage("Writien Test Appointment",DVDL_Persentation.Properties.Resource.Written_Test_512);
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please Select An Application ");
            }
        }
        private void streetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                var formFactory = Program.ServiceProvider.GetRequiredService<IAddAnAppointmentUtility>();
                AddAnAppointment form = new AddAnAppointment(GetLocaDrivingLicenseID(), (int)tests.Street, formFactory);
                form.RefreshTheLicense += RefreshTheLicenseData;
                form.ChangetheTitleAndTheImage("Street Test Appointment",DVDL_Persentation.Properties.Resource.driving_test_512);

                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select An Application ");
            }
        }
        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                int.TryParse(dgvRow.Cells[0].Value.ToString(), out int result);
                var formFactory = Program.ServiceProvider.GetRequiredService<ILicenseInformationUtility>();
                LocalDrivingLicenseInformations form = new LocalDrivingLicenseInformations(_ManageLocalDrivingLIcenseUtility.LocalDrivingLicenseID(result), formFactory);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select An Application ");
            }

        }

     
    }
}
