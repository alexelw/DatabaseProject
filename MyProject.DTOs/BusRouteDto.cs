using System.ComponentModel.DataAnnotations;
using MyProject.Enums;

namespace MyProject.Data{
    public class BusRouteDTO
{
    public int RouteID { get; set; } // Primary Key

    [Required]
    [MaxLength(50)]
    public required string RouteName { get; set; }

    [Range(0, int.MaxValue)]
    public int TotalDistance { get; set; }
    public RouteStatus Status { get; set; }


    public ICollection<ScheduledJourneyDTO>? ScheduledJourneyDTOs { get; set; } =new List<ScheduledJourneyDTO>();
    
    public ICollection<PopularityDTO>? PopularityDTOs { get; set; } =new List<PopularityDTO>();
}
}
