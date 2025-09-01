namespace TheDataLayer_For_Project.Models.Appointment
{
    public class Appointment
    {
        public int ID { get; set; }
        public int TestTypeID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }

    }
}
