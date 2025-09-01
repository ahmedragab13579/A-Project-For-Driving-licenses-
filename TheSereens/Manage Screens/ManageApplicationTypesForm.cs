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
using TheSereens.License_Information;

namespace TheSereens
{
    public partial class ManageApplicationTypesForm : Form
    {
        public ManageApplicationTypesForm()
        {
            InitializeComponent();
        }

        private void FillTheRecordesNumber()
        {
            TheRecordesLabel.Text=TheInternationallicenseData.Rows.Count.ToString();

        }
        private void FillTheApplicationTypesNumber()
        {
            TheInternationallicenseData.DataSource = ClassDealWithDataOfTheApplication.PassAllTheApplicationData();
        }
        private void ManageApplicationTypesForm_Load(object sender, EventArgs e)
        {
            FillTheApplicationTypesNumber();
            FillTheRecordesNumber();

        }

        private void editTheApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheInternationallicenseData.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(TheInternationallicenseData.SelectedRows[0].Cells["ApplicationTypeID"].Value);
                UpdateApplication Edit = new UpdateApplication(id);
                Edit.RefreshTheDataOfTheApplications += RefreshTheApplicationData;
                Edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select An Application To Edit");
            }
        }
    
        private void RefreshTheApplicationData(object sender)
        {
            TheInternationallicenseData.DataSource = null;
            TheInternationallicenseData.DataSource = ClassDealWithDataOfTheApplication.PassAllTheApplicationData();

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form InternarionalLicenese = new IssueInternationalLicense();
            InternarionalLicenese.ShowDialog();
        }

        private void perosnInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void licenseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
