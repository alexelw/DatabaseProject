using System.ComponentModel.DataAnnotations;

namespace MyProject.Data{
    public class ScheduledJourneyDTO
{
    [Key] 
    public int JourneyID { get; set; }
    public int BusID { get; set; }
    public int RouteID { get; set; }
    public DateTime ExpDeparture { get; set; }
    public DateTime? ActDeparture { get; set; }
    public DateTime ExpArrival { get; set; }
    public DateTime? ActArrival { get; set; }

    public BusDTO? BusDTO { get; set; }
    public BusRouteDTO? BusRouteDTO{ get; set; }

}
}