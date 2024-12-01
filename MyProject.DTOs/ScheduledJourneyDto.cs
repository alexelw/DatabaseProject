namespace MyProject.Data{
    public class ScheduledJourneyDTO
{
    public int JourneyID { get; set; }
    public int BusID { get; set; }
    public int RouteID { get; set; }
    public DateTime ExpDeparture { get; set; }
    public DateTime? ActDeparture { get; set; }
    public DateTime ExpArrival { get; set; }
    public DateTime? ActArrival { get; set; }
    public required BusDTO busDTO { get; set; }
    public required BusRouteDTO busRouteDTO { get; set; }
}
}