using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPA1.Server.Repositories;
using SPA1.Shared;

namespace SPA1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private readonly MovieRepository movieRepository;

        public MovieController(MovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;

        }

        [HttpGet]
        [Route("filter")]
        public async Task<IActionResult> FilterAsync([FromQuery] QueryFilters filters)
        {
            try
            {
                var filteredMovies = await movieRepository.MovieFilter(filters);
                return Ok(filteredMovies);
            }
            catch (Exception err)
            {
                return Ok(err);
            }
        }
    }
}
