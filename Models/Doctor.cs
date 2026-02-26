using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("UXCONSULTANT")]
    public class Doctor
    {
        public long UNITID { get; set; }
        public string? UCDNAME { get; set; }
        public string? UCREGNO {get; set; }
    }
}