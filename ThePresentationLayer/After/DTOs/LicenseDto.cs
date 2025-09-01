namespace DVDL_Business.After.DTOs
{
    public class LicenseDto
    {
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public int ID { get; set; }
        public int IssueReason { get; set; }
        public int ApplicationID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public decimal Fees { get; set; }
    }
}
