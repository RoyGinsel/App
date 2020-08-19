using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPA1.Shared
{
    public class QueryFilters
    {
        [FromQuery(Name = "Watched")]
        public int Watched{ get; set; }

        [FromQuery(Name = "Shown")]
        public int Shown { get; set; } = 10;
    }
}
