
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Solid.Core.Models;
using Solid.Core.Services;
using try1solid_webApi.Models;

namespace Solid.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly IStationServices _stationServices;

        public StationController(IStationServices stationServices)
        {
            _stationServices = stationServices;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok( _stationServices.GetListItems());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok( _stationServices.GetByIdItem(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] StationPostModel value)
        {
            Station stationToAdd = new Station() { Address = value.Address, Day = value.Day, CountFamily = value.CountFamily };
           return Ok( _stationServices.AddItem(stationToAdd));
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] StationPostModel value)
        {
            Station stationToUpdate = new Station() { Address = value.Address, Day = value.Day, CountFamily = value.CountFamily };

            return Ok( _stationServices.UpdateItem(id,stationToUpdate));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _stationServices.RemoveItem(id);
            return Ok();
        }
    }
}
