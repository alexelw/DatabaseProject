namespace MyProject.Models{
    public class ScheduledJourney
{
    public int JourneyID { get; set; } // Primary Key
    public int BusID { get; set; } // Foreign Key
    public int RouteID { get; set; } // Foreign Key
    public DateTime ExpDeparture { get; set; }
    public DateTime? ActDeparture { get; set; } // Nullable
    public DateTime ExpArrival { get; set; }
    public DateTime? ActArrival { get; set; } // Nullable
    public int CurrentRoadID { get; set; } // Foreign Key
    public int NextRoadID { get; set; } // Foreign Key
    public int PreviousRoadID { get; set; } // Foreign Key
    public string Status { get; set; }
}

}