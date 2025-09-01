using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSereens
{
    
    public partial class ChangePasswordForm : Form
    {
        public delegate void Refresh(object sender);
        public event Refresh RefreshTheManageDataInformation;

        private int ID;
        public ChangePasswordForm(int iD)
        {
            InitializeComponent();
            this.ID = iD;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            changePasswordControl1.FillTheData(ID);
        }

        private void RefreshTheMangeDataOfUsers(object sender)
        {
            RefreshTheManageDataInformation?.Invoke(this);

        }
    }
}
