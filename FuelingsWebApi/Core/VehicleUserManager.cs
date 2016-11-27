using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuelingsWebApi.Core
{
    public class VehicleUserManager : UserManager<IdentityUser>
    {
        public VehicleUserManager() : base(new VehicleUserStore())
        {
        }
    }
}