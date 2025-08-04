using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Tests;

namespace TheSereens
{
    public partial class ManageTestsType : Form
    {
        public ManageTestsType()
        {
            InitializeComponent();
        }
        private void FillTheRecordesNumber()
        {
            TheRecordesLabel.Text = TheTestsTypeData.Rows.Count.ToString();

        }
        private void FillTheApplicationTypesNumber()
        {
            TheTestsTypeData.DataSource = ClassDealWithDataOfTheTestType.PassAllTheTestData();
        }

        private void ManageTestsType_Load(object sender, EventArgs e)
        {
            FillTheApplicationTypesNumber();
            FillTheRecordesNumber();

        }
       
        private void RefreshTheApplicationData(object sender)
        {
            TheTestsTypeData.DataSource = null;
            TheTestsTypeData.DataSource = ClassDealWithDataOfTheTestType.PassAllTheTestData();

        }

        private void editTheApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheTestsTypeData.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(TheTestsTypeData.SelectedRows[0].Cells["TestTypeID"].Value);
                UpdateTest Edit = new UpdateTest(id);
                Edit.RefreshTheDataOfTheTests += RefreshTheApplicationData;
                Edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select An Test To Edit");
            }

        }
    }
}
