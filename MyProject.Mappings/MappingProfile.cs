using AutoMapper;
using MyProject.Data;
using MyProject.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Bus mappings
        CreateMap<Bus, BusDTO>().ReverseMap();
        
        // Route mappings
        CreateMap<Route, RouteDTO>().ReverseMap();
        
        // BusStop mappings
        CreateMap<BusStop, BusStopDTO>().ReverseMap();
        
        // StopSequence mappings
        CreateMap<StopSequence, StopSequenceDTO>().ReverseMap();
        
        // Road mappings
        CreateMap<Road, RoadDTO>().ReverseMap();
        
        // TrafficCondition mappings
        CreateMap<TrafficCondition, TrafficConditionDTO>().ReverseMap();
        
        // Roadwork mappings
        CreateMap<Roadwork, RoadworkDTO>().ReverseMap();
        
        // ScheduledJourney mappings
        CreateMap<ScheduledJourney, ScheduledJourneyDTO>().ReverseMap();
        
        // BusLocation mappings
        CreateMap<BusLocation, BusLocationDTO>().ReverseMap();
        
        // Popularity mappings
        CreateMap<Popularity, PopularityDTO>().ReverseMap();
        
        // Area mappings
        CreateMap<Area, AreaDTO>().ReverseMap();
    }
}
