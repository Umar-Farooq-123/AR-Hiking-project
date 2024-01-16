using System.ComponentModel.DataAnnotations;

namespace AR_Hiking_project.Data
{
    public class WildliferIdentification
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public int Fid { get; set; }
    }
}
