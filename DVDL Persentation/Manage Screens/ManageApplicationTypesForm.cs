using DVDL_Business.After.ApplicationType;
using DVDL_InfrastructureLayer;
using DVDL_Persentation.Manage_Screens;
using FormsUtilities.Applications;
using FormsUtilities.ManageScreens.ManageApplicationTypes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TheDataLayer_For_Project.Models.Applications;

namespace DVDL_Persentation
{
    public partial class ManageApplicationTypesForm : Form
    {
        IApplicationTypeUtility _ApplicationType;
        public ManageApplicationTypesForm(IApplicationTypeUtility _ApplicationType)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._ApplicationType = _ApplicationType;
        }

    
        
        private void ManageApplicationTypesForm_Load(object sender, EventArgs e)
        {
            RefreshTheApplicationData(sender);
          TheRecordesLabel.Text=_ApplicationType.FillTheRecordesNumber().ToString();

        }


        private void RefreshTheApplicationData(object sender)
        {
            _ApplicationType.LoadData();
            TheInternationallicenseData.DataSource = null;
            TheInternationallicenseData.DataSource = _ApplicationType.FillTheApplicationTypesNumber();


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheInternationallicenseData.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(TheInternationallicenseData.SelectedRows[0].Cells["ID"].Value);
               
                
                var formFactory = Program.ServiceProvider.GetRequiredService<IUpdateApplicationTypeUtility>();
                UpdateApplication Form=new UpdateApplication(id, formFactory);
                Form.RefreshTheDataOfTheApplications += RefreshTheApplicationData;
                Form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please Select An Application To Edit");
            }
        }

    }
}
