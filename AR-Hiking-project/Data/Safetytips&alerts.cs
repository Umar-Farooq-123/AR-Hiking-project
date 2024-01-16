using System.ComponentModel.DataAnnotations;

namespace AR_Hiking_project.Data
{
    public class Safetytips_alerts
    {
        [Key]
        public int MarkId { get; set; }
        public int Score { get; set; }
        public int Sid { get; set; }
        public int Cid { get; set; }
    }
}
