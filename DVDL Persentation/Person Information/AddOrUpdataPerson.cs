using DVDL_Business.After.DTOs;
using DVDL_InfrastructureLayer;
using FormsUtilities.PersonInformation.AddOrUpdatePerson;
using System.ComponentModel;
namespace DVDL_Persentation
{
    public partial class AddOrUpdataPerson : UserControl
    {
        public delegate void RefreshTehDataTheLastLayer(object sender);
        public event RefreshTehDataTheLastLayer TheLastStepFromRefreshing;
    
       
        
        private  IAddOrUpdatePersonUtility _AddOrUpdatePersonUtility=null;
        public AddOrUpdataPerson()
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

        }


        #region Finished
        public void SetUtility(IAddOrUpdatePersonUtility _AddOrUpdatePersonUtility)
        {
            this._AddOrUpdatePersonUtility = _AddOrUpdatePersonUtility;
        }
        public void SetID(int id)
        {
            _AddOrUpdatePersonUtility.SetID(id);
        }
        
        private void AddOrUpdataPerson_Load(object sender, EventArgs e)
        {
            FillTheCountryCombobox();
            if (_AddOrUpdatePersonUtility.PersonID() != -1)
            {
                _AddOrUpdatePersonUtility.RefreshFromDatabase();
                FillTheUpdatedPerson(_AddOrUpdatePersonUtility.Person());
            }
            else
            {
                ThePersonDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            }

        }
        private void FillTheCountryCombobox()
        {
            foreach (var Country in _AddOrUpdatePersonUtility.TheCountrys())
            {

                CountryComboBox.Items.Add(Country.Name);


            }
        }
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Form form = this.FindForm();
            if (form != null)
            {
                form.Close();
            }
        }
        private void MailRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImagePersonBox.BackgroundImage = DVDL_Persentation.Properties.Resource.Male_512;
        }
        private void FemaleradioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImagePersonBox.BackgroundImage = DVDL_Persentation.Properties.Resource.Female_512;

        }
   
        private void EmailtextBox_Validating(object sender, CancelEventArgs e)
        {
            if (EmailTextBox.Text == "" || _AddOrUpdatePersonUtility. IsValidEmail(EmailTextBox.Text))
            {
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(EmailTextBox, "Pleace Write a True email formater");
                e.Cancel = true;

            }
        }
        private void TheNationalIDTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (_AddOrUpdatePersonUtility.IsNationalIDExists((TheNationalIDTextBox.Text)) || TheNationalIDTextBox.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(TheNationalIDTextBox, "This National Id Is Exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();

            }

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _AddOrUpdatePersonUtility.ImagePath(
                openFileDialog.FileName);
                GetPersonImage(_AddOrUpdatePersonUtility.Person());
            }
        }
        private void GetPersonImage(PersonDto person)
        {
            if (person.ImagePath == null)
            {
                ImagePersonBox.Image = DVDL_Persentation.Properties.Resource._296fe121_5dfa_43f4_98b5_db50019738a7;
            }
            else
            {
                if (File.Exists(person.ImagePath))
                {
                    using (var img = Image.FromFile(person.ImagePath))
                    {
                        ImagePersonBox.Image = new Bitmap(img);
                        ImagePersonBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
            }
        }
        private void GetGendor(PersonDto person)
        {
            if (person.Gendor == int.Parse(Male.Tag.ToString()))
            {
                Male.Checked = true;
            }
            else if (person.Gendor == int.Parse(Female.Tag.ToString()))
            {
                Female.Checked = true;


            }
        }
        
        private void FillTheUpdatedPerson(PersonDto person)
        {
            FirstNameTextBox.Text = person.FirstName;
            SecondNameTextBox.Text = person.SecondName;
            ThirdNameTextBox.Text = person.ThirdName;
            LastNameTextBox.Text = person.LastName;
            TheNationalIDTextBox.Text = person.NationalNo;
            ThePersonDateOfBirth.Value = person.DateOfBirth;
            PhoneTextBox.Text = person.Phone;
            EmailTextBox.Text = person.Email;
            AdressTextBox.Text = person.Address;
            CountryComboBox.SelectedIndex = person.NationalityCountryID;
            GetGendor(person);
            GetPersonImage(person);
        }
        private PersonDto FillThePersonAfterUpdate()
        {
            return new PersonDto
            {
                PersonID = int.Parse(PersonIDLabel.Text),
                FirstName = FirstNameTextBox.Text,
                SecondName = SecondNameTextBox.Text,
                ThirdName = ThirdNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                NationalNo = TheNationalIDTextBox.Text,
                DateOfBirth = ThePersonDateOfBirth.Value,
                Phone = PhoneTextBox.Text,
                Email = EmailTextBox.Text,
                Address = AdressTextBox.Text,
                NationalityCountryID = CountryComboBox.SelectedIndex,
            };


            

         
        }

        private void AddPerson()
        {
            int Id = _AddOrUpdatePersonUtility.AddPerson();
            MessageBox.Show("The Process Was Made  sucsessfuly");
            PersonIDLabel.Text = Id.ToString();
            TheLastStepFromRefreshing?.Invoke(this);
        }
        private void UpdatePerson()
        {
            var updatedPerson = FillThePersonAfterUpdate();
            _AddOrUpdatePersonUtility.SetPerson(updatedPerson);

            _AddOrUpdatePersonUtility.UpdatePerson();
            MessageBox.Show("The Process Was Made  sucsessfuly");
            PersonIDLabel.Text = _AddOrUpdatePersonUtility.PersonID().ToString();
            TheLastStepFromRefreshing?.Invoke(this);
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (_AddOrUpdatePersonUtility.PersonID() != -1)
            {
                UpdatePerson();
                return;
            }
            AddPerson();
        }
    

        #endregion Finished
    }
}
