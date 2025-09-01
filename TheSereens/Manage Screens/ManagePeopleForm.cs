using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.People;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TheSereens
{
    public partial class ManagePeopleForm : Form
    {
        DataTable DataTableOfThePeople = ClassDealWithDataFromThePeople.PassAllDataFromThePeople();
        public ManagePeopleForm()
        {
            InitializeComponent();
        }
        
       
        private void AddAllFilters()
        {
            foreach(DataColumn Column in DataTableOfThePeople.Columns)
            {
                TheFiltersCommboBox.Items.Add(Column.ColumnName);

            }
        }
        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {

            DataOfAllPeopleDataGradeView.DataSource = DataTableOfThePeople;
            TheRecordesNumberLable.Text=DataTableOfThePeople.Rows.Count.ToString();
            AddAllFilters();

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddPeopleButton_Click(object sender, EventArgs e)
        {
            AddOrUpdatePersonForm AddTheNewPerson =new AddOrUpdatePersonForm(-1);
            AddTheNewPerson.RefreshingTheDataOfThePeople+= RafreshTheDataOfAllThePeople;
            AddTheNewPerson.ShowDialog();
        }
        private void MakeAFilter(string TheFilterVariable, string TheFilter)
        {
            DataView TheFilterData = DataTableOfThePeople.DefaultView;

            if (string.IsNullOrWhiteSpace(TheFilter))
            {
                TheFilterData.RowFilter = "";
                TheFilterInformationTextBox.Mask = "";
                DataOfAllPeopleDataGradeView.DataSource = TheFilterData;
                return;
            }

            if (TheFilterVariable == "PersonID" || 
                TheFilterVariable == "Gendor" || 
                TheFilterVariable == "NationalityCountryID")
            {
                TheFilterInformationTextBox.Mask = "00000000000000000000000000";

                if (int.TryParse(TheFilter, out int numericValue))
                {
                    TheFilterData.RowFilter = $"{TheFilterVariable} = {numericValue}";
                }
                else
                {
                    TheFilterData.RowFilter = "";
                }
            }
            else  
            {
                TheFilterInformationTextBox.Mask = "";
                string escaped = TheFilter.Replace("'", "''");
                TheFilterData.RowFilter = $"{TheFilterVariable} LIKE '%{escaped}%'";
            }

            DataOfAllPeopleDataGradeView.DataSource = TheFilterData;
        }




        private void TheFilterInformationTextBox_TextChanged(object sender, EventArgs e)
        {
            MakeAFilter(TheFiltersCommboBox.SelectedItem.ToString(),TheFilterInformationTextBox.Text);

        }


        private void UpdateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DataOfAllPeopleDataGradeView.SelectedRows[0].Cells["PersonID"].Value);
            AddOrUpdatePersonForm UpdatePerson = new AddOrUpdatePersonForm(id);
            UpdatePerson.RefreshingTheDataOfThePeople += RafreshTheDataOfAllThePeople;
            UpdatePerson.ShowDialog();

        }

        private void DeleteaThePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DataOfAllPeopleDataGradeView.SelectedRows.Count>0)
            {
                int index=DataOfAllPeopleDataGradeView.SelectedRows[0].Index;
                int id = Convert.ToInt32(DataOfAllPeopleDataGradeView.SelectedRows[0].Cells["PersonID"].Value);
                ClassPersonInformation.DeletePerson(id);
                DataTableOfThePeople.Rows[index].Delete();
                DataOfAllPeopleDataGradeView.DataSource = null;
                DataOfAllPeopleDataGradeView.DataSource=DataTableOfThePeople;


            }
            else
            {
                MessageBox.Show("Please Chosse an item");
            }

        }

        private void TheInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DataOfAllPeopleDataGradeView.SelectedRows[0].Cells["PersonID"].Value);
            Form PersonInformation= new ThePersonInformationForm(id);
            PersonInformation.ShowDialog();
        }

        public void RafreshTheDataOfAllThePeople(object sender)
        {
             DataOfAllPeopleDataGradeView.DataSource=null;
            DataOfAllPeopleDataGradeView.DataSource = ClassDealWithDataFromThePeople.PassAllDataFromThePeople();
        }



    }
   }
    












