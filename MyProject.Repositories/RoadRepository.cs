using Microsoft.EntityFrameworkCore;
using MyProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.Repositories
{
public class RoadRepository : IRoadRepository
{
    private readonly AppDbContext _context;

    public RoadRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Road>> GetRoadsToAvoidAsync()
    {
        string sqlQuery = @"
        SELECT
            r.RoadID,
            r.RoadName,
            tc.CurrentCondition,
            rw.StartDate,
            rw.EndDate,
            rw.Description,
            COUNT(tc.TrafficID) AS TrafficConditionCount,
            COUNT(rw.RoadworkID) AS RoadworkCount
        FROM
            Roads r
        LEFT JOIN
            TrafficConditions tc ON r.RoadID = tc.RoadID
        LEFT JOIN
            Roadworks rw ON r.RoadID = rw.RoadID
        WHERE
            (tc.CurrentCondition = 'Heavy' OR tc.CurrentCondition = 'Severe')
            OR (rw.StartDate <= GETDATE() AND rw.EndDate >= GETDATE())
        GROUP BY
            r.RoadID, r.RoadName, tc.CurrentCondition, rw.StartDate, rw.EndDate, rw.Description
        HAVING
            COUNT(tc.TrafficID) > 0 OR COUNT(rw.RoadworkID) > 0
        ORDER BY
            TrafficConditionCount DESC, RoadworkCount DESC;
        ";

        var roadsToAvoid = await _context.Roads
                                        .FromSqlRaw(sqlQuery)
                                        .ToListAsync();

        return roadsToAvoid;
    }
    
}
}