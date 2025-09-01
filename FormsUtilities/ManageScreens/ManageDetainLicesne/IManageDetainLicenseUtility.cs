using DVDL_Business.After.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManageDetainLicesne
{
    public interface IManageDetainLicenseUtility
    {
        int  FillTheRecordesNumber();
        List<DetainLicenseDto> FillTheDetainLicenseData();
        bool IsNumericalColumn(string Text);
   
        void LoadData();
        DriverDto GetDriverById(int id);
        LicenseDto GetLicenseById(int id);

        PersonDto GetPersonById(int id);
        LocalDrivingLicenseApplication_ViewDto GetLocalDrivingLicenseById(int id);
        public DataTable GetData();
 }
}
