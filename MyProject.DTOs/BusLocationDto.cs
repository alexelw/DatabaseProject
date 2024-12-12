using System.ComponentModel.DataAnnotations;
using MyProject.Enums;

namespace MyProject.Data{
    public class BusLocationDTO
{
        [Key] // Mark journeyID as the primary key
        public int journeyID { get; set; }
        public int BusID { get; set; }
        public int CurrentRouteID { get; set; }
        public int CurrentRoadID { get; set; }

        [Range(0, int.MaxValue)]
        public int CurrentCapacity { get; set; }

        [Range(-90, 90)]
        public decimal CurrentLatitude { get; set; }

        [Range(-180, 180)]
        public decimal CurrentLongitude { get; set; }
        
        public BusStatus Status { get; set; }

        // One-to-One Relationship: Area -> BusStops
        public BusDTO? BusDTO { get; set; }
        public BusRouteDTO? CurrentRouteDTO { get; set; }
        public RoadDTO? CurrentRoadDTO { get; set; }
    }
}