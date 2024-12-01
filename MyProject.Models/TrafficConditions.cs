using MyProject.Enums;

namespace MyProject.Models{
    public class TrafficCondition
{
    public int TrafficID { get; set; } // Primary Key
    public int RoadID { get; set; } // Foreign Key
    public CurrentCondition CurrentCondition { get; set; }
    public DateTime TimeStamp { get; set; }

    

    public required Road road{ get; set; }
}
}