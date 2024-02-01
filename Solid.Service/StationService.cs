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
        public Station AddItem(Station station)
        {
            _stationRepository.Add(station);
            return station;
        }

        public Station GetByIdItem(int id)
        {
            return _stationRepository.GetById(id);
        }

        public List<Station> GetListItems()
        {
            return _stationRepository.GetList().ToList();
        }

        public void RemoveItem(int id)
        {
            _stationRepository.Remove(id);
        }

        public Station UpdateItem(int id, Station station)
        {
            _stationRepository.Update(id, station);
            return station;
        }
    }
}
