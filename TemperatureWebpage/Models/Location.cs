using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureWebpage.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        public string LocationName { get; set; }
        
        public double GPSLatitude { get; set; }
        
        public double GPSLongitude { get; set; }
        
        public virtual ICollection<WeatherObservation> WeatherObservations { get; set; }
    }
}
