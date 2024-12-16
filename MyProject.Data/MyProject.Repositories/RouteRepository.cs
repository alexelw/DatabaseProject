using Microsoft.EntityFrameworkCore;
using MyProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.Repositories
{
    public class RouteRepository : IRouteRepository 
    {
        private readonly AppDbContext _context;

        public RouteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<BusRoute>> GetRoutesAffectedByRoadworksAsync()
        {
            string sqlQuery = @"
                SELECT DISTINCT r.RouteID, r.RouteName
                FROM BusRoutes r
                JOIN StopSequences ss ON r.RouteID = ss.RouteID
                JOIN BusStops bs ON ss.StopID = bs.StopID
                JOIN Roadworks rw ON bs.RoadID = rw.RoadID
                WHERE rw.StartDate <= GETDATE() AND rw.EndDate >= GETDATE()
                ORDER BY r.RouteName;
            ";

            // Return the result as a List of BusRoute, which matches your model.
            var routes = await _context.Routes
                                        .FromSqlRaw(sqlQuery)
                                        .ToListAsync();

            return routes;
        }
    }
}
