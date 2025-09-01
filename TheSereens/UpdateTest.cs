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
    public partial class UpdateTest : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheDataOfTheTests;


        int id;
        ClassTheTestTypeInformation Test;
        public UpdateTest(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FillTheApplicationInformation()
        {
            Test = ClassDealWithDataOfTheTestType.FindTestByID(id);

            TestIDLabel.Text = Test.ID.ToString();
            TitleTextBox.Text = Test.Title.ToString();
            FeesTextBox.Text = Test.Fees.ToString();
            DescriptionTextBox.Text = Test.Description;
        }
        private void FillTheTestInformationAfterUpdate()
        {
            Test.Title = TitleTextBox.Text;
            Test.Fees = int.Parse(FeesTextBox.Text);
            Test.Description = DescriptionTextBox.Text;
        }
        private bool IsValidInputs()
        {
            bool isValid = true;
            if (TitleTextBox.Text == string.Empty)
            {
                isValid = false;

            }
            if (FeesTextBox.Text == string.Empty)
            {
                isValid = false;

            }
            if (DescriptionTextBox.Text == string.Empty)
            {
                isValid = false;

            }
            return isValid;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValidInputs())
            {
                FillTheTestInformationAfterUpdate();
                Test.UpdateTest();
                RefreshTheDataOfTheTests?.Invoke(this);
                MessageBox.Show("Updated Successfuly");

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
            FillTheApplicationInformation();
        }
    }
}
