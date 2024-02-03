using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetListAsync();
        Product GetById(int id);
        Task<Product> UpdateAsync(int id, Product product);
        Task<Product> AddAsync(Product product);
        Task RemoveAsync(int id);
    }
}
