using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureWebpage.Models
{
    public class WeatherObservation
    {
        public int WeatherObservationId { get; set; }
        public DateTime TimeOfDay { get; set; }
        public double Temperature { get; set; }
        public double AirPressure { get; set; }
        public double AirHumidity { get; set; }
        public Location Locations { get; set; }
    }
}
