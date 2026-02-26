namespace Models
{
    public class Patient
    {
        public long PID { get; set; }
        public string? PNAME { get; set; }
        public string? PEMAIL { get; set; }
        public bool PFOREIGN { get; set; }
    }
}