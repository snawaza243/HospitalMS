﻿namespace HospitalMS;

public class Admission
{
    public int AdmissionId { get; set; }
    public string Complaint { get; set; }
    public Patient Patient { get; set; }
    public int PatientId { get; set; }
    public Room Room { get; set; }
    public int RoomId { get; set; }
    public DateTime AdmissionDate { get; set; }
    public DateTime AdmissionTime { get; set; }

}
