namespace Garage2._00.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Garage2._00.DataAccessLayer;

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

            context.Vehicles.AddOrUpdate(
                unique => unique.RegistrationNumber,
                new Models.Vehicle { VehicleType = VehicleTypes.Car, RegistrationNumber = "KNN903", Brand = "Volvo", Model = "245", Color = "Vinröd", NoOfWheels = 4 },
                new Models.Vehicle { VehicleType = VehicleTypes.Car, RegistrationNumber = "CRL440", Brand = "Rover", Model = "400", Color = "Metallröd", NoOfWheels = 4 },
                new Models.Vehicle { VehicleType = VehicleTypes.Car, RegistrationNumber = "SFC253", Brand = "Rover", Model = "75", Color = "Silver", NoOfWheels = 4 }
                );
        }
    }
}