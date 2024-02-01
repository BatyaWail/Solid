//using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solid.Data
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _dataContext;
        public ClientRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Client Add(Client client)
        {
            _dataContext.clients.Add(client);
            _dataContext.SaveChanges();
            return client;
        }

        public Client GetById(int id)
        {
           return _dataContext.clients.ToList().Find(x => x.Id == id);
        }
        public List<Client> GetList()
        {
            return _dataContext.clients.Include(u => u.Station).ToList();
        }

        public void Remove(int id)
        {
            _dataContext.clients.Remove(_dataContext.clients.ToList().Find(x => x.Id == id));
            _dataContext.SaveChanges();
        }

        public Client Update(int id, Client client)
        {
            int x = _dataContext.clients.ToList().FindIndex(x => x.Id == id);
            _dataContext.clients.ToList()[x] = client;
            _dataContext.SaveChanges();
            return client;
        }
    }
}
