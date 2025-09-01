namespace TheDataLayer_For_Project.Models.Licenses
{
    public class License
    {
        public int DriverID { get; set; } = 0;
        public int LicenseClass { get; set; } = 0;
        public int ID { get; set; } = 0;
        public int IssueReason { get; set; } = 0;
        public int ApplicationID { get; set; } = 0;
        public int CreatedByUserID { get; set; } = 0;
        public DateTime IssueDate { get; set; }= DateTime.Now;
        public DateTime ExpirationDate { get; set; }=DateTime.Now;
        public string Notes { get; set; } = "";
        public bool IsActive { get; set; }=false;
        public decimal Fees { get; set; } = 0;
    }
}
