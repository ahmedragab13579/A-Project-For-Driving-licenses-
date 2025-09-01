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

namespace TheSereens
{
    public partial class UpdateApplication : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheDataOfTheApplications;
        
        TheApplicationTypeInformation Application;
        int id;
        public UpdateApplication(int id)
        {
            InitializeComponent();
            this.id = id;

        }

        private void FillTheApplicationInformation()
        {
             Application = ClassDealWithDataOfTheApplication.FindApplicationByID(id);
            
            ApplicationIDLabel.Text=Application.ID.ToString();
            TitleTextBox.Text=Application.Title.ToString();
            FeesTextBox.Text=Application.Fees.ToString();
        }

        private void FillTheApplicationInformationAfterUpdate()
        {
           Application.Title = TitleTextBox.Text;
            Application.Fees=int.Parse(FeesTextBox.Text);
        }
        
        private void UpdateApplication_Load(object sender, EventArgs e)
        {
            FillTheApplicationInformation();

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
            return isValid;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValidInputs())
            {
                FillTheApplicationInformationAfterUpdate();
                Application.UpdateApplication();
                RefreshTheDataOfTheApplications?.Invoke(this);
                MessageBox.Show("Updated Successfuly");
            }
            else
            {
                MessageBox.Show("Please fill all Title and Fees fields");
            }


        }
    }
}
