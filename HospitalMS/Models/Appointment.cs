namespace HospitalMS
{
    public enum Status
    {
        New,
        Confirmed,
        Cancelled
    }
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public Patient Patient { get; set; }
        public int PatientID { get; set; }
        public Physician Physician { get; set; }
        public int PhysicianId { get; set; }
        public string Description { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentTime { get; set; }
        public Status Status { get; set; }
        public int DurationInMinutes { get; set; }

    }
}
