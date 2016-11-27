using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FuelingsWebApi.Core
{
    public class Initializer : MigrateDatabaseToLatestVersion<FuelingsContext, Configuration>
    {
    }
}