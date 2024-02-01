using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pone { get; set; }
        public string Address { get; set; }
        public int StationId { get; set; }
        public StationDto Station { get; set; }
    }
}
