using DVDL_InfrastructureLayer;
using DVDL_Persentation.Person_Information;
using FormsUtilities.ManageScreens.ManagePeople.Utility;
using FormsUtilities.PersonInformation.AddOrUpdatePerson;
using FormsUtilities.PersonInformation.PersonCard;
using Microsoft.Extensions.DependencyInjection;
namespace DVDL_Persentation
{
    public partial class ManagePeopleForm : Form
    {
        private readonly IManagePeopleUtility _ManagePeople;

        public ManagePeopleForm(IManagePeopleUtility _ManagePeople)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._ManagePeople = _ManagePeople;
        }


        #region Finished
        private void AddAllFilters()
        {
            foreach (var Column in _ManagePeople.LoadData().Columns)
            {
                TheFiltersCommboBox.Items.Add(Column);

            }
        }
        private int SelectedPersonID()
        {
            return Convert.ToInt32(DataOfAllPeopleDataGradeView.SelectedRows[0].Cells["PersonID"].Value);
        }


        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {

            DataOfAllPeopleDataGradeView.DataSource = _ManagePeople.LoadData();
            TheRecordesNumberLable.Text = DataOfAllPeopleDataGradeView.Rows.Count.ToString();
            AddAllFilters();
            TheFiltersCommboBox.SelectedIndex = 0;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DeleteaThePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataOfAllPeopleDataGradeView.SelectedRows.Count > 0)
            {
                try
                {
                    _ManagePeople.Delete(SelectedPersonID());
                }
                catch
                {
                    MessageBox.Show("You can not delete this person because his data is connected with license");
                }
                DataOfAllPeopleDataGradeView.DataSource = _ManagePeople.LoadData();
            }
            else
            {
                MessageBox.Show("Please Chosse an item");
            }

        }

        private void TheInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Service = Program.ServiceProvider.GetRequiredService<IPersonCardUtility>();
            ThePersonInformationForm form = new ThePersonInformationForm(Service, SelectedPersonID());
            form.ShowDialog();
        }
        public void RafreshTheDataOfAllThePeople(object sender)
        {
            DataOfAllPeopleDataGradeView.DataSource = null;
            DataOfAllPeopleDataGradeView.DataSource = _ManagePeople.LoadData();
        }
        private void UpdateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var service = Program.ServiceProvider.GetRequiredService<IAddOrUpdatePersonUtility>();
            var form = new AddOrUpdatePersonForm(service, SelectedPersonID());
            form.RefreshingTheDataOfThePeople += RafreshTheDataOfAllThePeople;
            form.ShowDialog();

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_ManagePeople.IsNumericColumnName(TheFiltersCommboBox.SelectedItem.ToString()))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }
        private void Add_Click(object sender, EventArgs e)
        {
            var Service = Program.ServiceProvider.GetRequiredService<IAddOrUpdatePersonUtility>();
            AddOrUpdatePersonForm form = new AddOrUpdatePersonForm(Service, -1);
            form.ShowDialog();
        }
        private void FilterTextbox_TextChanged(object sender, EventArgs e)
        {
            if (TheFiltersCommboBox.SelectedIndex != 0)
            {
                DataOfAllPeopleDataGradeView.DataSource = FilterTheData.MakeAFilter(_ManagePeople.LoadData(),TheFiltersCommboBox.SelectedItem.ToString(), FilterTextbox.Text);

            }


        }
        private void TheFiltersCommboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTextbox.Clear();
            if (TheFiltersCommboBox.SelectedIndex == 0)
            {
                DataOfAllPeopleDataGradeView.DataSource = _ManagePeople.LoadData();
                TheRecordesNumberLable.Text = DataOfAllPeopleDataGradeView.Rows.Count.ToString();
                return;
            }
            EnabeldTimeDialoge();
        }
        #endregion Finished
        private void EnabeldTimeDialoge()
        {
            if (TheFiltersCommboBox.SelectedItem.ToString() == "DateOfBirth")
            {
                FilterTextbox.Enabled = false;
                FilterTextbox.Visible = false;

                dateTimePicker1.Enabled = true;
                dateTimePicker1.Visible = true;
            }
            else
            {
                FilterTextbox.Enabled = true;
                FilterTextbox.Visible = true;

                dateTimePicker1.Enabled = false;
                dateTimePicker1.Visible = false;
            }
        }





        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataOfAllPeopleDataGradeView.DataSource = FilterTheData.MakeAFilter(_ManagePeople.LoadData(),
                   TheFiltersCommboBox.SelectedItem.ToString(),
                   dateTimePicker1.Value.ToString("MM/dd/yyyy"));
        }

        private void TheProcessInPeople_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(DataOfAllPeopleDataGradeView.SelectedRows.Count==0)
            {
                MessageBox.Show("Plese Select a Person ");
                e.Cancel = true;
                return;
            }
            e.Cancel=false;

        }
    }
}













