using DVDL_InfrastructureLayer;
using FormsUtilities.PersonInformation.PersonCard;
using System;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class ThePersonInformationForm : Form
    {
        int id;
        IPersonCardUtility _personCard;
        public ThePersonInformationForm(IPersonCardUtility _personCard, int id)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            this.id = id;
            this._personCard = _personCard;
        }

        private void ThePersonInformationForm_Load(object sender, EventArgs e)
        {
            personCard1.SetUtility(_personCard);
            personCard1.FillThePersonInformation(id);
        }
    }
}
