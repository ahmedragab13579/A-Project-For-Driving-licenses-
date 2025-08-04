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
    public partial class AddInternationalLicense : Form
    {
        int LocalID;
        public AddInternationalLicense(int localID)
        {
            InitializeComponent();
            LocalID = localID;
        }



        private void AddInternationalLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
