using System.ComponentModel.DataAnnotations;

namespace MyProject.Models{
    public class Road
{
    public int RoadID { get; set; } 
    [Required]
    [MaxLength(50)] 
    public string RoadName { get; set; }


    public ICollection<TrafficCondition> TrafficConditions { get; set; } =new List<TrafficCondition>();
    public ICollection<Roadwork> Roadworks { get; set; } =new List<Roadwork>();

}

}