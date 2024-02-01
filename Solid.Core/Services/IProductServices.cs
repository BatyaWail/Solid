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
        List<Product> GetListItems();
        Product GetByIdItem(int id);
        Product UpdateItem(int id, Product product);
        Product AddItem(Product product);
        void RemoveItem(int id);
    }
}
