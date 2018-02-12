using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._00.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleTypes VehicleType{ get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NoOfWheels { get; set; }
    }
}