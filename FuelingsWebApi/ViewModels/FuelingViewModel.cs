using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuelingsWebApi.Models;

namespace FuelingsWebApi.ViewModels
{
    public class FuelingViewModel
    {
        public FuelingViewModel()
        {
        }

        public FuelingViewModel(Fueling fueling)
        {
            if (fueling == null)
            {
                return;
            }

            Date = fueling.Date;
            Fuel = fueling.Fuel;
            Mileage = fueling.Mileage;
            Price = fueling.Price;
            Quantity = fueling.Quantity;
            VehicleId = fueling.VehicleId;
        }

        public DateTime Date { get; set; }
        public Fuel Fuel { get; set; }
        public int VehicleId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? Mileage { get; set; }

        public Fueling ToFueling()
        {
            return new Fueling
            {
                Date = Date,
                Fuel = Fuel,
                VehicleId = VehicleId,
                Quantity = Quantity,
                Price = Price,
                Mileage = Mileage
            };
        }
    }
}