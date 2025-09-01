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
using ThePusnissLayer.License;
using ThePusnissLayer.Users;
using TheSereens.Appointments;
using TheSereens.Properties;

namespace TheSereens.License_Information
{
    public partial class ManageLocalDrivingLicenseApplicationForm : Form
    {
        enum tests { Vision = 1, Write = 2, Street = 3 }

        public ManageLocalDrivingLicenseApplicationForm()
        {
            InitializeComponent();
        }

        private void AddAllFilters()
        {
            
                TheFiltersCommboBox.Items.Add("LocalDrivingLicenseApplicationID");
                TheFiltersCommboBox.Items.Add("NationalNo");
                TheFiltersCommboBox.Items.Add("FullName");
                TheFiltersCommboBox.Items.Add("Status");

            
        }

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
            if (TheFilterVariableInComboBox == "LocalDrivingLicenseApplicationID" )
            {
                TheFilterInformationTextBox.Mask = "000000000000000000000000";
            }
            else
            {
                TheFilterInformationTextBox.Mask = "";

            }



        }
       
        private void MakeAFilter(string TheFilterVariable, string TheFilter)
        {
            DataView TheFilterData = ClassDealWithDataOfTheLocalLicenseApplication.PassAllTheLocalLicenseApplicationData().DefaultView;

            if (string.IsNullOrWhiteSpace(TheFilter))
            {
                TheFilterData.RowFilter = "";
                TheLocalDrivingLicenseTypeData.DataSource = TheFilterData;
                return;
            }
            if (TheFilterVariable == "LocalDrivingLicenseApplicationID")
            {

                if (int.TryParse(TheFilter, out int numericValue))
                {
                    TheFilterData.RowFilter = $"{TheFilterVariable} = {numericValue}";
                }
                else
                {
                    TheFilterData.RowFilter = "";
                }
            }
            else
            {
                string escaped = TheFilter.Replace("'", "''");
                TheFilterData.RowFilter = $"{TheFilterVariable} LIKE '%{escaped}%'";
            }
            TheLocalDrivingLicenseTypeData.DataSource = TheFilterData;
            FillTheRecords();
        }

        private void FillTheDataOfTheLocalLicenseApplication()
        {
                TheLocalDrivingLicenseTypeData.DataSource =
                ClassDealWithDataOfTheLocalLicenseApplication.
                PassAllTheLocalLicenseApplicationData();
        }
      
        private void FillTheRecords()
        {
           TheRecordesLabel.Text= TheLocalDrivingLicenseTypeData.Rows.Count.ToString();
        }
        
        private void ManageLocalDrivingLicenseApplicationForm_Load(object sender, EventArgs e)
        {
            FillTheDataOfTheLocalLicenseApplication();
            FillTheRecords();
            AddAllFilters();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TheFiltersCommboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMask(TheFiltersCommboBox.SelectedItem.ToString());

        }

        private void TheFilterInformationTextBox_TextChanged(object sender, EventArgs e)
        {
            MakeAFilter(TheFiltersCommboBox.SelectedItem.ToString(),TheFilterInformationTextBox.Text);
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeAFilter(TheFiltersCommboBox.SelectedItem.ToString(), StatusComboBox.SelectedItem.ToString());
        }

        private void AddLocalDrivingApplicationButton_Click(object sender, EventArgs e)
        {
            AddDrivingLicenseForm AddlocalLicense = new AddDrivingLicenseForm(1);
            AddlocalLicense.RefreshLicenseData += RefreshTheLicenseData;
            AddlocalLicense.ShowDialog();
        }

        private void RefreshTheLicenseData(object sender)
        {
            TheLocalDrivingLicenseTypeData.DataSource = null;
            FillTheDataOfTheLocalLicenseApplication();

        }
        
