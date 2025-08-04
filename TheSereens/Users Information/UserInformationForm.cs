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
    public partial class UserInformationForm : Form
    {
        int ID;
        public UserInformationForm(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void UserInformationForm_Load(object sender, EventArgs e)
        {
            userCardControl1.FillTheInformation(ID);

        }
    }
}
