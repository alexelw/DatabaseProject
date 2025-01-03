using System.ComponentModel.DataAnnotations;

namespace MyProject.Data{
    public class StopSequenceDTO
{
    [Key] 
    public int SequenceID { get; set; }
    public int RouteID { get; set; }
    public int StopID { get; set; }
    public int StopOrder { get; set; }

    
    public required BusRouteDTO  busRouteDTO{ get; set; } 
    public required BusStopDTO busStopDTO { get; set; }
}
}