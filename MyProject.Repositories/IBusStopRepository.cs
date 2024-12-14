using MyProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.Data.Repositories
{
    public interface IBusStopRepository
    {
        Task<List<BusStop>> GetBestBusStopsAsync();
    }
}
