using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._00.Models
{
    public class ParkedVehicles
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public GarageContext() : base("name=GarageContext")
        {
        }

        public System.Data.Entity.DbSet<Garage.Models.Vehicle> Vehicles { get; set; }
    }

}