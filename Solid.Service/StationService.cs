using Solid.Core.Models;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class StationService : IStationServices
    {
        private readonly IStationRepository _stationRepository;
        public StationService(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }
        public async Task<Station> AddItemAsync(Station station)
        {
           await _stationRepository.AddAsync(station);
            return station;
        }

        public Station GetByIdItem(int id)
        {
            return _stationRepository.GetById(id);
        }

        public async Task<List<Station>> GetListItemsAsync()
        {
            return await _stationRepository.GetListAsync();
        }

        public async Task RemoveItemAsync(int id)
        {
            await _stationRepository.RemoveAsync(id);
        }

        public async Task<Station> UpdateItemAsync(int id, Station station)
        {
           await _stationRepository.UpdateAsync(id, station);
            return station;
        }
    }
}
