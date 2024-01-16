using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace AR_Hiking_project.Data
{
    public class Landmarkrecognition
    {
        [Key]
        public int Id { get; set; }
        public int Sid { get; set; }
        public int Cid { get; set; }
        public WildliferIdentification WildliferIdentification { get; set; }
        public List<Mark> Mark { get; set; }
    }
}
