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
    public partial class ThePersonInformationForm : Form
    {
        int id;
        public ThePersonInformationForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ThePersonInformationForm_Load(object sender, EventArgs e)
        {
            personCard1.ThePersonInformation(id);
            personCard1.FillThePersonInformation();
        }
    }
}
