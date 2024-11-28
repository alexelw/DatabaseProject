namespace MyProject.Data{
    public class TrafficConditionDTO
{
    public int TrafficID { get; set; }
    public int RoadID { get; set; }
    public required string CurrentCondition { get; set; }
    public DateTime TimeStamp { get; set; }
    public int AreaID { get; set; }
}

}