using Cities.Core.Entities;
using Cities.Infrastucture;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesContext _citiesContext;

        public CitiesController(CitiesContext citiesContext)
        {
            _citiesContext = citiesContext ?? throw new ArgumentNullException(nameof(citiesContext));
        }

        [HttpGet]
        public ICollection<City> GetCities()
        {
            return _citiesContext.Cities;
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            City city = _citiesContext.Cities.SingleOrDefault(x => x.Id == id);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }
    }
}
