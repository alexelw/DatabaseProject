using MyProject.Data.Repositories;
using MyProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class RouteService
    {
        private readonly IRouteRepository _routeRepository;

        public RouteService(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }

        public async Task<List<BusRoute>> GetRoutesAffectedByRoadworksAsync()
        {
            return await _routeRepository.GetRoutesAffectedByRoadworksAsync();
        }
    }
}
