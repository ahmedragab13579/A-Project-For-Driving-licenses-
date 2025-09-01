using DVDL_Business.After.DTOs;
using DVDL_Business.After.People;
using FormsUtilities.PersonInformation.PersonCard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.PersonInformation.PersonLicenseHistory
{
    public interface IPersonLicenseHistoryUtility
    {
        PersonDto FillThePersonInformation(string NationlNo);
        DataTable ThePersonLicenseInformations();
        DataTable ThePersonInternatinalLicenseInformations();
        public IPersonCardUtility PersonUtility();
    }
}
