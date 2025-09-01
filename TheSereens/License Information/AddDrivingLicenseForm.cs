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
using ThePusnissLayer.Applications.LocalLisense;
using ThePusnissLayer.License_Application;
using ThePusnissLayer.Users;
using static System.Net.Mime.MediaTypeNames;

namespace TheSereens
{
    public partial class AddDrivingLicenseForm : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshLicenseData;

        int ApplicationID;
        ClassLocalLicenseApplicationInfomation LocalLicenseApplication=new ClassLocalLicenseApplicationInfomation() ;
        ApplicationsInformation Application=new ApplicationsInformation();
        public AddDrivingLicenseForm(int ApplicationID)
        {
            InitializeComponent();
            this.ApplicationID = ApplicationID;
        }


        private void FillTheLicenseClassType()
        {
            DataTable dataTable = ClassDealWithDataOfLicenseClass.PassAllLicenseClassData();
            foreach (DataRow Row in dataTable.Rows)
            {
                LicenseClass.Items.Add(Row["ClassName"]);

            }

        }


        private decimal GetTheApplicationFees()
        {
            TheApplicationTypeInformation Application = ClassDealWithDataOfTheApplication.FindApplicationByID(ApplicationID);
            return Application.Fees;
        }

        private void FillTheApplicationInformation()
        {
            ApplicationDateLabel.Text = DateTime.Now.ToString();
            CreatedByLabel.Text = ClassCurrentUserInformation.CurrentUser.UserName;
            FillTheLicenseClassType();
            ApplicationFeesLabel.Text = GetTheApplicationFees().ToString();
        }


        private void AddDrivingLicenseForm_Load(object sender, EventArgs e)
        {
            FillTheApplicationInformation();
            LicenseClass.SelectedIndex = 0;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            LicenseInformation.SelectedIndex = 1;
        }
    
    
        private int SaveToTheApplications()
        {
            TheApplicationTypeInformation ApplicationType = ClassDealWithDataOfTheApplication.FindApplicationByID(ApplicationID);
            Application.PersonID = personCardWithFilter1.GetThePersonId();
            Application.Date = DateTime.Now;
            Application.Type= ApplicationType.ID;
            Application.LastStatusDate=DateTime.Now;
            Application.Fees = decimal.Parse( ApplicationFeesLabel.Text);
            Application.CreatedByUserID = ClassCurrentUserInformation.CurrentUser.UserID;
            Application.StatusID = 1;
            int ID=Application.Save();
            return ID;

        }
       
        private void SaveToTheLocalLicenseApplications()
        {
            LocalLicenseApplication.ApplicationID = SaveToTheApplications();
            LocalLicenseApplication.LicenseClassID=LicenseClass.SelectedIndex;
            ApplicationIDLabel.Text= LocalLicenseApplication.Save().ToString();
            MessageBox.Show("The Application Added Sucsessfuly");
        }
    

        private bool IsPersonHasTheSameLicense()
        {
            return ClassDealWithDataOfTheLocalLicenseApplication.IsTheLicenseExist(personCardWithFilter1.GetThePerson().NationalNo,LicenseClass.SelectedItem.ToString());
        }
        
        private bool IsValidSave()
        {

            bool ISValid=true;
            if(LicenseClass.SelectedItem==null)
            {
                ISValid=false;
                MessageBox.Show("Please Choose a License Type");
            }
            return ISValid;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(!IsPersonHasTheSameLicense())
            {
                if(IsValidSave())
                {
                    SaveToTheLocalLicenseApplications();
                    RefreshLicenseData?.Invoke(this);

                }

            }
            else
            {
                MessageBox.Show("You Can not Add Many The Same License For The Same Person ");
            }

        }
    }
}