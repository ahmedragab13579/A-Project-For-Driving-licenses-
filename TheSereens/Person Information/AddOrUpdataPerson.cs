using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Country;
using ThePusnissLayer.People;
using TheSereens.Properties;

namespace TheSereens
{
    public partial class AddOrUpdataPerson : UserControl
    {
        public delegate void RefreshTehDataTheLastLayer(object sender);
        public event RefreshTehDataTheLastLayer TheLastStepFromRefreshing;
        ClassPersonInformation person = new ClassPersonInformation();
        
        private string imagePath="";
        
        int id;

        public AddOrUpdataPerson(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        
        private ClassPersonInformation FillTheUpdatedPerson(ClassPersonInformation person)
        {
             FirstNameTextBox.Text= person.FirstName;
             SecondNameTextBox.Text = person.SecondName;
             ThirdNameTextBox.Text= person.ThirdName;
             LastNameTextBox.Text= person.LastName;
            TheNationalIDTextBox.Text= person.NationalNo;
             ThePersonDateOfBirth.Value= person.DateOfBirth;
            PhoneTextBox.Text = person.Phone;
            EmailTextBox.Text=person.Email;
            AdressTextBox.Text= person.Address;
             CountryComboBox.SelectedIndex= person.NationalityCountryID;
            
            
            
            if (person.Gendor == int.Parse(Male.Tag.ToString()))
            {
               Male.Checked= true;
            }
            else if(person.Gendor == int.Parse(Male.Tag.ToString()))
            {
                Female.Checked = true;


            }
            
           
            
            if(person.ImagePath== null)
            {
                imagePath="";
            }
            else
            {
                person.ImagePath= imagePath;    
            }
        
            return person;
        }
        private ClassPersonInformation FillThePersonAfterUpdate()
        {
          person.FirstName = FirstNameTextBox.Text;
          person.SecondName =SecondNameTextBox.Text;
          person.ThirdName  =ThirdNameTextBox.Text;
          person.LastName = LastNameTextBox.Text;
          person.NationalNo = TheNationalIDTextBox.Text;
          person.DateOfBirth = ThePersonDateOfBirth.Value;
          person.Phone = PhoneTextBox.Text;
          person.Email = EmailTextBox.Text;
          person.Address = AdressTextBox.Text;
          person.NationalityCountryID = CountryComboBox.SelectedIndex;


            if (person.Gendor == int.Parse(Male.Tag.ToString()))
            {
                Male.Checked = true;
            }
            else if (person.Gendor == int.Parse(Male.Tag.ToString()))
            {
                Female.Checked = true;


            }



            if (person.ImagePath == null)
            {
                imagePath = "";
            }
            else
            {
                person.ImagePath = imagePath;
            }

            return person;
        
        }
       
     
       
        private bool IsNationalIDExists(string ID)
        {
            return ClassDealWithDataFromThePeople.FindByNationalID2(ID);
        }
        private void FillTheCountryCombobox()
        {
            foreach(DataRow row in ClassDealWithCountryData.PassAllCountryData().Rows )
            {

                CountryComboBox.Items.Add(row["CountryName"] );


            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
           
            return Regex.IsMatch(email, pattern);
        }

        private void AddOrUpdataPerson_Load(object sender, EventArgs e)
        {
            ThePersonDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            FillTheCountryCombobox();
            if(id!=-1)
            {
                ClassPersonInformation Person = ClassDealWithDataFromThePeople.FindByID(id);
                FillTheUpdatedPerson(Person);
                person = Person;

            }
            
        }

        private void MailRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImagePersonBox.BackgroundImage = Resources._9896174;
        }

        private void FemaleradioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImagePersonBox.BackgroundImage = Resources._296fe121_5dfa_43f4_98b5_db50019738a7;

        }

        private void EmailtextBox_Validating(object sender, CancelEventArgs e)
        {
            if(EmailTextBox.Text=="" || IsValidEmail(EmailTextBox.Text))
            {
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(EmailTextBox,"Pleace Write a True email formater");
                e.Cancel= true;

            }
        }

        private void TheNationalIDTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (IsNationalIDExists((TheNationalIDTextBox.Text))|| TheNationalIDTextBox.Text=="") 
            {
                e.Cancel= true;
                errorProvider1.SetError(TheNationalIDTextBox, "This National Id Is Exist");
            }
            else
            {
                e.Cancel=false;
                errorProvider1.Clear();

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                ImagePersonBox.BackgroundImage = Image.FromFile(imagePath);
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
                person = FillThePersonAfterUpdate();
                int id = person.Save();
                MessageBox.Show("The Process Was Made  sucsessfuly");
                PersonIDLabel.Text = id.ToString();
                TheLastStepFromRefreshing?.Invoke(this);



        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Form form = this.FindForm();
            if(form != null)
            {
                form.Close();
            }
        }
    

    }
}
