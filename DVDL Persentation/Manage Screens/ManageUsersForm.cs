
using DVDL_InfrastructureLayer;
using FormsUtilities.ManageScreens.ManageUsers;
using FormsUtilities.UserInformation.AddOrUpdateUserInformation;
using FormsUtilities.UserInformation.ChangePasssword;
using FormsUtilities.UserInformation.UserCard;
using Microsoft.Extensions.DependencyInjection;

namespace DVDL_Persentation
{
    public partial class ManageUsersForm : Form
    {
        IManageUsersUtility _ManageUsersUtility;
        public ManageUsersForm(IManageUsersUtility _ManageUsersUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this._ManageUsersUtility = _ManageUsersUtility;
        }


        #region Finished
        private void ChangeMask(string TheFilterVariableInComboBox)
        {
            if (TheFilterVariableInComboBox == "IsActive")
            {
                IsActiveCompoBox.Visible = true;
                IsActiveCompoBox.Enabled = true;
                TheFilterInformaion.Visible = false;
                TheFilterInformaion.Enabled = false;


            }
            else
            {
                IsActiveCompoBox.Visible = false;
                IsActiveCompoBox.Enabled = false;
                TheFilterInformaion.Visible = true;
                TheFilterInformaion.Enabled = true;

            }


        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            _ManageUsersUtility.LoadData();
            DataOfAllUsersDataGradeView.DataSource = _ManageUsersUtility.GetData();
            TheFiltersCommboBox.Items.AddRange(_ManageUsersUtility.AddAllFilters().ToArray());
            _ManageUsersUtility.FillRecordes();
            TheFiltersCommboBox.SelectedIndex = 0;
        }
        private void TheFilterInformaion_TextChanged(object sender, EventArgs e)
        {
            if(TheFiltersCommboBox.SelectedItem.ToString()!="None")
            {
            DataOfAllUsersDataGradeView.DataSource = FilterTheData.MakeAFilter(_ManageUsersUtility.GetData(),TheFiltersCommboBox.SelectedItem.ToString(), TheFilterInformaion.Text);

            }

        }
        private void IsActiveCompoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TheFiltersCommboBox.SelectedItem.ToString() != "None")
            {
            DataOfAllUsersDataGradeView.DataSource = _ManageUsersUtility.MakeIsActiveFilter(TheFiltersCommboBox.SelectedItem.ToString(), (IsActiveCompoBox.SelectedItem.ToString()=="Yes"?true:false));

            }


        }
        private void RefreshTheDataOfAllTheUsers(object? sender, EventArgs e)
        {
            DataOfAllUsersDataGradeView.DataSource = null;
            _ManageUsersUtility.LoadData();
            DataOfAllUsersDataGradeView.DataSource = _ManageUsersUtility.GetData();
            _ManageUsersUtility.FillRecordes();

        }
        private void RefreshTheDataOfAllTheUsers()
        {
            DataOfAllUsersDataGradeView.DataSource = null;
            _ManageUsersUtility.LoadData();
            DataOfAllUsersDataGradeView.DataSource = _ManageUsersUtility.GetData();
            _ManageUsersUtility.FillRecordes();

        }
        private void TheInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataOfAllUsersDataGradeView.SelectedRows.Count > 0)
            {
                var formFactory = Program.ServiceProvider.GetRequiredService<IUsercardUtility>();
                int id = Convert.ToInt32(DataOfAllUsersDataGradeView.SelectedRows[0].Cells["UserID"].Value);
                UserInformationForm User = new UserInformationForm(formFactory, id);
                User.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Chosse an Person");
            }
        }
        private void TheFiltersOfCommboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TheFilterInformaion.Clear();    
            if(TheFiltersCommboBox.SelectedItem.ToString()== "None")
            {
                RefreshTheDataOfAllTheUsers();
                return;

            }
            ChangeMask(TheFiltersCommboBox.SelectedItem.ToString());
        }
        private void DeleteTheUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataOfAllUsersDataGradeView.SelectedRows.Count > 0)
            {
                int index = DataOfAllUsersDataGradeView.SelectedRows[0].Index;
                int id = Convert.ToInt32(DataOfAllUsersDataGradeView.SelectedRows[0].Cells["UserID"].Value);
                try
                {
                   _ManageUsersUtility.Delete(id);
                }
                catch
                {
                    MessageBox.Show("You can not delete this user because he have a Connected information is system");
                }

               // RefreshTheDataOfAllTheUsers(sender);
            }
            else
            {
                MessageBox.Show("Please Chosse an item");
            }

        }
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var formFactory = Program.ServiceProvider.GetRequiredService<IAddOrUpdateUserInformation>();

            AddOrUpdateUserForm form = new AddOrUpdateUserForm(-1,formFactory);

            form.ShowDialog();
        }
        private void UpdateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataOfAllUsersDataGradeView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DataOfAllUsersDataGradeView.SelectedRows[0].Cells["UserID"].Value);
                var formFactory = Program.ServiceProvider.GetRequiredService<IAddOrUpdateUserInformation>();
                AddOrUpdateUserForm form = new AddOrUpdateUserForm(id, formFactory);
                form.ShowDialog();

            }
        }
        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataOfAllUsersDataGradeView.SelectedRows.Count > 0)
            {
                var formFactory = Program.ServiceProvider.GetRequiredService<IChangePasswordUtility>();
                int id = Convert.ToInt32(DataOfAllUsersDataGradeView.SelectedRows[0].Cells["UserID"].Value);
                ChangePasswordForm ChangeUserPassword = new ChangePasswordForm(formFactory, id);

                ChangeUserPassword.RefreshTheManageDataInformation += RefreshTheDataOfAllTheUsers;


                ChangeUserPassword.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Chosse an Person");
            }
        }
        private void TheFilterInformaion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TheFiltersCommboBox.SelectedItem.ToString() == "UserID" || TheFiltersCommboBox.SelectedItem.ToString() == "PersonID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }


        }

        #endregion Finished


    }
}
