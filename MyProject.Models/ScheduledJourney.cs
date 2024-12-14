using System.ComponentModel.DataAnnotations;

namespace MyProject.Models{
    public class ScheduledJourney
{
    [Key] 
    public int JourneyID { get; set; } // Primary Key
    public int BusID { get; set; } // Foreign Key
    public int RouteID { get; set; } // Foreign Key
    public DateTime ExpDeparture { get; set; }
    public DateTime? ActDeparture { get; set; } 
    public DateTime ExpArrival { get; set; }
    public DateTime? ActArrival { get; set; } 
    
    public Bus? Bus { get; set; }
    public BusRoute? BusRoute{ get; set; }
}
}