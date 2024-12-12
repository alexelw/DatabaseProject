using System.ComponentModel.DataAnnotations;
using MyProject.Enums;

namespace MyProject.Models
{
public class Bus
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


    //One-to-Many Relationship: Bus -> ScheduledJourneys
    public ICollection<BusLocation> BusLocations {get; set; }= new List<BusLocation>();
    public ICollection<ScheduledJourney> ScheduledJourneys { get; set; } =new List<ScheduledJourney>();
}
}
