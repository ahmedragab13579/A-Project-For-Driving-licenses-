using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Applications.LocalLisense;
using ThePusnissLayer.Drivers;
using ThePusnissLayer.License;
using ThePusnissLayer.License.DetainLicenses;
using ThePusnissLayer.People;

namespace TheSereens.Manage_Screens
{
    public partial class ManageDetainLicesneForm : Form
    {
        public ManageDetainLicesneForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTheRecordesNumber()
        {
            TheRecordesLabel.Text= DetainLIceseses.Rows.Count.ToString();
        }

        private void ManageDetainLicesneForm_Load(object sender, EventArgs e)
        {
            DetainLIceseses.DataSource = ClassDealWithDetainLicenses.PassAllTheDetainedLicenses();
            FillTheRecordesNumber();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form Detain = new DetainLicenseFrom();
            Detain.ShowDialog();
        }

        private void perosnInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DetainLIceseses.SelectedRows.Count > 0)
            {
                try
                {
                    var row = DetainLIceseses.SelectedRows[0];

                    if (int.TryParse(row.Cells[1].Value?.ToString(), out int licenseID))
                    {
                        var license = ClassDealWithLicenseData.FindLicenseByID(licenseID);

                        if (license != null)
                        {
                            var driver = ClassDealWithDataOfTheDrivers.FindDriverByDriverID(license.DriverID);

                            if (driver != null)
                            {
                                Form personForm = new ThePersonInformationForm(driver.PersonID);
                                personForm.ShowDialog();
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

                    if (int.TryParse(row.Cells[1].Value?.ToString(), out int licenseID))
                    {
                       
                        DataRow LiceesRow=ClassDealWithDataOfTheLocalLicenseApplication.PassRowFromTheLocalLicenseApplicationData(licenseID);
                            Form Licese = new LicenseInformations(LiceesRow);
                            Licese.ShowDialog();


                        
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

                    if (int.TryParse(row.Cells[1].Value?.ToString(), out int licenseID))
                    {
                        var license = ClassDealWithLicenseData.FindLicenseByID(licenseID);

                        if (license != null)
                        {
                            var driver = ClassDealWithDataOfTheDrivers.FindDriverByDriverID(license.DriverID);

                            if (driver != null)
                            {
                                ClassPersonInformation personInformation = ClassDealWithDataFromThePeople.FindByID(driver.PersonID);
                                Form History = new PersonLicenseHistory(personInformation.NationalNo);
                                History.ShowDialog();
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
    }
}
