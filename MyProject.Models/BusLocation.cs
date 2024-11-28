using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyProject.Enums;

namespace MyProject.Models{
    public class BusLocation
{
    public int BusID { get; set; }
    public int CurrentRouteID { get; set; }
    public int CurrentRoadID { get; set; }
    [Range(0, int.MaxValue)]
    public int CurrentCapacity { get; set; }

    [Range(-90, 90)]
    [Column(TypeName = "decimal(9,6)")]
    public decimal CurrentLatitude { get; set; }

    [Range(-180, 180)]
    [Column(TypeName = "decimal(9,6)")]
    public decimal CurrentLongitude { get; set; }
    public BusStatus Status { get; set; }


        // One-to-One Relationship: Area -> BusStops
        public Bus? Bus { get; set; }
        public BusRoute? CurrentRoute { get; set; }
        public Road? CurrentRoad { get; set; }
}
}