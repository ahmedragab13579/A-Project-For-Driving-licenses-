using DVDL_InfrastructureLayer;
using FormsUtilities.ManageScreens.ManageDrivers;

namespace DVDL_Persentation.Manage_Screens
{
    public partial class ManageDrivers : Form
    {
        IManageDriversUtility _ManageDriversUtility;
        public ManageDrivers(IManageDriversUtility _ManageDriversUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._ManageDriversUtility = _ManageDriversUtility;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_ManageDriversUtility.IsNumericColumnName(Filters.SelectedItem.ToString()))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            try
            {
                _ManageDriversUtility.LoadData();
                var table = _ManageDriversUtility.FillTheDrivers();
                DriversData.AutoGenerateColumns = true;
                DriversData.DataSource = table;
                RecordesLabel.Text = _ManageDriversUtility.FillTheRecords().ToString();
                Filters.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading drivers: " + ex.Message);
            }
        }

        private void FilterInfomation_TextChanged(object sender, EventArgs e)
        {
            if (Filters.SelectedIndex != 0)
            {
                FilterTheData.MakeAFilter(_ManageDriversUtility.FillTheDrivers(),Filters.SelectedItem.ToString(), FilterInfomation.Text);
                RecordesLabel.Text = DriversData.Rows.Count.ToString();
            }
        }

        private void Filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInfomation.Clear();
            if(Filters.SelectedIndex == 0)
            {
                _ManageDriversUtility.LoadData();
                var table = _ManageDriversUtility.FillTheDrivers();
                DriversData.AutoGenerateColumns = true;
                DriversData.DataSource = table;
            }
        }
    }
}
