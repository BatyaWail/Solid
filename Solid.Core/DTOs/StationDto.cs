using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class StationDto
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int CountFamily { get; set; }
        public DayOfWeek Day { get; set; }
    }
}
