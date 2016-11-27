using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuelingsWebApi.Models
{
    public class Fueling
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }
        public int VehicleId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? Mileage { get; set; }
    }
}