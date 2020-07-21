using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public string Entry_DateTime { get; set; }
        public string Departure_DateTime { get; set; }
        public string Observations { get; set; }

    }
}
