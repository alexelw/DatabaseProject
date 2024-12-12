using System.ComponentModel.DataAnnotations;

namespace MyProject.Models{
    public class StopSequence
{
    [Key] 
    public int SequenceID { get; set; } // Primary Key
    public int RouteID { get; set; } // Foreign Key
    public int StopID { get; set; } // Foreign Key
    public int StopOrder { get; set; }


    public required BusRoute  busRoute{ get; set; } 
    public required BusStop busStop { get; set; }
}

}