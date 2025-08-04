using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Drivers;
using ThePusnissLayer.License.InternationalLicense;
using ThePusnissLayer.People;
using TheSereens.License_Information;

namespace TheSereens.Manage_Screens
{
    public partial class ManageInternationalLicense : Form
    {
        public ManageInternationalLicense()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form International = new IssueInternationalLicense();
            International.ShowDialog();
        }

        private void ManageInternationalLicense_Load(object sender, EventArgs e)
        {
            DataTable Data=ClassDealWithInternationalLicenseData.PassAllInternationalLicense();
            TheInternationalData.DataSource = Data;
        }

        private void personInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            if (TheInternationalData.SelectedRows.Count > 0)
            {
                var cellValue = TheInternationalData.SelectedRows[0].Cells["DriverID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int driverID))
                {
                    ClassDealWithDataOfTheDrivers driver = ClassDealWithDataOfTheDrivers.FindDriverByDriverID(driverID);
                    ClassPersonInformation person = ClassDealWithDataFromThePeople.FindByID(driver.PersonID);

                    Form personInfo = new ThePersonInformationForm(person.PersonID);
                    personInfo.ShowDialog();
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
                    ClassDealWithDataOfTheDrivers driver = ClassDealWithDataOfTheDrivers.FindDriverByDriverID(driverID);
                    ClassPersonInformation person = ClassDealWithDataFromThePeople.FindByID(driver.PersonID);

                    Form personHistory = new PersonLicenseHistory(person.NationalNo);
                    personHistory.ShowDialog();
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

        private void licenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheInternationalData.SelectedRows.Count > 0)
            {
                var cellValue = TheInternationalData.SelectedRows[0].Cells["InternationalLicenseID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int driverID))
                {
                    Form license = new LocalLicenseApplicationInfomationForm(22);
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
    }
}
