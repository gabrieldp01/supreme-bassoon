using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public string DateTime { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
