using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlTienda.Data.Entities
{
    using System.Collections;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class Category
    {
        public int Id { get; set; }

        [MaxLength (35)]
        public string Name { get; set; }
        [MaxLength (250)]
        public string Description { get; set; }

    }
}
