using DVDL_Business.After.ApplicationType;
using DVDL_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManageApplicationTypes
{
    public interface IApplicationTypeUtility
    {
        int FillTheRecordesNumber();
        void LoadData();
        List<ApplicationTypeDto> FillTheApplicationTypesNumber();
    }
}
