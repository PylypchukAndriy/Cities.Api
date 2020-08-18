using AutoMapper;
using Cities.Core.Dtos.PointOfInterest;
using Cities.Core.Entities;
using Cities.Infrastucture;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Cities.Api.Controllers
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsofinterest")]
    public class PointsOfInterestController : ControllerBase
    {
        private readonly CitiesContext _citiesContext;
        private readonly IMapper _mapper;

        public PointsOfInterestController(CitiesContext citiesContext, IMapper mapper)
        {
            _citiesContext = citiesContext ?? throw new ArgumentNullException(nameof(citiesContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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

        [HttpGet("{id}", Name = "GetCityPointsOfIterest")]
        public IActionResult GetCityPointOfIterest(int cityId, int id)
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

            PointOfInterest pointOfInterest = city.PointsOfInterest.SingleOrDefault(x => x.Id == id);
            if (pointOfInterest == null)
            {
                return NotFound(nameof(id));
            }

            return Ok(pointOfInterest);
        }

        [HttpPost]
        public IActionResult Create(int cityId, PointOfInterestForCreation pointOfInterestForCreation)
        {
            City city = _citiesContext.Cities.SingleOrDefault(x => x.Id == cityId);
            if (city == null)
            {
                return NotFound(nameof(cityId));
            }

            PointOfInterest pointOfInterest = _mapper.Map<PointOfInterestForCreation, PointOfInterest>(pointOfInterestForCreation);
            int maxPointOfInterestId = _citiesContext.Cities.SelectMany(x => x.PointsOfInterest).Max(x => x.Id);
            pointOfInterest.Id = ++maxPointOfInterestId;
            city.PointsOfInterest.Add(pointOfInterest);

            return CreatedAtRoute("GetCityPointsOfIterest", new { cityId, pointOfInterest.Id }, pointOfInterest);
        }
    }
}