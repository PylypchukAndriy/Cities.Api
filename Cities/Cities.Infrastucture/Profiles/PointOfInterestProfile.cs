using AutoMapper;
using Cities.Core.Dtos.PointOfInterest;
using Cities.Core.Entities;

namespace Cities.Core.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<PointOfInterestForCreation, PointOfInterest>();
        }
    }
}