using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class CashFlow
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IncomeAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal DischargeAmount { get; set; }
    }
}
