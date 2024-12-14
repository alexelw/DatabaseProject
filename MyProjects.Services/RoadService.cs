using AutoMapper;
using MyProject.Data;
using MyProject.Data.Repositories;
using MyProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class RoadService
    {
        private readonly IRoadRepository _roadRepository;
        private readonly IMapper _mapper;

        public RoadService(IRoadRepository roadRepository, IMapper mapper)
        {
            _roadRepository = roadRepository;
            _mapper = mapper;
        }

        public async Task<List<RoadDTO>> GetRoadsToAvoidAsync()
        {
            var roads = await _roadRepository.GetRoadsToAvoidAsync();
            return _mapper.Map<List<RoadDTO>>(roads);
        }
    }
}
