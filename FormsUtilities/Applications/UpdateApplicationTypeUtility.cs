using DVDL_Business.After.ApplicationType;
using DVDL_DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.Applications
{
    public class UpdateApplicationTypeUtility : IUpdateApplicationTypeUtility
    {
        private readonly IApplicationTypeService _ApplicationType;
        ApplicationTypeDto ApplicationType;

        public UpdateApplicationTypeUtility( IApplicationTypeService _ApplicationType)
        {
            this._ApplicationType = _ApplicationType;
            
        }
    
        private void FillTheApplicationInformationAfterUpdate( string Title, string Fees)
        {
            ApplicationType.Title = Title;
            ApplicationType.Fees =decimal.Parse( Fees);    
        }

        public ApplicationTypeDto GetApplicationType(int id)
        {
            loadData(id);
            return ApplicationType;
        }

        private void loadData(int id)
        {
            ApplicationType = _ApplicationType.GetById(id);
        }

        public void UpdateApplicationType(string Title, string Fees)
        {
            FillTheApplicationInformationAfterUpdate(Title, Fees);
            _ApplicationType.Update(ApplicationType);
        }

        public bool ValidateApplicationInputs(string title, string feesText)
        {
            if (string.IsNullOrWhiteSpace(title))
                return false;

            if (!decimal.TryParse(feesText, out decimal fees) || fees <= 0)
                return false;

            return true ;
        }



    }
}
