using DVDL_Business.After.TestType;
using DVDL_InfrastructureLayer;
using DVDL_Persentation.Manage_Screens;
using FormsUtilities.ManageScreens.ManageTestType;
using FormsUtilities.Tests.UpdateTest;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class ManageTestsType : Form
    {
        IManageTestTypeUtility _manageTestTypeUtility;
        public ManageTestsType(IManageTestTypeUtility _manageTestTypeUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._manageTestTypeUtility = _manageTestTypeUtility;
        }

        private void ManageTestsType_Load(object sender, EventArgs e)
        {
            RefreshTheApplicationData(sender);
            TheRecordesLabel.Text= _manageTestTypeUtility.RecordesNumber().ToString();

        }

        private void RefreshTheApplicationData(object sender)
        {
            TheTestsTypeData.DataSource = null;
            _manageTestTypeUtility.LoadData();
            TheTestsTypeData.DataSource = _manageTestTypeUtility.GetData();
        }

    
        private void editTheApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheTestsTypeData.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(TheTestsTypeData.SelectedRows[0].Cells["id"].Value);
                var formFactory = Program.ServiceProvider.GetRequiredService<IUpdateTestUtility>();
                UpdateTest Form = new UpdateTest(id,formFactory);
                Form.RefreshTheDataOfTheTests += RefreshTheApplicationData;
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select An Test To Edit");
            }

        }
    }
}
