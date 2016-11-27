using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using FuelingsWebApi.Core;
using System.Security.Claims;
using Microsoft.AspNet.Identity;

namespace FuelingsWebApi.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class VehiclesController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            using (var context = new FuelingsContext())
            {
                var userId = User.Identity.GetUserId();
                return Ok(await context.Vehicles.Include(x => x.Fuelings).Include("Fuelings.Fuel").Where(x => x.UserId == userId).ToListAsync());
            }
        }
    }
}