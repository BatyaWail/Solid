using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IStationServices
    {
        Task<List<Station>> GetListItemsAsync();
        Station GetByIdItem(int id);
        Task<Station> UpdateItemAsync(int id, Station station);
        Task<Station> AddItemAsync(Station station);
        Task RemoveItemAsync(int id);
    }
}
