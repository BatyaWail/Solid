//using AutoMapper;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
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
    public class ClientController : ControllerBase
    {
        private readonly IClientServices _clientServices;
        private readonly IMapper _mapper;

        public ClientController(IClientServices clientServices, IMapper mapper)
        {
            _clientServices = clientServices;
            _mapper = mapper;
        }

        // GET: api/<ProductController>
        //[HttpGet]
        //public async Task<ActionResult> GetAsync()//למה לא טוב?????????.
        //{
        //     var clients = await _clientServices.GetListItemsAsync();
        //    var clientsDto = _mapper.Map<IEnumerator<ClientDto>>(clients);
        //    return Ok(clientsDto);

        //}
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var clients = await _clientServices.GetListItemsAsync();
            var clientsDto = _mapper.Map<List<ClientDto>>(clients);
            return Ok(clientsDto);
        }


        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var client = _clientServices.GetByIdItem(id);
            var clientDto = _mapper.Map<ClientDto>(client);
            return Ok(clientDto);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] ClientPostModel value)
        {
            Client clientToAdd = new Client() { Name = value.Name, Address = value.Address, Pone = value.Pone, StationId = value.StationId };
            var client= await _clientServices.AddItemAsync(clientToAdd);
            return Ok(client);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] ClientPostModel value)
        {
            Client clientToUpdate = new Client() { Name = value.Name, Address = value.Address, Pone = value.Pone, StationId = value.StationId };
            //var client = await _clientServices.UpdateItemAsync(id, clientToUpdate);
            return  Ok(await _clientServices.UpdateItemAsync(id, clientToUpdate));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _clientServices.RemoveItemAsync(id);
            return Ok();
        }
    }
}
