using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Country;
using ThePusnissLayer.People;
using TheSereens.Properties;
using System.IO;


namespace TheSereens
{
    public partial class PersonCard : UserControl
    {
        private int id;
       
        private ClassPersonInformation person;
        public int PersonID
        {
            get { return id; }
        }
        public ClassPersonInformation Person
        {
            get { return person; }
        }
        string imagePath;
        public PersonCard()
        {
            InitializeComponent();
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
            ThePersonImage.Image = Resources._296fe121_5dfa_43f4_98b5_db50019738a7;

        }

        private void PersonCard_Load(object sender, EventArgs e)
        {
            MakeAllTheControlsUnKnown();
        }

        public void ThePersonInformation(int ID)
        {
            person = ClassDealWithDataFromThePeople.FindByID(ID);
            if (person == null)
            {
                MessageBox.Show("This Person Not Found");
                MakeAllTheControlsUnKnown();
            }

        }
       
        public void ThePersonInformation(string NationalNumber)
        {
            person = ClassDealWithDataFromThePeople.FindByNationalID(NationalNumber);
            if (person == null)
            {
                MessageBox.Show("This Person Not Found");
                MakeAllTheControlsUnKnown();
            }

        }

        private string GetTheCountryName(int index)
        {
            DataTable CountryData = ClassDealWithCountryData.PassAllCountryData();

            if (index >= 0 && index < CountryData.Rows.Count)
            {
                return CountryData.Rows[index]["CountryName"].ToString();
            }

            return "";
        }

        public void FillThePersonInformation()
        {
            if (person != null)
            {
                id=person.PersonID;
                PersonIdLabel.Text = person.PersonID.ToString();
                NationalNumberLabel.Text = person.NationalNo.ToString();
                GendorLabel.Text = (person.Gendor == 0 ? "Male" : "Female");
                PersonNameLabel.Text = person.FirstName + person.LastName;
                EmailLabel.Text = person.Email;
                PhoneLabel.Text = person.Phone;
                DateOfBirthLabel.Text = person.DateOfBirth.ToString();
                AdressLabel.Text = person.Address;
                CountryLabel.Text = GetTheCountryName(person.NationalityCountryID);
                if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
                {
                    ThePersonImage.BackgroundImage = Image.FromFile(person.ImagePath);
                    ThePersonImage.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
       
        public void FillThePersonInformation(ClassPersonInformation Person)
        {
            this.person= Person;

            if (person != null)
            {
                id=person.PersonID;
                PersonIdLabel.Text = person.PersonID.ToString();
                NationalNumberLabel.Text = person.NationalNo.ToString();
                GendorLabel.Text = (person.Gendor == 0 ? "Male" : "Female");
                PersonNameLabel.Text = person.FirstName + person.LastName;
                EmailLabel.Text = person.Email;
                PhoneLabel.Text = person.Phone;
                DateOfBirthLabel.Text = person.DateOfBirth.ToString();
                AdressLabel.Text = person.Address;
                CountryLabel.Text = GetTheCountryName(person.NationalityCountryID);
                if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
                {
                    ThePersonImage.BackgroundImage = Image.FromFile(person.ImagePath);
                    ThePersonImage.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
       
        public void ResetPersonObject()
        {
            person.PersonID = -1;
            person.Email = "";
            Person.Address = "";
            person.NationalityCountryID = -1;
            person.FirstName = "";
            person.SecondName = "";
            person.ThirdName = "";
            person.LastName = "";
            person.Phone = "";
            person.Gendor = -1;
            person.DateOfBirth=DateTime.Now;
        }
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Person = new AddOrUpdatePersonForm(id);
            Person.ShowDialog();
        }
    }
}
