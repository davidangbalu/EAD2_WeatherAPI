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
    [Migration("20200830130334_initial")]
    partial class initial
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
                });
#pragma warning restore 612, 618
        }
    }
}
