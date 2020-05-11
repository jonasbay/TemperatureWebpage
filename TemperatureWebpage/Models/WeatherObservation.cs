using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("Location")] public int LocationRefId { get; set; }
        public virtual Location Location { get; set; }
    }
}
