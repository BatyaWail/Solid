using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IProductServices
    {
        Task<List<Product>> GetListItemsAsync();
        Product GetByIdItem(int id);
        Task<Product> UpdateItemAsync(int id, Product product);
        Task<Product> AddItemAsync(Product product);
        Task RemoveItemAsync(int id);
    }
}
