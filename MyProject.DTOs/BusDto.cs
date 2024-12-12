using System.ComponentModel.DataAnnotations;
using MyProject.Enums;

namespace MyProject.Data{
    public class BusDTO
{
    [Key] 
    public int BusID { get; set; } //primary key

    [Required]
    [MaxLength(15)]
    public required string RegistrationNum { get; set; }

    [Range(0, int.MaxValue)]
    public BusType BusType { get; set; }

    [Range(1, int.MaxValue)]
    public int TotalCapacity { get; set; }


    //One-to-Many Relationship: Bus -> BScheduledJourneys
    public ICollection<ScheduledJourneyDTO> ScheduledJourneyDTOs { get; set; } =new List<ScheduledJourneyDTO>();
    public ICollection<BusLocationDTO> BusLocationDTOs { get; set; } =new List<BusLocationDTO>();
}
}