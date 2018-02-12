using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._00.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleTypes VehicleType{ get; set; }

        [Required]
        [StringLength(7, MinimumLength = 6, ErrorMessage = "Registration number format ABC123")]
        public string RegistrationNumber { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Maximum lenght 20 characters")]
        public string Color { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Maximum lenght 20 characters")]
        public string Brand { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Maximum lenght 20 characters")]
        public string Model { get; set; }

        [Required]
        [Range(0, 20, ErrorMessage = "The count can't be less than zero")]
        public int NoOfWheels { get; set; }

        public DateTime TimestampIn { get; set; }
    }
}