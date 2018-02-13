using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Data.Entity;

namespace Garage2._00.DataAccessLayer
{
    public class RegisterContext : DbContext
    {
        public RegisterContext() : base("Garage2.0")
        {
        }

        public DbSet<Models.Vehicle> Vehicles { get; set; }

        // public System.Data.Entity.DbSet<Garage2._00.Models.Kvitto> Kvittoes { get; set; }
    }
}