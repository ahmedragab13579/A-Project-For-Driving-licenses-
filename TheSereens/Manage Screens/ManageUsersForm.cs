using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThePusnissLayer.Users;

namespace TheSereens
{
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void AddAllFilters()
        {
            foreach (DataColumn Column in ClassDealWithDataOfTheUsers.PassAllDataFromTheUsers().Columns)
            {
                TheFiltersCommboBox.Items.Add(Column.ColumnName);

            }
        }



        private void ChangeMask(string TheFilterVariableInComboBox)
        {
            if (TheFilterVariableInComboBox == "IsActive")
            {
                IsActiveCompoBox.Visible= true;
                IsActiveCompoBox.Enabled= true;
                TheFilterInformaion.Visible= false;
                TheFilterInformaion.Enabled= false;


            }
            else
            {
                IsActiveCompoBox.Visible = false;
                IsActiveCompoBox.Enabled = false;
                TheFilterInformaion.Visible = true;
                TheFilterInformaion.Enabled = true;

            }
            if (TheFilterVariableInComboBox == "UserID" || TheFilterVariableInComboBox == "PersonID")
            {
                TheFilterInformaion.Mask = "000000000000000000000000";
            }
            else
            {
                TheFilterInformaion.Mask = "";

            }
            
          

        }


        private void MakeAFilter(string TheFilterVariable, string TheFilter)
        {
            DataView TheFilterData = ClassDealWithDataOfTheUsers.PassAllDataFromTheUsers().DefaultView;

            if (string.IsNullOrWhiteSpace(TheFilter))
            {
                TheFilterData.RowFilter = "";
                DataOfAllUsersDataGradeView.DataSource = TheFilterData;
                return;
            }

            if (TheFilterVariable == "PersonID" ||
                TheFilterVariable == "Gendor" ||
                TheFilterVariable == "NationalityCountryID")
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

            DataOfAllUsersDataGradeView.DataSource = TheFilterData;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            AddAllFilters();
            DataOfAllUsersDataGradeView.DataSource = ClassDealWithDataOfTheUsers.PassAllDataFromTheUsers();

        }

        private void TheFiltersOfCommboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMask(TheFiltersCommboBox.SelectedItem.ToString());
        }

        private void TheFilterInformationTextBox_TextChanged(object sender, EventArgs e)
        {
            MakeAFilter(TheFiltersCommboBox.SelectedItem.ToString(), TheFilterInformaion.Text);

        }

        private void DeleteTheUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataOfAllUsersDataGradeView.SelectedRows.Count > 0)
            {
                int index = DataOfAllUsersDataGradeView.SelectedRows[0].Index;
                int id = Convert.ToInt32(DataOfAllUsersDataGradeView.SelectedRows[0].Cells["UserID"].Value);
                ClassTheUserInformation.DeleteUser(id);
                DataOfAllUsersDataGradeView.DataSource = null;
                DataOfAllUsersDataGradeView.DataSource = ClassDealWithDataOfTheUsers.PassAllDataFromTheUsers();
            }
            else
            {
                MessageBox.Show("Please Chosse an item");
            }

        }

        private void TheInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataOfAllUsersDataGradeView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DataOfAllUsersDataGradeView.SelectedRows[0].Cells["UserID"].Value);
                UserInformationForm User =new UserInformationForm(id);
                User.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Chosse an Person");
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddOrUpdateUserForm AddUser = new AddOrUpdateUserForm(-1);
            AddUser.RefreshTheManageDataInformation+= RefreshTheDataOfAllTheUsers;
            AddUser.ShowDialog();   

        }

        private void UpdateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataOfAllUsersDataGradeView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DataOfAllUsersDataGradeView.SelectedRows[0].Cells["UserID"].Value);
                AddOrUpdateUserForm Userinfo = new AddOrUpdateUserForm(id);
                Userinfo.RefreshTheManageDataInformation += RefreshTheDataOfAllTheUsers;
                Userinfo.ShowDialog();
            }
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataOfAllUsersDataGradeView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DataOfAllUsersDataGradeView.SelectedRows[0].Cells["UserID"].Value);
                ChangePasswordForm ChangeUserPassword = new ChangePasswordForm(id);
                ChangeUserPassword.RefreshTheManageDataInformation += RefreshTheDataOfAllTheUsers;
                ChangeUserPassword.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Chosse an Person");
            }
        }
    
        
        private void RefreshTheDataOfAllTheUsers(object sender)
        {
            DataOfAllUsersDataGradeView.DataSource = null;
            DataOfAllUsersDataGradeView.DataSource = ClassDealWithDataOfTheUsers.PassAllDataFromTheUsers();
        }
    
    
    
    }
}
