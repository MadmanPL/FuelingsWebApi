using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuelingsWebApi.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RegistrationNumber { get; set; }
        public string VehicleIdentificationNumber { get; set; }
        public virtual List<Fueling> Fuelings { get; set; }
    }
}