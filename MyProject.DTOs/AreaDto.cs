using System.ComponentModel.DataAnnotations;

namespace MyProject.Data{
    public class AreaDTO
{
    [Key] 
    public int AreaID { get; set; }

    [Required]
    [MaxLength(50)]
    public required string AreaName { get; set; }

    [Range(0, int.MaxValue)]
    public int Population { get; set; }

    
    // One-to-Many Relationship: Area -> BusStops
    public ICollection<BusStopDTO> BusStopDTOs { get; set; } =new List<BusStopDTO>();
}
}

