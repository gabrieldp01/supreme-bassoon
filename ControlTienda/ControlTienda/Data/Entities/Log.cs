using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Log
    {
        public int Id { get; set; }
        public DateTime? Entry_DateTime { get; set; }
        public DateTime? Departure_DateTime { get; set; }

        [MaxLength (250)]
        public string Remark { get; set; }

    }
}
