using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Models;
using Solid.Core.Services;
using Solid.Service;
using try1solid_webApi.Models;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;
        private readonly IMapper _mapper;


        public ProductController(IProductServices productServices,IMapper mapper)
        {
            _productServices = productServices;
            _mapper = mapper;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
             var products = await _productServices.GetListItemsAsync();
            var productsDto = _mapper.Map<IEnumerator<ProductDto>>(products);
            return Ok(productsDto);
            //return Ok( _productServices.GetListItems());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var product = _productServices.GetByIdItem(id);
            var productDto = _mapper.Map<ProductDto>(product);
            return Ok(productDto);
            //return Ok( _productServices.GetByIdItem(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] ProductPostModel value)
        {
            Product productToAdd = new Product()
            { Name = value.Name, StationId = value.StationId, Price = value.Price, Category = value.Category };
            return Ok(await _productServices.AddItemAsync(productToAdd));
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] ProductPostModel value)
        {
            Product productToUpdate = new Product()
            { Name = value.Name, StationId = value.StationId, Price = value.Price, Category = value.Category };
            return Ok(await _productServices.UpdateItemAsync(id,productToUpdate));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
           await _productServices.RemoveItemAsync(id);
            return Ok();
        }
    }
}
