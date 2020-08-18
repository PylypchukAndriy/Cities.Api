using System.ComponentModel.DataAnnotations;

namespace Cities.Core.Dtos.PointOfInterest
{
    public class PointOfInterestForCreation
    {
        [Required]
        public string Name { get; set; }
    }
}