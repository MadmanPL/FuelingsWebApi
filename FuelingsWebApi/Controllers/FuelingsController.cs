using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using FuelingsWebApi.Core;
using FuelingsWebApi.Models;
using FuelingsWebApi.ViewModels;

namespace FuelingsWebApi.Controllers
{
    public class FuelingsController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] FuelingViewModel fueling)
        {
            using (var context = new FuelingsContext())
            {
                var vehicle = await context.Vehicles.FirstOrDefaultAsync(b => b.Id == fueling.VehicleId);
                if (vehicle == null)
                {
                    return NotFound();
                }

                var newFueling = context.Fuelings.Add(new Fueling
                {
                    VehicleId = vehicle.Id,
                    Date = fueling.Date,
                    Fuel = fueling.Fuel,
                    Mileage = fueling.Mileage,
                    Price = fueling.Price,
                    Quantity = fueling.Quantity
                });

                await context.SaveChangesAsync();
                return Ok(new FuelingViewModel(newFueling));
            }
        }

        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            using (var context = new FuelingsContext())
            {
                var fueling = await context.Fuelings.FirstOrDefaultAsync(r => r.Id == id);
                if (fueling == null)
                {
                    return NotFound();
                }

                context.Fuelings.Remove(fueling);
                await context.SaveChangesAsync();
            }
            return Ok();
        }
    }
}