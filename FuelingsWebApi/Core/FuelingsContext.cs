using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using FuelingsWebApi.Models;
using System.Data.Entity;

namespace FuelingsWebApi.Core
{
    public class FuelingsContext : IdentityDbContext
    {
        public FuelingsContext() : base("FuelingsContext")
        {

        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Fueling> Fuelings { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
    }
}