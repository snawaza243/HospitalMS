namespace HospitalMS
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }

    }
}
