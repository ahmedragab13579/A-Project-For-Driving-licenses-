
using DVDL_InfrastructureLayer;
using DVDL_Persentation.License_Information;
using FormsUtilities.LicenseInformation.InternationalLicense.InternationalLicense;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using FormsUtilities.ManageScreens.ManageInternationalLicense;
using FormsUtilities.PersonInformation.PersonCard;
using FormsUtilities.PersonInformation.PersonLicenseHistory;
using Microsoft.Extensions.DependencyInjection;

namespace DVDL_Persentation.Manage_Screens
{
    public partial class ManageInternationalLicense : Form
    {
        IManageInternationalLicenseUtility _ManageInternationalLicenseUtility;

        public ManageInternationalLicense(IManageInternationalLicenseUtility _ManageInternationalLicenseUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._ManageInternationalLicenseUtility = _ManageInternationalLicenseUtility;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Service = Program.ServiceProvider.GetRequiredService<IInternationalLicenseUtility>();

            Form International = new IssueInternationalLicense(Service);
            International.ShowDialog();
        }

        private void FillTheFilters()
        {
            foreach (DataGridViewColumn i in TheInternationalData.Columns)
            {
                Filters.Items.Add(i.Name);

            }
        }
        private void personInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (TheInternationalData.SelectedRows.Count > 0)
            {
                var cellValue = TheInternationalData.SelectedRows[0].Cells["DriverID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int driverID))
                {
                    var Service = Program.ServiceProvider.GetRequiredService<IPersonCardUtility>();
                    ThePersonInformationForm form = new ThePersonInformationForm(Service, _ManageInternationalLicenseUtility.PersonID(driverID));
                    form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("DriverID is not valid.");
                }
            }
            else
            {
                MessageBox.Show("Please select a license.");
            }



        }


        private void personHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheInternationalData.SelectedRows.Count > 0)
            {
                var cellValue = TheInternationalData.SelectedRows[0].Cells["DriverID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int driverID))
                {
                    var formFactory = Program.ServiceProvider.GetRequiredService<IPersonLicenseHistoryUtility>();

                    PersonLicenseHistory form = new PersonLicenseHistory(_ManageInternationalLicenseUtility.PersonNationalNo(driverID), formFactory);

                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("DriverID is not valid.");
                }
            }
            else
            {
                MessageBox.Show("Please select a license.");
            }




        }

        private void ManageInternationalLicense_Load(object sender, EventArgs e)
        {
            _ManageInternationalLicenseUtility.LoadData();
            TheInternationalData.DataSource = _ManageInternationalLicenseUtility.GetData();
            _ManageInternationalLicenseUtility.RecordesNumber();
            FillTheFilters(); 
            Filters.SelectedIndex = 0;

        }

        private void licenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheInternationalData.SelectedRows.Count > 0)
            {
                var cellValue = TheInternationalData.SelectedRows[0].Cells["IssueUsingLicalLicenseID"].Value;
                int.TryParse(TheInternationalData.SelectedRows[0].Cells["ID"].Value.ToString(), out int internationalID);

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int localID))
                {
                    var formFactory = Program.ServiceProvider.GetRequiredService<ILicenseInformationUtility>();
                    LocalDrivingLicenseInformations license = new LocalDrivingLicenseInformations(localID, formFactory);
                    license.FillInternationalLIcenseInformation(internationalID);
                    license.ShowDialog();

                }
                else
                {
                    MessageBox.Show("license is not valid.");
                }
            }
            else
            {
                MessageBox.Show("Please select a license.");
            }

        }

        private void EnabeldTheTimeDialogFilter()
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker1.Visible = true;
            DeciableIsActiveFilter();
            DeciableTextBoxFilter();

        }
        private void EnabeldIsActiveFilter()
        {
            IsActive.Enabled = true;
            IsActive.Visible = true;
            DeciableTextBoxFilter();
            DeciableTheTimeDialogFilter();

        }
        private void EnabeldTextBoxFilter()
        {
            FilterData.Enabled = true;
            FilterData.Visible = true;
            DeciableTheTimeDialogFilter();
            DeciableIsActiveFilter();

        }
   
        
        
        private void DeciableTheTimeDialogFilter()
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Visible = false;

        }
        private void DeciableIsActiveFilter()
        {
            IsActive.Enabled = false;
            IsActive.Visible = false;

        }
        private void DeciableTextBoxFilter()
        {
            FilterData.Enabled = false;
            FilterData.Visible = false;

        }
        private void Filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData.Clear();
            if (Filters.SelectedItem.ToString() == "None")
            {
                _ManageInternationalLicenseUtility.LoadData();
                TheInternationalData.DataSource = _ManageInternationalLicenseUtility.GetData();
                _ManageInternationalLicenseUtility.RecordesNumber();
                FillTheFilters();
                Filters.SelectedIndex = 0; return;
            }
            if (Filters.SelectedItem.ToString() == "IsActive")
            {
                EnabeldIsActiveFilter();
                return;
            }
            if (Filters.SelectedItem.ToString() == "IssueData" || Filters.SelectedItem.ToString() == "ExpirationDate")
            {
                EnabeldTheTimeDialogFilter();
                return;
            }
            EnabeldTextBoxFilter();
        }

        private void IsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filters.SelectedItem.ToString() != "None")
            {
            TheInternationalData.DataSource=  FilterTheData.MakeAFilter(_ManageInternationalLicenseUtility.GetData(),Filters.SelectedItem.ToString(),(IsActive.SelectedItem.ToString()=="Yes"?"true":"false"));

            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (Filters.SelectedItem.ToString() != "None")
            {
            TheInternationalData.DataSource = FilterTheData.MakeAFilter(_ManageInternationalLicenseUtility.GetData(),Filters.SelectedItem.ToString(),dateTimePicker1.Value.ToString());

            }


        }

        private void FilterData_TextChanged(object sender, EventArgs e)
        {
            if (Filters.SelectedItem.ToString() != "None")
            {

            TheInternationalData.DataSource = FilterTheData.MakeAFilter(_ManageInternationalLicenseUtility.GetData(),Filters.SelectedItem.ToString(),FilterData.Text);
            }


        }

        private void FilterData_KeyPress(object sender, KeyPressEventArgs e)
        {
         if(_ManageInternationalLicenseUtility.IsNumcericalCoulumn(Filters.SelectedItem.ToString()))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }
    }
}
