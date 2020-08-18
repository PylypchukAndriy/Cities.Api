using System.ComponentModel.DataAnnotations;

namespace Cities.Core.Dtos.PointOfInterest
{
    public class PointOfInterestForCreation
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }
    }
}