//using AutoMapper;
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
        //private readonly IMapper _mapper;

        public ClientController(IClientServices clientServices/*,IMapper mapper*/)
        {
            _clientServices = clientServices;
            //_mapper = mapper;
        }

        // GET: api/<ProductController>
        [HttpGet]
        //public ActionResult<IEnumerator<ClientDto>> Get()
        //{
        //    var clients = _clientServices.GetListItems();
        //    var clientsDto = _mapper.Map<IEnumerator<ClientDto>>(clients);
        //    return Ok(clientsDto);
        //}
        public ActionResult Get()
        {
            var clients = _clientServices.GetListItems();
            return Ok(clients);
        }

        // GET api/<ProductController>/5
        //[HttpGet("{id}")]
        //public ActionResult Get(int id)
        //{
        //    var client = _clientServices.GetByIdItem(id);
        //    var clientDto = _mapper.Map<ClientDto>(client);
        //    return Ok(clientDto);
        //}
        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var client = _clientServices.GetByIdItem(id);
            return Ok(client);
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] ClientPostModel value)
        {
            Client clientToAdd = new Client() { Name = value.Name, Address = value.Address, Pone = value.Pone, StationId = value.StationId };
            return Ok( _clientServices.AddItem(clientToAdd));
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ClientPostModel value)
        {
            Client clientToUpdate = new Client() { Name = value.Name, Address = value.Address, Pone = value.Pone, StationId = value.StationId };

            return Ok( _clientServices.UpdateItem(id, clientToUpdate));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _clientServices.RemoveItem(id);
            return Ok();
        }
    }
}
