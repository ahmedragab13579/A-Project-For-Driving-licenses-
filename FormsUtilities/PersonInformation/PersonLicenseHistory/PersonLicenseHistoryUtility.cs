using DVDL_Business.After.Driver;
using DVDL_Business.After.DTOs;
using DVDL_Business.After.InternationalLicense;
using DVDL_Business.After.License;
using DVDL_Business.After.People;
using DVDL_InfrastructureLayer;
using FormsUtilities.PersonInformation.PersonCard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project.Models.Licenses.InternationalLicense;

namespace FormsUtilities.PersonInformation.PersonLicenseHistory
{
    public class PersonLicenseHistoryUtility: IPersonLicenseHistoryUtility
    {
        PersonDto person;
        DriverDto driver;
        IDriverService _DriverService;
        IPersonService _PersonService;
        IInternationalService _InternationalService;
        ILicenseService _ILicenseService;
        IPersonCardUtility personCardUtility;
        public PersonLicenseHistoryUtility(IDriverService _DriverService,
        IPersonService _PersonService,
        IInternationalService _InternationalService,
        ILicenseService _ILicenseService, IPersonCardUtility personCardUtility)
        {
            this._DriverService = _DriverService;
            this._PersonService = _PersonService;
            this._InternationalService = _InternationalService;
            this._ILicenseService = _ILicenseService;
            this.personCardUtility = personCardUtility;
            person= new PersonDto();
            driver= new DriverDto();
            
        }

        public PersonDto FillThePersonInformation(string NationalNo)
        {
             PersonDto person = _PersonService.GetByNationalId(NationalNo);
            this.person = person;
            return this.person;
        }

        public DataTable ThePersonLicenseInformations()
        {
             driver = _DriverService.GetByPersonId(person.PersonID);
            DataTable DriverLicenses =ChangeDataType. ToDataTable(_ILicenseService.GetByDriverId(driver.ID));
            if (DriverLicenses.Rows.Count > 0)
            {
                DataTable LicensesData = DriverLicenses.DefaultView.ToTable(false, "ID", "ApplicationID", "IssueDate", "ExpirationDate", "IsActive");
                return LicensesData;
            }
            return null;

        }
        public DataTable ThePersonInternatinalLicenseInformations()
        {
            DataTable DriverLicenses = ChangeDataType. ToDataTable(_InternationalService.GetByDriverId(driver.ID));
            if (DriverLicenses.Rows.Count > 0)
            {
                DataTable LicensesData = DriverLicenses.DefaultView.ToTable(false, "ID", "ApplicationID", "IssueData", "ExpirationDate", "IsActive");
                return LicensesData;
            }
            return null;

        }

        public IPersonCardUtility PersonUtility()
        {
            return personCardUtility;
        }
    }
}
