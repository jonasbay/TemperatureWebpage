using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TemperatureWebpage.Controllers;
using TemperatureWebpage.Data;
using TemperatureWebpage.Models;
using TemperatureWebpage.Utilities;
using Xunit;

namespace TemperatureWebpage.Test
{
    public class TemperatureWebpageUnitTests
    {
        private DbContextOptions<ApplicationDbContext> _options;
        private SqliteConnection _connection;
        private WeatherObservationController _uut;

        public TemperatureWebpageUnitTests()
        {
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();
            _options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(_connection).Options;
        }   

        [Fact]
        public void DataSeeded()
        {
            using (var context = new ApplicationDbContext(_options))
            {
                context.Database.EnsureCreated();
                Assert.NotEmpty(context.WeatherObservations.ToList());
            }
        }

        [Fact]
        public void GetThreeWeatherObservations()
        {
            using (var context = new ApplicationDbContext(_options))
            {
                context.Database.EnsureCreated();

                _uut = new WeatherObservationController(context);

                var result = _uut.GetThree();

                Assert.Equal(3, result.Count());
            }
        }

        [Fact]
        public async Task GetWeatherObservationFromDateGet1()
        {
            using (var context = new ApplicationDbContext(_options))
            {
                context.Database.EnsureCreated();

                _uut = new WeatherObservationController(context);

                DTOWeatherObservation entry = new DTOWeatherObservation()
                {
                    TimeOfDay = new DateTime(2020, 05, 06, 00, 00, 00),
                    LocationName = "USA",
                    Temperature = 50,
                    AirPressure = 5,
                    AirHumidity = 10,
                    LocationRefId = 1
                };
                await _uut.UploadWeatherObservation(entry);

                var result = _uut.DateGet("06-05-2020");

                Assert.Equal("USA", result.Value.FirstOrDefault().LocationName);

                //Assert.Equal("2020-05-06 12:00:00", result.Value.FirstOrDefault().TimeOfDay.Date.ToString());
            }
        }

        //[Fact]
        //public async Task GetWeatherBetweenDate()
        //{
        //    using (var context = new ApplicationDbContext(_options))
        //    {
        //        context.Database.EnsureCreated();
        //        _uut = new WeatherObservationController(context);

        //        var result = _uut.BetweenDateGet("04-05-2020","11-06-2020");
        //        Assert.Equal("USA", result.Value.FirstOrDefault().LocationName);
        //    }
        //}

        [Fact]
        public async Task UploadWeatherObservation()
        {
            using (var context = new ApplicationDbContext(_options))
            {
                context.Database.EnsureCreated();
                int initial = context.WeatherObservations.ToList().Count;
                _uut = new WeatherObservationController(context);
                DTOWeatherObservation entry = new DTOWeatherObservation()
                {
                    TimeOfDay = DateTime.Now,
                    LocationName = "USA",
                    Temperature = 50,
                    AirPressure = 5,
                    AirHumidity = 10,
                    LocationRefId = 1
                };

                await _uut.UploadWeatherObservation(entry);
                Assert.Equal(initial + 1, context.WeatherObservations.ToList().Count);
            }
        }
    }
}
