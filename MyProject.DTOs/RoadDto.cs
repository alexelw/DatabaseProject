using System.ComponentModel.DataAnnotations;

namespace MyProject.Data{
    public class RoadDTO
{
    [Key] 
    public int RoadID { get; set; } 
    [Required]
    [MaxLength(50)] 
    public string RoadName { get; set; }

    public ICollection<TrafficConditionDTO> TrafficConditionDTOs { get; set; } =new List<TrafficConditionDTO>();
    public ICollection<RoadworkDTO> RoadworkDTOs { get; set; } =new List<RoadworkDTO>();

}
}