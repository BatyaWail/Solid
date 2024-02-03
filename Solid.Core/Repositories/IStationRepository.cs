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
        Task<List<Station>> GetListAsync();
        Station GetById(int id);
        Task<Station> UpdateAsync(int id, Station station);
        Task<Station> AddAsync(Station station);
        Task RemoveAsync(int id);
    }
}
