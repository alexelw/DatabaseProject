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
    public int CurrentRoadID { get; set; }
    public int NextRoadID { get; set; }
    public int PreviousRoadID { get; set; }
    public string? Status { get; set; }
}

}