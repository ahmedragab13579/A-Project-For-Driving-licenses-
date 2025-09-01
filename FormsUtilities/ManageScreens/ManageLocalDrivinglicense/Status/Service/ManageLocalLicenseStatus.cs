using FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Status.Model;


namespace FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Status.Service
{
    public class ManageLocalLicenseStatus : IManageLocalDrivingLicenseStatus
    {
        private readonly Dictionary<int, LocalLIcenseStatus> _states;
        public ManageLocalLicenseStatus()
        {
            _states = new Dictionary<int, LocalLIcenseStatus>
            {
                [1] = new LocalLIcenseStatus
                {
                    ScheduleEnabled = true,
                    VisionEnabled = false,
                    WritingEnabled = true,
                    StreetEnabled = false,
                    IssueEnabled = false,
                    ShowLicenseInfoEnabled = false,
                    DeleteEnabled = true,
                    CancelEnabled = true
                },
                [2] = new LocalLIcenseStatus
                {
                    ScheduleEnabled = true,
                    VisionEnabled = false,
                    WritingEnabled = false,
                    StreetEnabled = true,
                    IssueEnabled = false,
                    ShowLicenseInfoEnabled = false,
                    DeleteEnabled = true,
                    CancelEnabled = true
                },
                [0] = new LocalLIcenseStatus
                {
                    ScheduleEnabled = true,
                    VisionEnabled = true,
                    WritingEnabled = false,
                    StreetEnabled = false,
                    IssueEnabled = false,
                    ShowLicenseInfoEnabled = false,
                    DeleteEnabled = true,
                    CancelEnabled = true
                }
            };
        }

        public LocalLIcenseStatus GetState(int passedTestCount, string status)
        {
            if(status== "Cancelled")
            {
                return new LocalLIcenseStatus
                {
                    ScheduleEnabled = false,
                    VisionEnabled = false,
                    WritingEnabled = false,
                    StreetEnabled = false,
                    IssueEnabled = false ,
                    ShowLicenseInfoEnabled =false,
                    DeleteEnabled = true,
                    CancelEnabled = false,
                    
                };

            }
            if (passedTestCount == 3)
            {
                return new LocalLIcenseStatus
                {
                    ScheduleEnabled = false,
                    VisionEnabled = false,
                    WritingEnabled = false,
                    StreetEnabled = false,
                    IssueEnabled = status != "Completed",
                    ShowLicenseInfoEnabled = status == "Completed",
                    DeleteEnabled = false,
                    CancelEnabled = false
                };
            }

            return _states.ContainsKey(passedTestCount)
                ? _states[passedTestCount]
                : _states[0];
        }
    }
}
