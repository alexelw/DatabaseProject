namespace MyProject.Data{
    public class RoadworkDTO
{
    public int RoadworkID { get; set; } 
    public int RoadID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? Description { get; set; }


    public RoadDTO? RoadDTOs { get; set; }
}

}