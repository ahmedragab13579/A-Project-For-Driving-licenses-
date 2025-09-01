namespace TheDataLayer_For_Project.Models.Licenses.InternationalLicense
{
    public class InternationalLicense
    {
        public int ID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssueUsingLicalLicenseID { get; set; }
        public DateTime IssueData { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByuserID { get; set; }
    }
}
