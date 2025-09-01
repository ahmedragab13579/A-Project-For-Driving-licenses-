using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer;
using ThePusnissLayer.People;

namespace TheSereens
{
    public partial class PersonCardWithFilter : UserControl
    {
        public PersonCardWithFilter()
        {
            InitializeComponent();
        }

        public int GetThePersonId()
        {
            return personCard1.PersonID;
        }
        public ClassPersonInformation GetThePerson()
        {
            return personCard1.Person;
        }
        
        
        public void DisableTheFilter()
        {
            TheFilterGroupbox.Enabled = false;
        }
        
        public void FillThePersonInformation(int id)
        {
            personCard1.ThePersonInformation(id);
            personCard1.FillThePersonInformation();
        }
       
        private void  MakeTheFilter()
        {
            if (TheFilterInformation.Text == "")
            {
                MessageBox.Show($"Please Write a {FiltersCompoBox.SelectedItem.ToString()}");
                return;
            }
            if (FiltersCompoBox.SelectedItem.ToString() == "Person ID")
            {
                personCard1.ThePersonInformation(int.Parse(TheFilterInformation.Text));
                personCard1.FillThePersonInformation();
            }
            else
            {
                personCard1.ThePersonInformation(TheFilterInformation.Text);
                personCard1.FillThePersonInformation();
            }
        }
       
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            MakeTheFilter();
        }

        private void AddPersonbutton_Click(object sender, EventArgs e)
        {
            Form form = new AddOrUpdatePersonForm(-1);
            form.ShowDialog();

        }

        private void FiltersCompoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TheFilterInformation.Clear();
            if (FiltersCompoBox.SelectedIndex ==1 )
            {
                TheFilterInformation.Mask = "";

            }
            else
            {

                TheFilterInformation.Mask = "0000000000000000000000000000000000";
            }
        }

       
        private void PersonCardWithFilter_Load(object sender, EventArgs e)
        {
            FiltersCompoBox.SelectedIndex = 0;
            TheFilterInformation.Clear();
        }
    }
    
}
