using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IClientRepository
    {
        List<Client> GetList();
        Client GetById(int id);
        Client Update(int id, Client client);
        Client Add(Client client);
        void Remove(int id);
    }
}
