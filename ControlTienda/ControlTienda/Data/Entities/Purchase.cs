using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public string  DateTime { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
    }
}
