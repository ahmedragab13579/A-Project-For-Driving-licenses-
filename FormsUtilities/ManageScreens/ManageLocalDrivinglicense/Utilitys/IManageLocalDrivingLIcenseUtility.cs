using DVDL_Business.After.DTOs;
using FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Status.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Utilitys
{
    public interface IManageLocalDrivingLIcenseUtility
    {
        List<string> AddAllFilters();

        void LoadData();
        DataTable GetData();

        int FillRecoreds();

        int ApplicationID(int ApplicationId);

        bool CancelApplication(int ApplicationId);

        bool DeleteApplication(int ApplicationId);
        bool DeleteLocalApplication(int ApplicationId);

        int LocalDrivingLicenseID(int LocalDrivingLicenseApplicationID);
        LocalDrivingLicenseApplication_ViewDto GetLocalDrivingLicense(int id);
        LocalLIcenseStatus GetState(int passedTestCount, string status);
    }
}
