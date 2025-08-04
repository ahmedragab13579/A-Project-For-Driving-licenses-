using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Applications.LocalLisense;
using ThePusnissLayer.Drivers;

namespace TheSereens.Manage_Screens
{
    public partial class ManageDrivers : Form
    {
        public ManageDrivers()
        {
            InitializeComponent();
        }


        private void FillTheDrivers()
        {
            DataTable TheFilterData = ClassDealWithDataOfTheDrivers.PassAllTheDrivers();
            Drivers.DataSource = TheFilterData;
            Drivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }


        private void FillTheRecords()
        {
            RecordesLabel.Text=Drivers.Rows.Count.ToString();
        }

        private void MakeAFilter(string TheFilterVariable, string TheFilter)
        {
            DataView TheFilterData = ClassDealWithDataOfTheDrivers.PassAllTheDrivers().DefaultView;

            if (string.IsNullOrWhiteSpace(TheFilter))
            {
                TheFilterData.RowFilter = "";
                Drivers.DataSource = TheFilterData;
                Drivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                return;
            }
            if (TheFilterVariable == "PersonID" || TheFilterVariable == "DriverID")
            {

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
                string escaped = TheFilter.Replace("'", "''");
                TheFilterData.RowFilter = $"{TheFilterVariable} LIKE '%{escaped}%'";
            }
            Drivers.DataSource = TheFilterData;
            Drivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FillTheRecords();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Filters.SelectedItem.ToString() == "DriverID" || Filters.SelectedItem.ToString() == "PersonID")
            {
                   if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                   {
                       e.Handled = true;
                   }

            }
            else
            {
                e.Handled = false;
            }
        }

        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            FillTheDrivers();

            Filters.SelectedIndex = 0;
            FillTheRecords() ;
        }

        private void FilterInfomation_TextChanged(object sender, EventArgs e)
        {
            MakeAFilter(Filters.SelectedItem.ToString(),FilterInfomation.Text);
        }
    }
}
