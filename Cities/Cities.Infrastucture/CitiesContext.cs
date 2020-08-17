using Cities.Core;
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
                            Name = "Lake"
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
                            Name = "Restauarants"
                        },
                        new PointOfInterest
                        {
                            Id = 3,
                            Name = "High Castle"
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
                            Name = "Buildings"
                        }
                    }
                }
            };
        }
    }
}