        private void RefreshTheLicenseData()
        {
            TheLocalDrivingLicenseTypeData.DataSource = null;
            FillTheDataOfTheLocalLicenseApplication();

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                int.TryParse(selectedRow.Cells["LocalDrivingLicenseApplicationID"].Value?.ToString(), out int applicationID);
                ClassLocalLicenseApplicationInfomation License= ClassDealWithDataOfTheLocalLicenseApplication.FindApplicationByID(applicationID);
                ApplicationsInformation.CancelAnApplication(License.ApplicationID);
                RefreshTheLicenseData();
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
                var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                int.TryParse(selectedRow.Cells["LocalDrivingLicenseApplicationID"].Value?.ToString(), out int applicationID);
                ClassLocalLicenseApplicationInfomation.DeleteLocalLicenseApplication(applicationID);
                ApplicationsInformation.DeleteApplication(applicationID);
                RefreshTheLicenseData();
                MessageBox.Show("Deleted Sucseccfuly");
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
                var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                int.TryParse(selectedRow.Cells["LocalDrivingLicenseApplicationID"].Value?.ToString(), out int applicationID);
                Form LicenseInformation = new LocalLicenseApplicationInfomationForm(applicationID);
                LicenseInformation.Show();
                MessageBox.Show("Deleted Sucseccfuly");
            }
            else
            {
                MessageBox.Show("Please Select An Application To Cancel");
            }
          
        }

       
        private void PassedTheVisionTest()
        {
            schedualToolStripMenuItem.Enabled = true;
            visnToolStripMenuItem.Enabled = false;
            writinToolStripMenuItem.Enabled = true;
            issueDrivingLicenseToolStripMenuItem.Enabled = false;
            sToolStripMenuItem.Enabled = false;
            streetTestToolStripMenuItem.Enabled = false;
            editTheApplicationToolStripMenuItem.Enabled = true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            cancelApplicationToolStripMenuItem.Enabled = true;

        }
        private void PassedTheWritingTest()
        {
            schedualToolStripMenuItem.Enabled = true;
            visnToolStripMenuItem.Enabled = false;
            writinToolStripMenuItem.Enabled = false ;
            streetTestToolStripMenuItem.Enabled=true;
            issueDrivingLicenseToolStripMenuItem.Enabled = false;
            sToolStripMenuItem.Enabled = false;
            editTheApplicationToolStripMenuItem.Enabled = true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            cancelApplicationToolStripMenuItem.Enabled = true;
        }
        private void PassedTheStreetTest(string Status)
        {
            schedualToolStripMenuItem.Enabled=false;
            if (Status=="Completed") 
            {
                sToolStripMenuItem.Enabled = true;
                 issueDrivingLicenseToolStripMenuItem.Enabled = false;
            }
            else
            {
            issueDrivingLicenseToolStripMenuItem.Enabled = true;
                sToolStripMenuItem.Enabled = false;

            }
            editTheApplicationToolStripMenuItem.Enabled= false;
            deleteApplicationToolStripMenuItem.Enabled=false;
            cancelApplicationToolStripMenuItem.Enabled=false;
        }
        private void NotPassedAnyTest()
        {
            schedualToolStripMenuItem.Enabled=true;
            issueDrivingLicenseToolStripMenuItem.Enabled = false ;
            sToolStripMenuItem.Enabled= false;
            visnToolStripMenuItem.Enabled = true;
            writinToolStripMenuItem.Enabled = false;
            streetTestToolStripMenuItem.Enabled = false;
            editTheApplicationToolStripMenuItem.Enabled= true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            cancelApplicationToolStripMenuItem.Enabled = true;

        }


        private void PrepareTheTest(int TestCompleted ,string Status)
        {
            tests test=(tests)TestCompleted;
            switch(test)
            {
                case tests.Vision:
                    PassedTheVisionTest();
                    break;
                case tests.Write:
                    PassedTheWritingTest();
                    break;
                case tests.Street:
                    PassedTheStreetTest(Status);
                    break;
                default:
                    NotPassedAnyTest();
                    break;

            }
       

        }

        
       
        private void OperationOnLocalDrivingLicense_Opening(object sender, CancelEventArgs e)
        {

            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                

                    var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                    int.TryParse(selectedRow.Cells["PassedTestCount"].Value?.ToString(), out int result);
                    string Statusresult=selectedRow.Cells["Status"].Value?.ToString();
                    PrepareTheTest(result, Statusresult);
               
            }
            else
            {
                MessageBox.Show("Please Select An Application ");
                e.Cancel = true;

            }
        }

        private void visnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                int.TryParse(selectedRow.Cells["LocalDrivingLicenseApplicationID"].Value?.ToString(), out int applicationID);

                AddAnAppointment form = new AddAnAppointment(applicationID,1);
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
                var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                int.TryParse(selectedRow.Cells["LocalDrivingLicenseApplicationID"].Value?.ToString(), out int applicationID);

                AddAnAppointment form = new AddAnAppointment(applicationID, 2);
                form.ChangetheTitleAndTheImage("The Writin Test", Resources.top_view_hand_correcting_grammar_mistakes);
                form.RefreshTheLicense += RefreshTheLicenseData;
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
                var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                int.TryParse(selectedRow.Cells["LocalDrivingLicenseApplicationID"].Value?.ToString(), out int applicationID);

                AddAnAppointment form = new AddAnAppointment(applicationID, 3);
                form.ChangetheTitleAndTheImage("The Streat Test", Resources.traffic_cones_car_driving_license_test);
                form.RefreshTheLicense += RefreshTheLicenseData;
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please Select An Application ");
            }
        }

        private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheLocalDrivingLicenseTypeData.SelectedRows.Count > 0)
            {
                var selectedRow = TheLocalDrivingLicenseTypeData.SelectedRows[0];
                int.TryParse(selectedRow.Cells["LocalDrivingLicenseApplicationID"].Value?.ToString(), out int applicationID);
                IssueDrivingLicenseForm License = new IssueDrivingLicenseForm(applicationID);
                License.RefreshTheLicense += RefreshTheLicenseData;
                License.ShowDialog();
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
                DataRowView drv = (DataRowView)dgvRow.DataBoundItem;
                DataRow dataRow = drv.Row;
                Form License = new LicenseInformations(dataRow);
                License.ShowDialog();
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
               string NationalNo=selectedRow.Cells["NationalNo"].Value?.ToString();
                PersonLicenseHistory Licensens = new PersonLicenseHistory(NationalNo);
                Licensens.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select An Application ");
            }

        }
    }
}
