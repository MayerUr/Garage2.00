namespace Garage2._00.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2._00.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage2._00.DataAccessLayer.RegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Garage2._00.Vehicles.AddOrUpdate(
                unique => unique.LastName,
                new Models.Vehicle {}
                );

        }
    }
}
