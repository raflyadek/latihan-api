namespace dto
{
    public class PatientUpdateRequest
    {
        public long? PID { get; set; }
        public string? PNAME { get; set; }
        public string? PEMAIL { get; set; }
        public string? PRN { get; set; }
        public DateOnly? PDOB { get; set; }
        public bool? PFOREIGN { get; set; }
    }
}