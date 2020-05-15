using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TemperatureWebpage.Data;
using TemperatureWebpage.Hubs;
using TemperatureWebpage.Models;
using TemperatureWebpage.Utilities;

namespace TemperatureWebpage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Client")]
    //[Authorize]
    public class WeatherObservationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHubContext<ObservationsHub> _hub;

        public WeatherObservationController(ApplicationDbContext context, IHubContext<ObservationsHub> hub)
        {
            _context = context;
            _hub = hub;
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
            return WeatherObs.OrderByDescending(wo => wo.TimeOfDay).Take(3);
        }


        //public IEnumerable<WeatherObservation> GetWOOnDate()
        //{
        //    return _service.Get()
        //        .Where(wo => (wo.TimeStamp.Date.CompareTo(id.Date) == 0))
        //        .ToList();
        //}

        [HttpGet("date/{date}", Name = "DateGet")]
        public ActionResult<List<WeatherObservation>> DateGet(string date)
        {
            List<WeatherObservation> newList = new List<WeatherObservation>();

            foreach (var foundDate in _context.WeatherObservations)
            {
                if (foundDate.TimeOfDay.Date.ToString() == date + " 00:00:00")
                {
                    var WO = new WeatherObservation()
                    {
                        Temperature = foundDate.Temperature,
                        AirPressure = foundDate.AirPressure,
                        AirHumidity = foundDate.AirHumidity,
                        TimeOfDay = foundDate.TimeOfDay,
                        WeatherObservationId = foundDate.WeatherObservationId,
                        LocationName = foundDate.LocationName
                    };
                    newList.Add(WO);
                }
            }

            if (newList.Count == 0)
            {
                return NotFound();
            }
            return newList;
        }

        [HttpGet("date/{date1}/{date2}", Name = "BetweenDateGet")]
        public ActionResult<List<WeatherObservation>> BetweenDateGet(string date1, string date2)
        {
            List<WeatherObservation> newList = new List<WeatherObservation>();

            foreach (var wo in _context.WeatherObservations)
            {
                var dateFound = wo.TimeOfDay.Date;

                //if ((string.Compare(dateFound, date1 + " 00:00:00") >= 0 ) 
                //    && (string.Compare(dateFound, date2 + " 00:00:00") <= 0))
                if ((DateTime.Compare(dateFound, DateTime.Parse(date1)) >= 0) && (DateTime.Compare(dateFound, DateTime.Parse(date2)) <= 0))
                {
                    var WeatherObs = new WeatherObservation
                    {
                        Temperature = wo.Temperature,
                        AirPressure = wo.AirPressure,
                        AirHumidity = wo.AirHumidity,
                        TimeOfDay = wo.TimeOfDay,
                        WeatherObservationId = wo.WeatherObservationId,
                        LocationName = wo.LocationName
                    };
                    newList.Add(WeatherObs);
                }
            }

            if (newList.Count == 0)
            {
                return NotFound();
            }
            return newList;
        }

        [HttpPost("UploadWeatherObservation")]
        public async Task<ActionResult<WeatherObservation>> UploadWeatherObservation(DTOWeatherObservation DtoweatherObs)
        {
            var weather = new WeatherObservation()
            {
                TimeOfDay = DtoweatherObs.TimeOfDay,
                Temperature = DtoweatherObs.Temperature,
                AirPressure = DtoweatherObs.AirPressure,
                AirHumidity = DtoweatherObs.AirHumidity,
                LocationName = DtoweatherObs.LocationName,
                LocationRefId = DtoweatherObs.LocationRefId
            };
            _context.WeatherObservations.Add(weather);
            await _context.SaveChangesAsync();

            return Created(weather.WeatherObservationId.ToString(), weather);
        }

    }
}
