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

        public Station Add(Station station)
        {
            _dataContext.stations.Add(station);
            _dataContext.SaveChanges();
            return station;
        }

        public Station GetById(int id)
        {
            return _dataContext.stations.ToList().Find(x => x.Id == id);

        }

        public List<Station> GetList()
        {
            return _dataContext.stations.Include(s => s.Clients)
                //.Include(s => s.Products)
                .ToList();
        }

        public void Remove(int id)
        {
            _dataContext.stations.Remove(_dataContext.stations.ToList().Find(x => x.Id == id));
            _dataContext.SaveChanges();
        }

        public Station Update(int id, Station station)
        {
            int x = _dataContext.stations.ToList().FindIndex(x => x.Id == id);
            _dataContext.stations.ToList()[x] = station;
            _dataContext.SaveChanges();
            return station;
        }
    }
}
