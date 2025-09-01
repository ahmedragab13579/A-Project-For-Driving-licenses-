using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Status.Model
{
    public class LocalLIcenseStatus
    {
    
            public bool ScheduleEnabled { get; set; }
            public bool VisionEnabled { get; set; }
            public bool WritingEnabled { get; set; }
            public bool StreetEnabled { get; set; }
            public bool IssueEnabled { get; set; }
            public bool ShowLicenseInfoEnabled { get; set; }
            public bool DeleteEnabled { get; set; }
            public bool CancelEnabled { get; set; }
        

    }
}
