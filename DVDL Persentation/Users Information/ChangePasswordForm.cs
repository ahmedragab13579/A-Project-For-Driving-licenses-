using DVDL_InfrastructureLayer;
using FormsUtilities.UserInformation.ChangePasssword;

namespace DVDL_Persentation
{

    public partial class ChangePasswordForm : Form
    {
        public event EventHandler RefreshTheManageDataInformation;

        private int ID;
        IChangePasswordUtility _ChangePasswordUtility;
        public ChangePasswordForm(IChangePasswordUtility _ChangePasswordUtility ,int iD )
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this.ID = iD;
            this._ChangePasswordUtility = _ChangePasswordUtility;
            changePasswordControl1.SetUtility(this._ChangePasswordUtility);
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            changePasswordControl1.FillTheData(ID);
            changePasswordControl1.RefreshTheDataInManageUsers += RefreshManageData;
        }

        private void RefreshManageData(object? sender, EventArgs e)
        {
            RefreshTheManageDataInformation?.Invoke(this, EventArgs.Empty);
        }
    }
}
