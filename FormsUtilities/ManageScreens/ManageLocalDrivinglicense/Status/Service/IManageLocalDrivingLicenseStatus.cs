using FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Status.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Status.Service
{
     public interface IManageLocalDrivingLicenseStatus
    {
        public LocalLIcenseStatus GetState(int passedTestCount, string status);
    }
}
