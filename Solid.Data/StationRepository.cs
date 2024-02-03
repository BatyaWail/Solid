using Microsoft.EntityFrameworkCore;

using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Solid.Data
{
    public class StationRepository: IStationRepository
    {
        private readonly DataContext _dataContext;
        public StationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Station> AddAsync(Station station)
        {
            _dataContext.stations.Add(station);
            await _dataContext.SaveChangesAsync();
            return station;
        }

        public Station GetById(int id)
        {
            return _dataContext.stations.ToList().Find(x => x.Id == id);

        }

        public async Task<List<Station>> GetListAsync()
        {
            return await _dataContext.stations.Include(s => s.Clients)
                //.Include(s => s.Products)
                .ToListAsync();
        }

        public async Task RemoveAsync(int id)
        {
            _dataContext.stations.Remove(_dataContext.stations.ToList().Find(x => x.Id == id));
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Station> UpdateAsync(int id, Station station)
        {
            int x = _dataContext.stations.ToList().FindIndex(x => x.Id == id);
            _dataContext.stations.ToList()[x] = station;
            await _dataContext.SaveChangesAsync();
            return station;
        }
    }
}
