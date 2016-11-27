using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuelingsWebApi.Core
{
    public class VehicleUserStore : UserStore<IdentityUser>
    {
        public VehicleUserStore() : base(new FuelingsContext())
        {
        }
    }
}