using ApartmentCollection.Data;
using ApartmentCollection.Models;
using ApartmentCollection.Models.Apartments;
using ApartmentCollection.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ApartmentCollection.Controllers
{

    [Route("api/ApartmentAPI")]
    [ApiController]
    public class ApartmentAPIController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ApartmentAPIController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //private readonly ILogger<ApartmentAPIController> logger;

        //public ApartmentAPIController(ILogger<ApartmentAPIController> logger)
        //{
        //    this.logger = logger;
        //}

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ApartmentDTO>> GetApartments()
        {
            return Ok(context.apartments.ToList());
        }


        [HttpGet("{id:int}", Name = "GetApartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ApartmentDTO> GetApartments(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
             
            var Apartment = context.apartments.FirstOrDefault(u => u.ApartmentId == id);

            if (Apartment == null)
            {
                return NotFound();
            }
            return Ok(Apartment);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ApartmentDTO> createApartment([FromBody]ApartmentDTO apartmentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (context.apartments.FirstOrDefault(u => u.Name.ToLower() == apartmentDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("", "apartment is already exist");
                return BadRequest(ModelState);
            }
            if (apartmentDTO == null)
            {
                return BadRequest(apartmentDTO);
            }
            if (apartmentDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Apartment model = new()
            {
                ApartmentId = apartmentDTO.Id,
                Name = apartmentDTO.Name,
                Meter = apartmentDTO.Meter,
                Occupancy = apartmentDTO.Occupancy,
                Details = apartmentDTO.Details,
                ImageUrl = apartmentDTO.ImageUrl,
            };
            context.apartments.Add(model);
            context.SaveChanges();

            return CreatedAtRoute("GetApartment", new { id = apartmentDTO.Id }, apartmentDTO);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "Delete Apartment")]
        public IActionResult DeleteApartment(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var apartment = context.apartments.FirstOrDefault(d => d.ApartmentId == id);
            if (apartment == null)
            {
                return NotFound();
            }
            context.apartments.Remove(apartment);
            context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id:int}", Name = "Update Apartment")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateApartment(int id, [FromBody] ApartmentDTO apartmentDTO)
        {
            if (apartmentDTO == null || id != apartmentDTO.Id)
            {
                return BadRequest();
            }

            Apartment model = new()
            {
                ApartmentId = apartmentDTO.Id,
                Name = apartmentDTO.Name,
                Meter = apartmentDTO.Meter,
                Occupancy = apartmentDTO.Occupancy,
                Details = apartmentDTO.Details,
                ImageUrl = apartmentDTO.ImageUrl,
            };
            context.apartments.Update(model);
            context.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "Update Partial Apartment")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePartialApartment(int id, JsonPatchDocument<ApartmentDTO> pathDTO)
        {
            if (pathDTO == null || id == 0)
            {
                return BadRequest();
            }
            var apartment = context.apartments.AsNoTracking().FirstOrDefault(d => d.ApartmentId ==  id);

            ApartmentDTO model = new()
            {
                Id = apartment.ApartmentId,
                Name = apartment.Name,
                Meter = apartment.Meter,
                Occupancy= apartment.Occupancy,
                Details = apartment.Details,
                ImageUrl = apartment.ImageUrl,
            };

            if (apartment == null)
            {
                return BadRequest();
            }

            pathDTO.ApplyTo(model, ModelState);
            Apartment getApartment = new Apartment()
            {
                ApartmentId = model.Id,
                Name = model.Name,
                Meter = model.Meter,
                Occupancy = model.Occupancy,
                Details = model.Details,
                ImageUrl = model.ImageUrl,
            };
            context.apartments.Update(getApartment);
            context.SaveChanges();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
} 
