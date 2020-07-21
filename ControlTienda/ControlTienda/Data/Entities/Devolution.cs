using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Devolution
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Observation { get; set; }
        public string ID_DetailSale { get; set; }

    }
}
