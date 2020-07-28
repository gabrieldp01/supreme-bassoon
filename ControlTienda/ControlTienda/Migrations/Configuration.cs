namespace ControlTienda.Migrations
{
    using Data;
    using ControlTienda.Data.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext context)
        {
            context.Rols.Add(new Rol() { Name = "Admin", Details = "Mian Admin of the System with full permissions. "});
            //Rol rol = new Rol() { Name = "Admin", Details = "lala" };
            //context.Rols.Add(rol);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
