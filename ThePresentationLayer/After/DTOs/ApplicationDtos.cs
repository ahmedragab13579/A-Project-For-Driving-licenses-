namespace DVDL_Business.After.DOTs
{
    public class ApplicationDtos
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; }
        public int StatusID { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal Fees { get; set; }
        public int CreatedByUserID { get; set; }

    }
}
