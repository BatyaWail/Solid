using Microsoft.AspNetCore.Mvc;
using Solid.Core.Models;
using Solid.Core.Services;
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

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok( _productServices.GetListItems());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok( _productServices.GetByIdItem(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] ProductPostModel value)
        {
            Product productToAdd = new Product()
            { Name = value.Name, StationId = value.StationId, Price = value.Price, Category = value.Category };
            return Ok( _productServices.AddItem(productToAdd));
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ProductPostModel value)
        {
            Product productToUpdate = new Product()
            { Name = value.Name, StationId = value.StationId, Price = value.Price, Category = value.Category };
            return Ok( _productServices.UpdateItem(id,productToUpdate));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _productServices.RemoveItem(id);
            return Ok();
        }
    }
}
