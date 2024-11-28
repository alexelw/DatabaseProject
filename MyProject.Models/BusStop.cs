using System.ComponentModel.DataAnnotations;

namespace MyProject.Models{

    public class BusStop
    {
        public int BusStopID { get; set; } 
        [Required]
        [MaxLength(50)] 
        public required string BusStopName { get; set; }
        public int AreaID { get; set; }

        [Range(-90, 90)]
        public decimal CurrentLatitude { get; set; }

        [Range(-180, 180)]
        public decimal CurrentLongitude { get; set; }


        public required Area Area { get; set; }
        public ICollection<Popularity>  Popularity { get; set; } =new List<Popularity>();
        public ICollection<StopSequence> StopSequences { get; set; } =new List<StopSequence>();
    }
}
