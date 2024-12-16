using Microsoft.EntityFrameworkCore;
using MyProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.Repositories
{
    public class BusStopRepository : IBusStopRepository
    {
        private readonly AppDbContext _context;

        public BusStopRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<BusStop>> GetBestBusStopsAsync()
        {
            string sqlQuery = @"
            SELECT
                bs.BusStopID,
                bs.BusStopName,
                a.AreaName,
                a.Population,
                SUM(p.PopularityScore) AS TotalPopularityScore,
                COUNT(br.RouteID) AS RoutesCount,
                (a.Population * 0.5 + SUM(p.PopularityScore) * 0.3 + COUNT(br.RouteID) * 0.2) AS WeightedScore
            FROM
                BusStops bs
            JOIN
                Areas a ON bs.AreaID = a.AreaID
            JOIN
                Popularities p ON bs.BusStopID = p.StopID
            JOIN
                BusRoutes br ON bs.BusStopID = br.BusStopID
            GROUP BY
                bs.BusStopID, bs.BusStopName, a.AreaName, a.Population
            ORDER BY
                WeightedScore DESC
            LIMIT 10;
            ";

            // Execute the query and map results to BusStop model
            var busStops = await _context.BusStops
                                        .FromSqlRaw(sqlQuery)
                                        .ToListAsync();

            return busStops;
        }
    }
}
