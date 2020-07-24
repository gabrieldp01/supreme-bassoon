using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTienda.Data
{
    using System.Data.Entity;
    using System.Runtime.InteropServices;
    using Entities;
    public class DataContext : DbContext
    {
        public DataContext() : base ("name=conection")
        {
        }

        public DbSet<Box> Cashes { get; set; }
        public DbSet<CashFlow> CashFlows { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Devolution> Devolutions { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rol> Rols { get; set; }






    }
}
