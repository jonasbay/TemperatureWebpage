using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TemperatureWebpage.Models;

namespace TemperatureWebpage.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherObservation> WeatherObservations { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<WeatherObservation>()
            //    .HasOne<Location>(l => l.Location)
            //    .WithMany(p => p.WeatherObservations)
            //    .HasForeignKey(l => l.LocationRefName);

            modelBuilder.Entity<Location>()
                .HasData(new Location { LocationId = 1, LocationName = "USA", GPSLatitude = 2020, GPSLongitude = 10505 });

            modelBuilder.Entity<WeatherObservation>().HasData(
                new WeatherObservation{ WeatherObservationId = 1, TimeOfDay = new DateTime(2020, 05, 06, 12, 00, 00), Temperature = 20, AirPressure = 30, AirHumidity = 20, LocationRefId = 1 },
                new WeatherObservation { WeatherObservationId = 2, TimeOfDay = new DateTime(2019, 04, 06, 15, 15, 00), Temperature = 40, AirPressure = 40, AirHumidity = 40, LocationRefId = 1 },
                new WeatherObservation { WeatherObservationId = 3, TimeOfDay = new DateTime(2020, 04, 20, 09, 00, 00), Temperature = 23, AirPressure = 30, AirHumidity = 30, LocationRefId = 1 },
                new WeatherObservation { WeatherObservationId = 4, TimeOfDay = new DateTime(2020, 05, 10, 20, 30, 00), Temperature = 55, AirPressure = 12, AirHumidity = 1000, LocationRefId = 1 });
        }
    }
}
