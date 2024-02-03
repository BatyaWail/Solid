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
    public class ProductService : IProductServices
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Product> AddItemAsync(Product product)
        {
            await _productRepository.AddAsync(product);
            return product;
        }

        public Product GetByIdItem(int id)
        {
            return _productRepository.GetById(id);
        }

        public async Task<List<Product>> GetListItemsAsync()
        {
            return await _productRepository.GetListAsync();
        }

        public async Task RemoveItemAsync(int id)
        {
            await _productRepository.RemoveAsync(id);
        }

        public async Task<Product> UpdateItemAsync(int id, Product product)
        {
           await _productRepository.UpdateAsync(id, product);
            return product;

        }
    }
}
