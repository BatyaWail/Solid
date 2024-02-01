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
        List<Station> GetListItems();
        Station GetByIdItem(int id);
        Station UpdateItem(int id, Station station);
        Station AddItem(Station station);
        void RemoveItem(int id);
    }
}
