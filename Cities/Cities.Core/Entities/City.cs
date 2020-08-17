using System.Collections.Generic;

namespace Cities.Core.Entities
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PointsOfInterestCount => PointsOfInterest.Count;

        public ICollection<PointOfInterest> PointsOfInterest { get; set; }
    }
}