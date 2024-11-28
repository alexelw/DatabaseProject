using System.ComponentModel.DataAnnotations;
using MyProject.Models;

namespace MyProject.Models
{
public class Area
{
    public int AreaID { get; set; } // Primary Key
    
    [Required]
    [MaxLength(50)] // Restrict AreaName to 50 characters in the database
    public required string AreaName { get; set; }

    [Range(0, int.MaxValue)] // Ensure Population is positive
    public int Population { get; set; }


    // One-to-Many Relationship: Area -> BusStops
    public ICollection<BusStop> BusStops { get; set; } =new List<BusStop>();
}
}
