using DVDL_Business.After.DTOs;
using DVDL_Business.After.TestType;
using DVDL_InfrastructureLayer;
using FormsUtilities.Tests.UpdateTest;
using System;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class UpdateTest : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheDataOfTheTests;


        int id;
        private readonly IUpdateTestUtility _UpdateTestUtility;
     
        
        public UpdateTest(int id, IUpdateTestUtility _UpdateTest)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            _UpdateTestUtility = _UpdateTest;
            this.id = id;
        }

        private void FillTheApplicationInformation(TestTypeDtos Test)
        {

            TestIDLabel.Text = Test.Id.ToString();
            TitleTextBox.Text = Test.Title.ToString();
            FeesTextBox.Text = Test.Fees.ToString();
            DescriptionTextBox.Text = Test.Description;
        }
        bool IsTrueFeesFormate()
        {
            if (decimal.TryParse(FeesLabel.Text,out decimal result))
            {
                return true;
            }

            return false;

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_UpdateTestUtility.IsValidInputs(TitleTextBox.Text,FeesTextBox.Text,DescriptionTextBox.Text))
            {
               if( IsTrueFeesFormate())
                {
               _UpdateTestUtility.FillTheTestInformationAfterUpdate(FeesTextBox.Text,DescriptionTextBox.Text);
                RefreshTheDataOfTheTests?.Invoke(this);
                MessageBox.Show("Updated Successfuly");
                SaveButton.Enabled = false;

                }
               else
                {
                    MessageBox.Show("Please enter Number in Fees Label");
                }
            }
            else
            {
                MessageBox.Show("Please fill  Title , Fees and  Description  fields");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void UpdateTest_Load(object sender, EventArgs e)
        {
            FillTheApplicationInformation(_UpdateTestUtility.GetTestType(id));
        }
    }
}
