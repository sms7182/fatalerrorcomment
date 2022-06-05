using FluentValidation;
using Relex.BrandReputation.Domain.Entities;

namespace Relex.BrandReputation.Domain.Validators
{
    public class ReviewValidator : AbstractValidator<Review>
    {
        public ReviewValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(120);

            
            RuleFor(e => e.Content)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(1500);
            
            RuleFor(e => e.StartDate)
                .Must(p => !p.HasValue || p.Value.UtcDateTime >= DateTime.UtcNow)
                .When(e => e.StartDate.HasValue)
                .WithMessage("{PropertyName} must be equal or greater than now");
            
            RuleFor(e => e.EndDate)
                .Must(p => !p.HasValue || p.Value.UtcDateTime >= DateTime.UtcNow)
                .WithMessage("{PropertyName} must be equal or greater than now"); ;

            RuleFor(e => e.EndDate)
                .Must((e, p) => e.StartDate <= e.EndDate)
                .Unless(e => !e.StartDate.HasValue || !e.EndDate.HasValue)
                .WithMessage("{PropertyName} must be  greater than 'Start Date'");



        }

        public override FluentValidation.Results.ValidationResult Validate(ValidationContext<Review> context)
        {
            return base.Validate(context);
        }
    }

    
}
