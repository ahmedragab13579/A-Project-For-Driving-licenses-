using DVDL_DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDataLayer_For_Project.Models.Applications;

namespace FormsUtilities.Applications
{
    public interface IUpdateApplicationTypeUtility
    {


        void UpdateApplicationType(string Title, string Fees);
        bool ValidateApplicationInputs(string title, string feesText);

        ApplicationTypeDto GetApplicationType(int id);
    }
}
