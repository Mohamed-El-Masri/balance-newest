using FluentValidation;
using Application.DTOs;

namespace Application.Validation
{
    public class UnitCreateDtoValidator : AbstractValidator<UnitCreateDto>
    {
        public UnitCreateDtoValidator()
        {
            RuleFor(x => x.TitleAr).NotEmpty();
            RuleFor(x => x.TitleEn).NotEmpty();
            RuleFor(x => x.DescriptionAr).NotEmpty();
            RuleFor(x => x.DescriptionEn).NotEmpty();
            RuleFor(x => x.Price).GreaterThan(0);
            RuleFor(x => x.Area).GreaterThan(0);
            RuleFor(x => x.ProjectId).GreaterThan(0);
            RuleFor(x => x.Status).IsInEnum();
        }
    }
} 