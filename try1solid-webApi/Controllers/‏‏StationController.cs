
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using Solid.Core.Models;
using Solid.Core.Services;
using Solid.Service;
using try1solid_webApi.Models;

namespace Solid.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly IStationServices _stationServices;
        private readonly IMapper _mapper;

        public StationController(IStationServices stationServices,IMapper mapper)
        {
            _stationServices = stationServices;
            _mapper = mapper;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var stations =await _stationServices.GetListItemsAsync();
            var stationsDto = _mapper.Map<IEnumerator<ProductDto>>(stations);
            return Ok(stationsDto);
            //return Ok( _stationServices.GetListItems());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var station = _stationServices.GetByIdItem(id);
            var stationDto = _mapper.Map<ClientDto>(station);
            return Ok(stationDto);
            //return Ok( _stationServices.GetByIdItem(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] StationPostModel value)
        {
            Station stationToAdd = new Station() { Address = value.Address, Day = value.Day, CountFamily = value.CountFamily };
           return Ok( await _stationServices.AddItemAsync(stationToAdd));
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] StationPostModel value)
        {
            Station stationToUpdate = new Station() { Address = value.Address, Day = value.Day, CountFamily = value.CountFamily };

            return Ok( await _stationServices.UpdateItemAsync(id,stationToUpdate));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
           await _stationServices.RemoveItemAsync(id);
            return Ok();
        }
    }
}
