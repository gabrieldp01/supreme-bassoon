using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class PurchaseDetail
    {
        public int Id { get; set; }
        public string DateTime { get; set; }
        public int Quantity { get; set; }
        public decimal UnitAmount { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
