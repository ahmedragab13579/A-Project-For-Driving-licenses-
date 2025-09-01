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
    public partial class AddOrUpdatePersonForm : Form
    {
        private AddOrUpdataPerson addOrUpdataPerson1;
        
        public delegate void RefreshTheDataTheLinked(object sender);
        public event RefreshTheDataTheLinked RefreshingTheDataOfThePeople;
       
        int id;
        public AddOrUpdatePersonForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

       
        private void AddOrUpdatePersonForm_Load(object sender, EventArgs e)
        {
            this.addOrUpdataPerson1 = new TheSereens.AddOrUpdataPerson(id);
            addOrUpdataPerson1.TheLastStepFromRefreshing += RefreshTheData;
            this.SuspendLayout();
            this.addOrUpdataPerson1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrUpdataPerson1.Location = new System.Drawing.Point(27, 108);
            this.addOrUpdataPerson1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addOrUpdataPerson1.Name = "addOrUpdataPerson1";
            this.addOrUpdataPerson1.Size = new System.Drawing.Size(832, 427);
            this.addOrUpdataPerson1.TabIndex = 0;
            this.Controls.Add(addOrUpdataPerson1);

        }
        private void RefreshTheData(object sender)
        {
            RefreshingTheDataOfThePeople?.Invoke(this);
        }
       
        


    }
}
