using DVDL_Business.After.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManageInternationalLicense
{
    public interface IManageInternationalLicenseUtility
    {
        LocalDrivingLicenseApplication_ViewDto GetLocalDrivingLicense(int id);
        void LoadData();
        DataTable GetData();
        int PersonID(int id);
        string PersonNationalNo(int id);
        int RecordesNumber();
        bool IsNumcericalCoulumn(string name);

    }
}
