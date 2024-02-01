using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;
using Solid.Core.Repositories;

namespace Solid.Data
{
    public class ProductRepository:IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Product Add(Product product)
        {
            _dataContext.products.Add(product);
            _dataContext.SaveChanges();
            return product;
        }

        public Product GetById(int id)
        {
            return _dataContext.products.ToList().Find(x => x.Id == id);

        }

        public List<Product> GetList()
        {
            return _dataContext.products.Include(p => p.Station).ToList();
        }

        public void Remove(int id)
        {
            _dataContext.products.Remove(_dataContext.products.ToList().Find(x => x.Id == id));
            _dataContext.SaveChanges();
        }

        public Product Update(int id, Product product)
        {
            int x = _dataContext.products.ToList().FindIndex(x => x.Id == id);
            _dataContext.products.ToList()[x] = product;
            _dataContext.SaveChanges();
            return product;
        }
    }
}
