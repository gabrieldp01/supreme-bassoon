using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public int Id { get; set; }
        [MaxLength(25)] // 1654898798
        public string BarCode { get; set; }
        [MaxLength(150)] // mantequilla gloria premium de 200gr.
        public string Name { get; set; }
        [DisplayFormat (DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock {get; set; }


        public Category Category { get; set; }
    }
}
