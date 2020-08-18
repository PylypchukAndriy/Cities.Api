using Cities.Core.Dtos.PointOfInterest;
using FluentValidation;

namespace Cities.Infrastucture.Validators
{
    public class PointOfInterestForCreationValidator : AbstractValidator<PointOfInterestForCreation>
    {
        public PointOfInterestForCreationValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .MaximumLength(25)
                .WithMessage("Please specify valid name");

            RuleFor(x => x.Description)
                .MaximumLength(50);
        }
    }
}
