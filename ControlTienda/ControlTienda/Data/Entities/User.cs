using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength (100)]
        public string Address { get; set; }
        [MaxLength (25)]
        public string Phone { get; set; }
        [ConcurrencyCheck, MinLength (6, ErrorMessage ="At less you need 6 characters.") , MaxLength (8, ErrorMessage = "You just need 8 characters.")]
        public string Nick { get; set; }
        [ConcurrencyCheck, MinLength (8 , ErrorMessage ="At less you need 8 characters.") , MaxLength (15, ErrorMessage = "You just need 15 characters.")]
        public string Password { get; set; }


        public Rol Rol { get; set; }
    } 
}
