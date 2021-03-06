﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherAPI.Models;

namespace WeatherAPI.Migrations
{
    [DbContext(typeof(WeatherInformationContext))]
    [Migration("20200830131154_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeatherAPI.Models.WeatherInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conditions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MaxTemperature")
                        .HasColumnType("float");

                    b.Property<double>("MinTemperature")
                        .HasColumnType("float");

                    b.Property<string>("Outlook")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WindDirection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WindSpeed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Weather");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Dublin",
                            Conditions = "Sunny",
                            MaxTemperature = 24.0,
                            MinTemperature = 16.0,
                            Outlook = "Cloudy",
                            WindDirection = "North",
                            WindSpeed = 120
                        },
                        new
                        {
                            Id = 2,
                            City = "London",
                            Conditions = "Cloudy",
                            MaxTemperature = 20.0,
                            MinTemperature = 12.0,
                            Outlook = "Sunny",
                            WindDirection = "North",
                            WindSpeed = 140
                        },
                        new
                        {
                            Id = 3,
                            City = "Spain",
                            Conditions = "Sunny",
                            MaxTemperature = 29.0,
                            MinTemperature = 20.0,
                            Outlook = "Sunny",
                            WindDirection = "South",
                            WindSpeed = 60
                        },
                        new
                        {
                            Id = 4,
                            City = "Berlin",
                            Conditions = "Overcast",
                            MaxTemperature = 20.0,
                            MinTemperature = 12.0,
                            Outlook = "Cloudy",
                            WindDirection = "South",
                            WindSpeed = 112
                        },
                        new
                        {
                            Id = 5,
                            City = "Amsterdam",
                            Conditions = "Rain",
                            MaxTemperature = 21.0,
                            MinTemperature = 14.0,
                            Outlook = "Drizzle",
                            WindDirection = "East",
                            WindSpeed = 120
                        },
                        new
                        {
                            Id = 6,
                            City = "Tokyo",
                            Conditions = "Drizzle",
                            MaxTemperature = 19.0,
                            MinTemperature = 11.0,
                            Outlook = "Rain",
                            WindDirection = "East",
                            WindSpeed = 120
                        },
                        new
                        {
                            Id = 7,
                            City = "Vancouver",
                            Conditions = "Snow",
                            MaxTemperature = -10.0,
                            MinTemperature = -14.0,
                            Outlook = "Fog",
                            WindDirection = "West",
                            WindSpeed = 12
                        },
                        new
                        {
                            Id = 8,
                            City = "Toronto",
                            Conditions = "Fog",
                            MaxTemperature = 10.0,
                            MinTemperature = 0.0,
                            Outlook = "Overcast",
                            WindDirection = "West",
                            WindSpeed = 30
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
