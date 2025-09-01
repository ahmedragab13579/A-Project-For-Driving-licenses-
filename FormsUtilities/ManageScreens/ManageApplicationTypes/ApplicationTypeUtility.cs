using DVDL_Business.After.ApplicationType;
using DVDL_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManageApplicationTypes
{
    public class ApplicationTypeUtility: IApplicationTypeUtility
    {
       private readonly IApplicationTypeService _ApplicationTypeService;
        List<ApplicationTypeDto> ApplicationTypeData;
        public ApplicationTypeUtility(IApplicationTypeService _ApplicationTypeService)
        {
            this._ApplicationTypeService = _ApplicationTypeService;


        }



        public void LoadData()
        {
            ApplicationTypeData = this._ApplicationTypeService.GetAll();

        }

        public int  FillTheRecordesNumber()
        {
            return ApplicationTypeData.Count;

        }

        public List<ApplicationTypeDto> FillTheApplicationTypesNumber()
        {
            return ApplicationTypeData;
        }


    }
}
