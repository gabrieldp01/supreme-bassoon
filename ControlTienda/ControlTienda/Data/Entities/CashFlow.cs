using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data.Entities
{
    public class CashFlow
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public decimal IncomeAmount { get; set; }
        public decimal DischargeAmount { get; set; }
    }
}
