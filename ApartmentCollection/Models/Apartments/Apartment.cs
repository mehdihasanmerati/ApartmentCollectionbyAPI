using System.ComponentModel.DataAnnotations;

namespace ApartmentCollection.Models.Apartments
{
    public class Apartment
    {
        public int ApartmentId { get; set; }
        [Required]
        public string Name { get; set; }
        public double Rate { get; set; }
        public int Meter { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
        public string Details { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
