using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPA1.Shared.Models;
using SPA1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA1.Server.Repositories
{
    public class MovieRepository : Controller
    {
        private FLETNIX_DOCENTContext fletnixContext = new FLETNIX_DOCENTContext();

        public async Task<List<Movie>> MovieFilter(QueryFilters filters)
        {
            //.Skip(loadNumber * numLoaded).Take(loadNumber).ToListAsync();
            var query = fletnixContext.Movie.AsNoTracking().AsQueryable();
            if(filters.Watched == 1) query = query.Where(feature => feature.Watched == filters.Watched);
            query = query.Take(filters.Shown);
            return await query.ToListAsync();
        }
    }
}
