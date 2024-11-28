namespace MyProject.Models{
    public class TrafficCondition
{
    public int TrafficID { get; set; } // Primary Key
    public int RoadID { get; set; } // Foreign Key
    public string CurrentCondition { get; set; }
    public DateTime TimeStamp { get; set; }
    public int AreaID { get; set; } // Foreign Key
}

}