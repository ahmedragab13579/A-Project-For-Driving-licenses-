using DVDL_Business.After.Country;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.People;
using DVDL_InfrastructureLayer;
using DVDL_Persentation.Person_Information;
using DVDL_Persentation.Properties;
using FormsUtilities.PersonInformation.AddOrUpdatePerson;
using FormsUtilities.PersonInformation.PersonCard;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TheDataLayer_For_Project.Models.Person;


namespace DVDL_Persentation
{
    public partial class PersonCard : UserControl
    {
        public event Action<int> PersonFound;

        public PersonDto Person
        {
            get { return _personCard.GetPerson(_personCard.GetPersonID()); }
        }
    
    
        IPersonCardUtility _personCard=null;
        public PersonCard()
        {
            InitializeComponent();

            AppTheme.ApplyTheme(this);

        }

        private void ManagePersonInformation(PersonDto person)
        {
            if (person != null)
            {
                PersonIdLabel.Text = person.PersonID.ToString();
                NationalNumberLabel.Text = person.NationalNo.ToString();
                GendorLabel.Text = (person.Gendor == 0 ? "Male" : "Female");
                PersonNameLabel.Text = person.FirstName + person.LastName;
                EmailLabel.Text = person.Email;
                PhoneLabel.Text = person.Phone;
                DateOfBirthLabel.Text = person.DateOfBirth.ToString();
                AdressLabel.Text = person.Address;
                CountryLabel.Text = _personCard.GetTheCountryName(person.NationalityCountryID);
                if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
                {
                    ThePersonImage.BackgroundImage = Image.FromFile(person.ImagePath);
                    ThePersonImage.BackgroundImageLayout = ImageLayout.Stretch;
                }
                PersonFound?.Invoke(Person.PersonID);
                linkLabel1.Enabled = true;
            }
            else
            {
                MessageBox.Show("This Person is not exist If you want to Use Him Please add him");
            }
        }
        public void FillThePersonInformation(int id)
        {
            var person = _personCard.GetPerson(id);

            ManagePersonInformation(person);
        }
        public void FillThePersonInformation(string NationalNo)
        {
            PersonDto person = _personCard.GetPerson(NationalNo);
            ManagePersonInformation(person);
        }
        public void FillThePersonInformation(PersonDto Person)
        {

            ManagePersonInformation(Person);
        }
        public void SetUtility(IPersonCardUtility personCardUtility)
        {
            _personCard = personCardUtility;
        }

        #region Finished
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var UpdatePerson = Program.ServiceProvider.GetRequiredService<IAddOrUpdatePersonUtility>();
            AddOrUpdatePersonForm form = new  AddOrUpdatePersonForm(UpdatePerson, _personCard.GetPersonID());
            form.ShowDialog();
        }
        private void MakeAllTheControlsUnKnown()
        {
            PersonIdLabel.Text = "[???]";
            AdressLabel.Text = "[???]";
            EmailLabel.Text = "[???]";
            NationalNumberLabel.Text = "[???]";
            DateOfBirthLabel.Text = "[???]";
            CountryLabel.Text = "[???]";
            GendorLabel.Text = "[???]";
            PersonNameLabel.Text = "[???]";
            PhoneLabel.Text = "[???]";

        }
        private void PersonCard_Load(object sender, EventArgs e)
        {
            MakeAllTheControlsUnKnown();
        }
        #endregion Finished

         
    }
}
