//using Microsoft.AspNetCore.Mvc;
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
    public class ClientServices : IClientServices
    {
        private readonly IClientRepository _clientRepository;
        public ClientServices(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> AddItemAsync(Client client)
        {
           await _clientRepository.AddAsync(client);
            return client;
        }

        public Client GetByIdItem(int id)
        {
            return _clientRepository.GetById(id);
            //return OkObjectResult(_clientRepository.GetById(id));
        }

        public async Task<List<Client>> GetListItemsAsync()
        {
             return await _clientRepository.GetListAsync();//.ToList();
        }

        public async Task RemoveItemAsync(int id)
        {
           await _clientRepository.RemoveAsync(id);
        }

        public async Task<Client> UpdateItemAsync(int id, Client client)
        {
             await _clientRepository.UpdateAsync(id, client);
            return client;
        }
    }
}
