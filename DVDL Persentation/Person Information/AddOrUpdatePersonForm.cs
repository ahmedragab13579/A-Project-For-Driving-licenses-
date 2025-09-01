using DVDL_InfrastructureLayer;
using FormsUtilities.PersonInformation.AddOrUpdatePerson;

namespace DVDL_Persentation.Person_Information
{
    public partial class AddOrUpdatePersonForm : Form
    {
        public delegate void RefreshTheDataTheLinked(object sender);
        public event RefreshTheDataTheLinked RefreshingTheDataOfThePeople;

        private int id = -1;
        private AddOrUpdataPerson addPersonControl;

        public AddOrUpdatePersonForm(IAddOrUpdatePersonUtility service, int id = -1)
        {
            InitializeComponent();
            AppTheme.ApplyTheme(this);

            addPersonControl = new AddOrUpdataPerson();
            addPersonControl.SetUtility(service);
            addPersonControl.Dock = DockStyle.Fill;
            this.Controls.Add(addPersonControl);

            this.id = id;
            addPersonControl.SetID(id);
        }

        private void RefreshTheData(object sender)
        {
            RefreshingTheDataOfThePeople?.Invoke(this);
        }

        private void AddOrUpdatePersonForm_Load(object sender, EventArgs e)
        {
            addPersonControl.TheLastStepFromRefreshing += RefreshTheData;
            addPersonControl.SetID(this.id);

            this.ResumeLayout();
        }
    }
}
