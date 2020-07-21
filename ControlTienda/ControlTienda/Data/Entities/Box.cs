using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class Box
    {
        public int Id { get; set; }
        public decimal StartingAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Date { get; set; }
        public string Observation { get; set; }
    }
}
