﻿// <auto-generated />
using System;
using ApartmentCollection.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApartmentCollection.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApartmentCollection.Models.Apartments.Apartment", b =>
                {
                    b.Property<int>("ApartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApartmentId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Meter")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ApartmentId");

                    b.ToTable("apartments");

                    b.HasData(
                        new
                        {
                            ApartmentId = 1,
                            CreatedDate = new DateTime(2023, 10, 27, 21, 0, 38, 275, DateTimeKind.Local).AddTicks(2442),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa.",
                            ImageUrl = "",
                            Meter = 550,
                            Name = "Royal Villa",
                            Occupancy = 4,
                            Rate = 200.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ApartmentId = 2,
                            CreatedDate = new DateTime(2023, 10, 27, 21, 0, 38, 275, DateTimeKind.Local).AddTicks(2453),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit.",
                            ImageUrl = "",
                            Meter = 550,
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Rate = 300.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ApartmentId = 3,
                            CreatedDate = new DateTime(2023, 10, 27, 21, 0, 38, 275, DateTimeKind.Local).AddTicks(2455),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa",
                            ImageUrl = "",
                            Meter = 750,
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Rate = 400.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ApartmentId = 4,
                            CreatedDate = new DateTime(2023, 10, 27, 21, 0, 38, 275, DateTimeKind.Local).AddTicks(2456),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor.",
                            ImageUrl = "",
                            Meter = 900,
                            Name = "Diamond Villa",
                            Occupancy = 4,
                            Rate = 550.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ApartmentId = 5,
                            CreatedDate = new DateTime(2023, 10, 27, 21, 0, 38, 275, DateTimeKind.Local).AddTicks(2458),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor",
                            ImageUrl = "",
                            Meter = 1100,
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Rate = 600.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
