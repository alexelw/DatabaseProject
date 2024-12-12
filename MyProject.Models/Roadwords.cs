using System.ComponentModel.DataAnnotations;

namespace MyProject.Models{
    public class Roadwork
{
    [Key] 
    public int RoadworkID { get; set; } 
    public int RoadID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? Description { get; set; }


    public Road? Roads { get; set; }
}
}