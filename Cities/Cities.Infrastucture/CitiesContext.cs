using Cities.Core.Entities;
using System.Collections.Generic;

namespace Cities.Infrastucture
{
    public class CitiesContext
    {
        public ICollection<City> Cities { get; }

        public CitiesContext()
        {
            Cities = new List<City>
            {
                new City
                {
                    Id = 1,
                    Name = "Ternopil",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Id = 1,
                            Name = "Lake",
                            Description = "Beautiful lake in centre of the town"
                        }
                    }
                },
                new City
                {
                    Id = 2,
                    Name = "Lviv",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Id = 2,
                            Name = "Restauarants",
                            Description = "Fashionable restaurant"
                        },
                        new PointOfInterest
                        {
                            Id = 3,
                            Name = "High Castle",
                            Description = "Place to be"
                        }
                    }
                },
                new City
                {
                    Id = 3,
                    Name = "Chervonograd",
                    PointsOfInterest = new List<PointOfInterest>()
                },
                new City
                {
                    Id = 5,
                    Name = "Kyiv",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Id = 5,
                            Name = "Buildings",
                            Description = "Amazing architectural solutions"
                        }
                    }
                }
            };
        }
    }
}