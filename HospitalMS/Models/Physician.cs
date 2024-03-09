namespace HospitalMS
{
    public class Physician
    {
        public int PhysicianId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Specialty> Specialties { get; set; }
        public DateTime DateOfHire { get; set; }
    }
}
