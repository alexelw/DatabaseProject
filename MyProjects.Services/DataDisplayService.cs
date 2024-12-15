using Microsoft.EntityFrameworkCore;
using MyProject.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

public class DataDisplayService
{
    private readonly AppDbContext _context;

    public DataDisplayService(AppDbContext context)
    {
        _context = context;
    }

public async Task<Dictionary<string, object>> GetAllDatabaseDataAsync()
{
    return new Dictionary<string, object>
    {
        { "Areas", await _context.Areas.ToListAsync() },
        { "Buses", await _context.Buses.ToListAsync() },
        { "BusLocations", await _context.BusLocations.ToListAsync() },
        { "Routes", await _context.Routes.ToListAsync() },
        { "Stops", await _context.BusStops.ToListAsync() },
        { "StopSequences", await _context.StopSequences.ToListAsync() },
        { "Roads", await _context.Roads.ToListAsync() },
        { "TrafficConditions", await _context.TrafficConditions.ToListAsync() },
        { "Roadworks", await _context.Roadworks.ToListAsync() },
        { "ScheduledJourneys", await _context.ScheduledJourneys.ToListAsync() },
        { "Popularities", await _context.Popularities.ToListAsync() }
    };
}

}
