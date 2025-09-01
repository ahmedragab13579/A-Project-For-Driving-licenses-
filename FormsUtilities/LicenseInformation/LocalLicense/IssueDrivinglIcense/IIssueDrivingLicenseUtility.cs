using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.LicenseInformation.LocalLicense.IssueDrivinglIcense
{
    public interface IIssueDrivingLicenseUtility
    {
        public void MakeTheApplicationCompleted(int Local);
        int PrepareTheDriverInfomation(int personId);
        void PrepareTheLicense(int personId, int Local, string Notes);  }
}
