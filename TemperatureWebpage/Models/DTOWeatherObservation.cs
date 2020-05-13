using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureWebpage.Models
{
    public class DTOWeatherObservation
    {
        public DateTime TimeOfDay { get; set; }
        public double Temperature { get; set; }
        public double AirPressure { get; set; }
        public double AirHumidity { get; set; }
        public string LocationName { get; set; }
        public int LocationRefId { get; set; }
    }
}
