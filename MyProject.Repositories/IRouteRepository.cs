using MyProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.Data.Repositories
{
    public interface IRouteRepository
    {
        Task<List<BusRoute>> GetRoutesAffectedByRoadworksAsync();
    }
}
