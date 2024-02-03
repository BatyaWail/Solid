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

        public async Task<Product> AddAsync(Product product)
        {
            _dataContext.products.Add(product);
            await _dataContext.SaveChangesAsync();
            return product;
        }

        public Product GetById(int id)
        {
            return _dataContext.products.ToList().Find(x => x.Id == id);

        }

        public async Task<List<Product>> GetListAsync()
        {
            return await _dataContext.products.Include(p => p.Station).ToListAsync();
        }

        public async Task RemoveAsync(int id)
        {
            _dataContext.products.Remove(_dataContext.products.ToList().Find(x => x.Id == id));
           await _dataContext.SaveChangesAsync();
        }

        public async Task<Product> UpdateAsync(int id, Product product)
        {
            int x = _dataContext.products.ToList().FindIndex(x => x.Id == id);
            _dataContext.products.ToList()[x] = product;
           await _dataContext.SaveChangesAsync();
            return product;
        }
    }
}
