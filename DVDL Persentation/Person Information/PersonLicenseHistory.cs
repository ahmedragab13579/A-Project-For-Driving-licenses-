using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.InternationalLicense;
using DVDL_Business.After.License;
using DVDL_Business.After.People;
using DVDL_InfrastructureLayer;
using FormsUtilities.PersonInformation.PersonLicenseHistory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace DVDL_Persentation
{
    public partial class PersonLicenseHistory : Form
    {
        string NationalNo;
     

        private readonly IPersonLicenseHistoryUtility _PersonLicenseHistoryUtility;
        public PersonLicenseHistory(string nationalNo, IPersonLicenseHistoryUtility _PersonLicenseHistoryUtility)
        {
            InitializeComponent(); AppTheme.ApplyTheme(this);

            NationalNo = nationalNo;
          
            this._PersonLicenseHistoryUtility = _PersonLicenseHistoryUtility;
            personCard1.SetUtility(this._PersonLicenseHistoryUtility.PersonUtility());
        }


        private void FillAllTheInformations()
        {
            PersonLicenses.DataSource = _PersonLicenseHistoryUtility. ThePersonLicenseInformations();
            InternationalLicenses.DataSource = _PersonLicenseHistoryUtility.ThePersonInternatinalLicenseInformations();
        }
     
        
        
        
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PersonLicenseHistory_Load(object sender, EventArgs e)
        {
            personCard1.FillThePersonInformation(NationalNo);
            _PersonLicenseHistoryUtility. FillThePersonInformation(NationalNo);
            FillAllTheInformations();

        }
    }
}
