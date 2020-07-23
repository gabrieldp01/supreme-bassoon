using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ControlTienda.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Sale
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; } // poniendo ? se le dice que puede ser nulo solo en fechas por ser complejo
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Amount { get; set; }
    }
}
