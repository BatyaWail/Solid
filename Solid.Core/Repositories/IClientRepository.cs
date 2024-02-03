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
        Task<List<Client>> GetListAsync();
        Client GetById(int id);
        Task<Client> UpdateAsync(int id, Client client);
        Task<Client> AddAsync(Client client);
        Task RemoveAsync(int id);
    }
}
