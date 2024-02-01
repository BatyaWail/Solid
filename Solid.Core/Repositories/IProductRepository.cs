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
        List<Product> GetList();
        Product GetById(int id);
        Product Update(int id, Product product);
        Product Add(Product product);
        void Remove(int id);
    }
}
