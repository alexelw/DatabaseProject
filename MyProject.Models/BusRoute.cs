using System.ComponentModel.DataAnnotations;
using MyProject.Enums;

namespace MyProject.Models
{
public class BusRoute
{
    public int RouteID { get; set; } // Primary Key

    [Required]
    [MaxLength(50)]
    public required string RouteName { get; set; }

    [Range(0, int.MaxValue)]
    public int TotalDistance { get; set; }
    public RouteStatus Status { get; set; }


    public ICollection<ScheduledJourney>? ScheduledJourneys { get; set; } =new List<ScheduledJourney>();
    public ICollection<StopSequence>? StopSequence { get; set; } =new List<StopSequence>();
}
}