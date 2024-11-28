using MyProject.Enums;

namespace MyProject.Data{
    public class PopularityDTO
{
    public int PopularityID { get; set; }
    public int StopID { get; set; } 
    public int RouteID { get; set; } 
    public PopularityScore PopularityScore { get; set; }

    public required BusStopDTO BusStopDTO { get; set; }
    public required BusRouteDTO BusRouteDTO { get; set; }
}
}