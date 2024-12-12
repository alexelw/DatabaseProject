using System.ComponentModel.DataAnnotations;
using MyProject.Enums;

namespace MyProject.Models{
    public class Popularity
{
    [Key] 
    public int PopularityID { get; set; }
    public int StopID { get; set; } 
    public int RouteID { get; set; } 
    public PopularityScore PopularityScore { get; set; }

    public required BusStop BusStop { get; set; }
    public required BusRoute BusRoute { get; set; }
}
}