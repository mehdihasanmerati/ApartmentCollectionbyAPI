using System.ComponentModel.DataAnnotations;

namespace ApartmentCollection.Models.Dto
{
    //4- create DTO model
    public class ApartmentDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public int Occupancy { get; set; }
        public int Meter { get; set; }
        public string ImageUrl { get; set; }
        public string Details { get; set; }
        public DateTime CreatedDate { get; set; } 
    }
}
