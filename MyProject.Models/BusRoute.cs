using System.ComponentModel.DataAnnotations;
using MyProject.Enums;

namespace MyProject.Models
{
public class BusRoute
{
    [Key] 
    public int RouteID { get; set; } // Primary Key

    [Required]
    [MaxLength(50)]
    public required string RouteName { get; set; }

    [Range(0, int.MaxValue)]
    public int TotalDistance { get; set; }
    public RouteStatus Status { get; set; }


    public ICollection<ScheduledJourney>? ScheduledJourneys { get; set; } =new List<ScheduledJourney>();
    public ICollection<Popularity>? popularity { get; set; } =new List<Popularity>();
    public ICollection<StopSequence>? stopSequences { get; set; } =new List<StopSequence>();
    public ICollection<BusLocation>? busLocations { get; set; } =new List<BusLocation>();

}
}