using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControlTienda.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class PurchaseDetail
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public int Quantity { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal UnitAmount { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalAmount { get; set; }


        public Product Product { get; set; }
        public Purchase Purchase { get; set; }


    }
}
