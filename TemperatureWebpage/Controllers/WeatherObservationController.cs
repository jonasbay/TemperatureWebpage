using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TemperatureWebpage.Data;
using TemperatureWebpage.Models;

namespace TemperatureWebpage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherObservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WeatherObservationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/weatherobservation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeatherObservation>>> GetWeatherObservation()
        {
            return await _context.WeatherObservations.ToListAsync();
        }
    }
}
