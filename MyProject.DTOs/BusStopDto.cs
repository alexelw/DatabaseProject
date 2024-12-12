using System.ComponentModel.DataAnnotations;

namespace MyProject.Data{
    public class BusStopDTO
{
    [Key] 
        public int BusStopID { get; set; } 
        [MaxLength(50)] 
        public required string BusStopName { get; set; }
        [Range(-90, 90)]
        public decimal CurrentLatitude { get; set; }

        [Range(-180, 180)]
        public decimal CurrentLongitude { get; set; }

        public int AreaID { get; set; }

        // Navigation Property: Many-to-One Relationship
        public required AreaDTO Area { get; set; }

        public ICollection<PopularityDTO> PopularityDTOs{ get; set; } =new List<PopularityDTO>();
        public ICollection<StopSequenceDTO> StopSequenceDTOs { get; set; } =new List<StopSequenceDTO>();
    }

}