using DVDL_Business.After.ApplicationType;
using DVDL_DTOs;
using DVDL_InfrastructureLayer;
using FormsUtilities.Applications;
using System;
using System.Windows.Forms;
namespace DVDL_Persentation
{
    public partial class UpdateApplication : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheDataOfTheApplications;

        IUpdateApplicationTypeUtility _updateApplicationTypeUtility;
        int id;
        public UpdateApplication(int id, IUpdateApplicationTypeUtility _updateApplicationTypeUtility)
        {
            InitializeComponent(); 
            AppTheme.ApplyTheme(this);

            this.id = id;
            this._updateApplicationTypeUtility= _updateApplicationTypeUtility;
        }

        #region must remove


        private void FillTheApplicationInformation()
        {
            var Application = _updateApplicationTypeUtility.GetApplicationType(id);
            ApplicationIDLabel.Text = Application.ID.ToString();
            TitleTextBox.Text = Application.Title.ToString();
            FeesTextBox.Text = Application.Fees.ToString();
        }
        #endregion must remove

        private void UpdateApplication_Load(object sender, EventArgs e)
        {
            FillTheApplicationInformation();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_updateApplicationTypeUtility.ValidateApplicationInputs(TitleTextBox.Text, FeesTextBox.Text))
            {
                _updateApplicationTypeUtility.UpdateApplicationType(TitleTextBox.Text,FeesTextBox.Text);
                RefreshTheDataOfTheApplications?.Invoke(this);
                MessageBox.Show("Updated Successfuly");
            }
            else
            {
                MessageBox.Show("Please fill  Title and Fees fields");
            }


        }
    }
}
