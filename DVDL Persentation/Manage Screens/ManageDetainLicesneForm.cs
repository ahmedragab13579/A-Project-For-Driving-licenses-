using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.DetainLicense.Detain;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using FormsUtilities.ManageScreens.ManageDetainLicesne;
using FormsUtilities.PersonInformation.PersonCard;
using FormsUtilities.PersonInformation.PersonLicenseHistory;
using Microsoft.Extensions.DependencyInjection;

namespace DVDL_Persentation.Manage_Screens
{
    public partial class ManageDetainLicesneForm : Form
    {
        private readonly IManageDetainLicenseUtility _IDetainLicenseUtility;

        public ManageDetainLicesneForm(IManageDetainLicenseUtility detainLicenseUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            _IDetainLicenseUtility = detainLicenseUtility;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillFilters()
        {
            TheFiltersCommboBox.Items.Add("None");
            foreach (DataGridViewColumn col in DetainLIceseses.Columns)
            {
                TheFiltersCommboBox.Items.Add(col.Name);
            }
        }


        private void ActiveIsActiveComboBox()
        {
            IsActiveCompoBox.Enabled = true;
            IsActiveCompoBox.Visible = true;
        }
       private void DeActiveIsActiveComboBox()
        {
            IsActiveCompoBox.Enabled = false;
            IsActiveCompoBox.Visible = false;
        }
    
        
        private void DiActiveIsFiltersTextBox()
        {
            textBox1.Enabled = false;
            textBox1.Visible = false;
        }
        private void ActiveIsFiltersTextBox()
        {
            textBox1.Enabled = true;
            textBox1.Visible = true;
        }
        
        private void DiActiveIsDateTime()
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Visible = false;
        }
        private void ActiveIsDateTime()
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker1.Visible = true;
        }
        
        private void ChangeTheFilter()
        {
            if (TheFiltersCommboBox.SelectedItem.ToString() == "IsRelesd")
            {
                ActiveIsActiveComboBox();
                DiActiveIsFiltersTextBox();
                DiActiveIsDateTime();
            }
            if (TheFiltersCommboBox.SelectedItem.ToString() == "Date"|| TheFiltersCommboBox.SelectedItem.ToString() == "RelaseDate")
            {
                ActiveIsDateTime();
                DeActiveIsActiveComboBox();
                DiActiveIsFiltersTextBox();
            }
            else
            {
                ActiveIsFiltersTextBox();
                DeActiveIsActiveComboBox();
                DiActiveIsDateTime();
            }
        }
        private void ManageDetainLicesneForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {

            _IDetainLicenseUtility.LoadData();
            DetainLIceseses.DataSource = _IDetainLicenseUtility.FillTheDetainLicenseData();
            TheRecordesLabel.Text = _IDetainLicenseUtility.FillTheRecordesNumber().ToString();
            FillFilters();
            TheFiltersCommboBox.SelectedIndex = 0;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var InternationalInformation = Program.ServiceProvider.GetRequiredService<IDetainLicenseUtility>();
            Form form = new DetainLicenseFrom(InternationalInformation);
            form.ShowDialog();
        }

        private void perosnInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DetainLIceseses.SelectedRows.Count > 0)
            {
                try
                {
                    var row = DetainLIceseses.SelectedRows[0];

                    if (int.TryParse(row.Cells[0].Value?.ToString(), out int licenseID))
                    {
                        var license = _IDetainLicenseUtility.GetLicenseById(licenseID);

                        if (license != null)
                        {
                            var driver = _IDetainLicenseUtility.GetDriverById(license.DriverID);

                            if (driver != null)
                            {
                                var personForm = Program.ServiceProvider.GetRequiredService<IPersonCardUtility>();
                                Form form = new ThePersonInformationForm(personForm, driver.PersonID);
                                form.ShowDialog();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void licenseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DetainLIceseses.SelectedRows.Count > 0)
            {
                try
                {
                    var row = DetainLIceseses.SelectedRows[0];

                    if (int.TryParse(row.Cells[0].Value?.ToString(), out int licenseID))
                    {
                        var Formfactory = Program.ServiceProvider.GetRequiredService<ILicenseInformationUtility>();
                        Form form = new LocalDrivingLicenseInformations(licenseID, Formfactory);
                        form.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void personHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DetainLIceseses.SelectedRows.Count > 0)
            {
                try
                {
                    var row = DetainLIceseses.SelectedRows[0];

                    if (int.TryParse(row.Cells[0].Value?.ToString(), out int licenseID))
                    {
                        var license = _IDetainLicenseUtility.GetLicenseById(licenseID);

                        if (license != null)
                        {
                            var driver = _IDetainLicenseUtility.GetDriverById(license.DriverID);

                            if (driver != null)
                            {
                                var formFactory = Program.ServiceProvider.GetRequiredService<IPersonLicenseHistoryUtility>();
                                Form form = new PersonLicenseHistory(_IDetainLicenseUtility.GetPersonById(driver.PersonID).NationalNo, formFactory);
                                form.ShowDialog();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DetainLIceseses.DataSource = FilterTheData.MakeAFilter(_IDetainLicenseUtility.GetData(), TheFiltersCommboBox.SelectedItem.ToString(), textBox1.Text);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_IDetainLicenseUtility.IsNumericalColumn(TheFiltersCommboBox.SelectedItem.ToString()))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }

        }

        private void IsActiveCompoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DetainLIceseses.DataSource = FilterTheData.MakeAFilter(_IDetainLicenseUtility.GetData(), TheFiltersCommboBox.SelectedItem.ToString(), (IsActiveCompoBox.SelectedItem.ToString() == "Yes" ? "true" : "false"));

        }

        private void TheFiltersCommboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TheFiltersCommboBox.SelectedItem.ToString() == "None")
            {
                TheFiltersCommboBox.Items.Clear();

                _IDetainLicenseUtility.LoadData();
                DetainLIceseses.DataSource = _IDetainLicenseUtility.FillTheDetainLicenseData();
                TheRecordesLabel.Text = _IDetainLicenseUtility.FillTheRecordesNumber().ToString();
                FillFilters();
                return;
            }
            ChangeTheFilter();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DetainLIceseses.DataSource = FilterTheData.MakeAFilter(_IDetainLicenseUtility.GetData(), TheFiltersCommboBox.SelectedItem.ToString(),dateTimePicker1.Value.ToString());

        }
    }
}
