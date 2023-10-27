using ApartmentCollection.Models;
using ApartmentCollection.Models.Dto;

namespace ApartmentCollection.Data
{
    public static class ApartmentStore
    {
        public static List<ApartmentDTO> apatmentList = new List<ApartmentDTO>
        {
            new ApartmentDTO{Id = 1, Name = "Living Room View", Occupancy = 20, Meter = 200, CreatedDate = new DateTime(2023,11,5)},
            new ApartmentDTO{Id = 2, Name = "Balkony View", Occupancy = 30, Meter = 300, CreatedDate = new DateTime(2022,05,06)},
            new ApartmentDTO{Id = 3, Name = "Garden View", Occupancy = 40, Meter = 400, CreatedDate = new DateTime(2021,10,12)}
        };
    }
 
}
