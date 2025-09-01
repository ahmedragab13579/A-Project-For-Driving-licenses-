namespace TheDataLayer_For_Project.Models.Applications.LocalApplication
{
    public class LocalDrivingLicenseApplication_View
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public string ClassName { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int PassedTestCount { get; set; }
        public string Status { get; set; }
    }
}
