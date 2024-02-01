using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IStationRepository
    {
        List<Station> GetList();
        Station GetById(int id);
        Station Update(int id, Station station);
        Station Add(Station station);
        void Remove(int id);
    }
}
