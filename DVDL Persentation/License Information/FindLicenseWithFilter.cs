using DVDL_InfrastructureLayer;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;
using TheDataLayer_For_Project.Models.Person;


namespace DVDL_Persentation
{
    public partial class FindLicenseWithFilter : UserControl
    {
        IFindLicenserWithFilterUtility _FindLicenserWithFilterUtility;
        public event EventHandler LicenseInformation;
        public event Action<int> LicenseIsFound;

        public FindLicenseWithFilter()
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

        }
        private void SetInternatioanlNo()
        {
            if (!DesignMode && _FindLicenserWithFilterUtility != null)
            {
                _FindLicenserWithFilterUtility.SetNationalID(NationalID.Text);
            }
        }
        private void LicenseInformationComplete_Finished(object sender, EventArgs e)
        {
        }

        private void PersonImage(string PersonImagePath)
        {
            if (!string.IsNullOrEmpty(PersonImagePath) && File.Exists(PersonImagePath))
            {
                pictureBox2.BackgroundImage = Image.FromFile(PersonImagePath);
                pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }
        private void FillTheLicenseInformation()
        {
            if (DesignMode || _FindLicenserWithFilterUtility == null)
                return;

            var vm = _FindLicenserWithFilterUtility.GetLicenseInfo(FilterTextBox.Text);
            if (vm == null)
            {
                MessageBox.Show("There is no Driver with this LicenseID");
                return;
            }
            if (_FindLicenserWithFilterUtility.IsActive(FilterTextBox.Text))
            {
               
                 LicenseIsFound?.Invoke(int.Parse(vm.LicenseId));
                 ExpirationDate.Text = vm.ExpirationDate;
                 IssueDate.Text = vm.IssueDate;
                 LicenseID.Text = vm.LicenseId;
                 Notes.Text = vm.Notes;
                 DriverID.Text = vm.DriverId;
                 IsDetaided.Text = _FindLicenserWithFilterUtility.IsDetained().ToString();
                 IsActive.Text = vm.IsActive.ToString();
                 PersonName.Text = vm.PersonName;
                 NationalID.Text = vm.NationalId;
                 Gendor.Text = vm.Gender;
                 DateOfBirth.Text = vm.DateOfBirth;
                 Class.Text = vm.Class;
                PersonImage(_FindLicenserWithFilterUtility.PersonImagePath());
                 LicenseInformation?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("This License Is Not Active ");
            }
        }
        public void SetUtility(IFindLicenserWithFilterUtility _FindLicenserWithFilterUtility)
        {
            this._FindLicenserWithFilterUtility = _FindLicenserWithFilterUtility;
        }
        private void search_Click(object sender, EventArgs e)
        {
            if (_FindLicenserWithFilterUtility != null &&
                _FindLicenserWithFilterUtility.IsValidText(FilterTextBox.Text))
            {
                FillTheLicenseInformation();
                SetInternatioanlNo();
            }
            else
            {
                MessageBox.Show("Please Write The License ID");
            }
        }

        private void FilterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

          
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            
        }
    }
}
