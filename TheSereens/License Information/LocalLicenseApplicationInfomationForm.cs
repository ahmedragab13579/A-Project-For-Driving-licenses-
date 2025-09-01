using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSereens.License_Information
{
    public partial class LocalLicenseApplicationInfomationForm : Form
    {
        int id;
        public LocalLicenseApplicationInfomationForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LocalLicenseInfomation_Load(object sender, EventArgs e)
        {
            licenseInfomations1.FillAllTheInfomation(id);
        }
    }
}
