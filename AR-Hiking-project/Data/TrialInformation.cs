using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace AR_Hiking_project.Data
{
    public class TrialInformation
    {
        [Key]
        public int Id { get; set; }
        public string Fname { get; set; }
        public int DeptId { get; set; }
        public string Standing { get; set; }
        public List<WildliferIdentification> WildliferIdentification { get; set; }
    }
}
