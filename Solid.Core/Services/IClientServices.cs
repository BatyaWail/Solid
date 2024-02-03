using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IClientServices
    {
       Task< List<Client>> GetListItemsAsync();
        Client GetByIdItem(int id);
        Task<Client> UpdateItemAsync(int id, Client client);
        Task<Client> AddItemAsync(Client client);
        Task RemoveItemAsync(int id);
    }
}
