using DVDL_Business.After.DTOs;
using DVDL_InfrastructureLayer;
using DVDL_Persentation.Person_Information;
using FormsUtilities.PersonInformation.AddOrUpdatePerson;
using FormsUtilities.PersonInformation.PersonCard;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class PersonCardWithFilter : UserControl
    {

        IPersonCardUtility _PersonCardUtility;
        public event Action<int> UserFound;

        public PersonCardWithFilter()
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            personCard1.PersonFound += PersonCard1_PersonFound;
        }

        private void PersonCard1_PersonFound(int obj)
        {
            UserFound?.Invoke(int.Parse(TheFilterInformation.Text));
        }

        public PersonDto GetThePerson()
        {
            return personCard1.Person;
        }


        public void DisableTheFilter()
        {
            TheFilterGroupbox.Enabled = false;
        }

        public void FillThePersonInformation(int id)
        {
            personCard1.FillThePersonInformation(id);

        }

        public void SetUtility(IPersonCardUtility _PersonCardUtility)
        {
            this._PersonCardUtility = _PersonCardUtility;

        }

        private void MakeTheFilter()
        {
            if (TheFilterInformation.Text == "")
            {
                MessageBox.Show($"Please Write a {FiltersCompoBox.SelectedItem.ToString()}");
                return;
            }
            if (FiltersCompoBox.SelectedItem.ToString() == "Person ID")
            {
                personCard1.FillThePersonInformation(int.Parse(TheFilterInformation.Text));
            }
            else
            {
                personCard1.FillThePersonInformation(TheFilterInformation.Text);
            }
        }



        private void Searchbutton_Click(object sender, EventArgs e)
        {
            MakeTheFilter();
        }

        private void AddPersonbutton_Click(object sender, EventArgs e)
        {
            var UpdatePerson = Program.ServiceProvider.GetRequiredService<IAddOrUpdatePersonUtility>();

            AddOrUpdatePersonForm form = new AddOrUpdatePersonForm(UpdatePerson, -1);
            form.ShowDialog();
        }
        private void PersonCardWithFilter_Load(object sender, EventArgs e)
        {
            personCard1.SetUtility(_PersonCardUtility);
            FiltersCompoBox.SelectedIndex = 0;
            TheFilterInformation.Clear();
        }

        private void TheFilterInformation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FiltersCompoBox.SelectedIndex != 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        private void personCard1_PersonFound(int obj)
        {

        }
    }

}
