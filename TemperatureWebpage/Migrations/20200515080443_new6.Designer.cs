﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TemperatureWebpage.Data;

namespace TemperatureWebpage.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200515080443_new6")]
    partial class new6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TemperatureWebpage.Models.DTOUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(254)")
                        .HasMaxLength(254);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("DTOUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "default@gamil.com",
                            Name = "Default",
                            PasswordHash = "$2a$11$lhlKhaVCl.Y38wMVhNg6JOpx5HfJebQalxDjiPl1STGDp55AlpxQW"
                        },
                        new
                        {
                            Id = 2,
                            Email = "alex@gamil.com",
                            Name = "Alex",
                            PasswordHash = "$2a$11$V2.CusF5aZAHG5IyL4Fyn.XY03xj8BaZoxjoXj0jbshRKwjFkDI0S"
                        });
                });

            modelBuilder.Entity("TemperatureWebpage.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("GPSLatitude")
                        .HasColumnType("float");

                    b.Property<double>("GPSLongitude")
                        .HasColumnType("float");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            GPSLatitude = 2020.0,
                            GPSLongitude = 10505.0,
                            LocationName = "USA"
                        });
                });

            modelBuilder.Entity("TemperatureWebpage.Models.WeatherObservation", b =>
                {
                    b.Property<int>("WeatherObservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AirHumidity")
                        .HasColumnType("float");

                    b.Property<double>("AirPressure")
                        .HasColumnType("float");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationRefId")
                        .HasColumnType("int");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.Property<DateTime>("TimeOfDay")
                        .HasColumnType("datetime2");

                    b.HasKey("WeatherObservationId");

                    b.HasIndex("LocationRefId");

                    b.ToTable("WeatherObservations");

                    b.HasData(
                        new
                        {
                            WeatherObservationId = 1,
                            AirHumidity = 20.0,
                            AirPressure = 30.0,
                            LocationRefId = 1,
                            Temperature = 20.0,
                            TimeOfDay = new DateTime(2020, 5, 6, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            WeatherObservationId = 2,
                            AirHumidity = 40.0,
                            AirPressure = 40.0,
                            LocationRefId = 1,
                            Temperature = 40.0,
                            TimeOfDay = new DateTime(2019, 4, 6, 15, 15, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            WeatherObservationId = 3,
                            AirHumidity = 30.0,
                            AirPressure = 30.0,
                            LocationRefId = 1,
                            Temperature = 23.0,
                            TimeOfDay = new DateTime(2020, 4, 20, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            WeatherObservationId = 4,
                            AirHumidity = 1000.0,
                            AirPressure = 12.0,
                            LocationRefId = 1,
                            Temperature = 55.0,
                            TimeOfDay = new DateTime(2020, 5, 10, 20, 30, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("TemperatureWebpage.Models.WeatherObservation", b =>
                {
                    b.HasOne("TemperatureWebpage.Models.Location", "Location")
                        .WithMany("WeatherObservations")
                        .HasForeignKey("LocationRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
