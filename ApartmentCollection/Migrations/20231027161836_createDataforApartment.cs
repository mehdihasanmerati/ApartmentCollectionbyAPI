﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApartmentCollection.Migrations
{
    /// <inheritdoc />
    public partial class createDataforApartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "apartments",
                columns: table => new
                {
                    ApartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Meter = table.Column<int>(type: "int", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_apartments", x => x.ApartmentId);
                });

            migrationBuilder.InsertData(
                table: "apartments",
                columns: new[] { "ApartmentId", "CreatedDate", "Details", "ImageUrl", "Meter", "Name", "Occupancy", "Rate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 27, 19, 48, 36, 55, DateTimeKind.Local).AddTicks(9401), "Fusce 11 tincidunt maximus leo, sed scelerisque massa.", "https://dotnetmastery.com/bluevillaimages/villa3.jpg", 550, "Royal Villa", 4, 200.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 10, 27, 19, 48, 36, 55, DateTimeKind.Local).AddTicks(9412), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit.", "https://dotnetmastery.com/bluevillaimages/villa1.jpg", 550, "Premium Pool Villa", 4, 300.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 10, 27, 19, 48, 36, 55, DateTimeKind.Local).AddTicks(9413), "Fusce 11 tincidunt maximus leo, sed scelerisque massa", "https://dotnetmastery.com/bluevillaimages/villa4.jpg", 750, "Luxury Pool Villa", 4, 400.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 10, 27, 19, 48, 36, 55, DateTimeKind.Local).AddTicks(9415), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor.", "https://dotnetmastery.com/bluevillaimages/villa5.jpg", 900, "Diamond Villa", 4, 550.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 10, 27, 19, 48, 36, 55, DateTimeKind.Local).AddTicks(9416), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor", "https://dotnetmastery.com/bluevillaimages/villa2.jpg", 1100, "Diamond Pool Villa", 4, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "apartments");
        }
    }
}
