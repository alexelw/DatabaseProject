using AutoMapper;
using MyProject.Data;
using MyProject.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class BusStopService
    {
        private readonly IBusStopRepository _repository;
        private readonly IMapper _mapper;

        public BusStopService(IBusStopRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<BusStopDTO>> GetBestBusStopsAsync()
        {
            var busStops = await _repository.GetBestBusStopsAsync();
            return _mapper.Map<List<BusStopDTO>>(busStops);
        }
    }
}
