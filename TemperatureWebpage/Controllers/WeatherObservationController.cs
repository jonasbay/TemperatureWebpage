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
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Location>>> GetWeatherObservation()
        //{
        //    return await _context.Locations.ToListAsync();
        //}

        //Get three latest
        [HttpGet]
        public IEnumerable<WeatherObservation> GetThree()
        {
            var WeatherObs1 = _context.WeatherObservations.OrderByDescending(wo => wo.TimeOfDay).Take(3);

            var WeatherObs = from wo in _context.WeatherObservations
                              select new WeatherObservation
                              {
                                  Temperature = wo.Temperature,
                                  AirPressure = wo.AirPressure,
                                  AirHumidity = wo.AirHumidity,
                                  TimeOfDay = wo.TimeOfDay,
                                  WeatherObservationId = wo.WeatherObservationId,
                                  LocationName = wo.Location.LocationName
                              };
            return WeatherObs.Take(3);
        }

        //Løsningsforslag fra Daniella til Datosortering
        //return _service.Get()
        //        .Where(wo => (wo.TimeStamp.Date.CompareTo(id.Date) == 0))
        //        .ToList();
    }
}
