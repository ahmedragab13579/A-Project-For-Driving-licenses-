namespace DVDL_Business.After.DTOs
{
    public class DetainLicenseDto
    {
        public int LicenseID { get; set; }
        public decimal FineFees { get; set; }
        public int ID { get; set; }
        public int User { get; set; }
        public bool IsRelesd { get; set; }
        public int RelaisByuser { get; set; }
        public DateTime Date { get; set; }
        public DateTime RelaseDate { get; set; }
        public int RelaisAppID { get; set; }


    }
}
