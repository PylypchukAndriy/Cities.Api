using Cities.Core;
using Cities.Infrastucture;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace Cities.Api.Controllers
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsofinterest")]
    public class PointsOfInterestController : ControllerBase
    {
        private readonly CitiesContext _citiesContext;

        public PointsOfInterestController(CitiesContext citiesContext)
        {
            _citiesContext = citiesContext ?? throw new ArgumentNullException(nameof(citiesContext));
        }

        [HttpGet]
        public IActionResult GetCityPointsOfIterest(int cityId)
        {
            City city = _citiesContext.Cities.SingleOrDefault(x => x.Id == cityId);
            if (city == null)
            {
                return NotFound(nameof(cityId));
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{id}")]
        public IActionResult GetCityPointsOfIterest(int cityId, int id)
        {
            City city = _citiesContext.Cities.SingleOrDefault(x => x.Id == cityId);
            if (city == null)
            {
                return NotFound(nameof(cityId));
            }

            if (city.PointsOfInterest == null)
            {
                return NotFound();
            }

            var pointOfInterest = city.PointsOfInterest.SingleOrDefault(x => x.Id == id);
            if (pointOfInterest == null)
            {
                return NotFound(nameof(id));
            }

            return Ok(pointOfInterest);
        }
    }
}