using System.ComponentModel.DataAnnotations;
using MyProject.Enums;

namespace MyProject.Data{
    public class TrafficConditionDTO
{
    [Key] 
    public int TrafficID { get; set; }
    public int RoadID { get; set; }
    public  CurrentCondition CurrentCondition { get; set; }
    public DateTime TimeStamp { get; set; }

    public required RoadDTO roadDTO{ get; set; } 
}
}