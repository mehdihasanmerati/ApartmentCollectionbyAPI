using ApartmentCollection.Models.Apartments;
using Microsoft.EntityFrameworkCore;

namespace ApartmentCollection.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Apartment> apartments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartment>().HasData(
                 new Apartment
                 {
                     ApartmentId = 1,
                     Name = "Royal Villa",
                     Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa.",
                     ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                     Occupancy = 4,
                     Rate = 200,
                     Meter = 550,
                     CreatedDate = DateTime.Now
                 },
              new Apartment
              {
                  ApartmentId = 2,
                  Name = "Premium Pool Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit.",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                  Occupancy = 4,
                  Rate = 300,
                  Meter = 550,
                  CreatedDate = DateTime.Now
              },
              new Apartment
              {
                  ApartmentId = 3,
                  Name = "Luxury Pool Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                  Occupancy = 4,
                  Rate = 400,
                  Meter = 750,
                  CreatedDate = DateTime.Now
              },
              new Apartment
              {
                  ApartmentId = 4,
                  Name = "Diamond Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor.",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                  Occupancy = 4,
                  Rate = 550,
                  Meter = 900,
                  CreatedDate = DateTime.Now
              },
              new Apartment
              {
                  ApartmentId = 5,
                  Name = "Diamond Pool Villa",
                  Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                  Occupancy = 4,
                  Rate = 600,
                  Meter = 1100,
                  CreatedDate = DateTime.Now
              });

            base.OnModelCreating(modelBuilder);
        }
    }
}





