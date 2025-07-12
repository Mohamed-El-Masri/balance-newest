using FluentValidation;
using Application.DTOs;

namespace Application.Validation
{
    public class ProjectCreateDtoValidator : AbstractValidator<ProjectCreateDto>
    {
        public ProjectCreateDtoValidator()
        {
            RuleFor(x => x.NameAr).NotEmpty().WithMessage("اسم المشروع بالعربية مطلوب");
            RuleFor(x => x.NameEn).NotEmpty().WithMessage("Project name in English is required");
            RuleFor(x => x.DescriptionAr).NotEmpty();
            RuleFor(x => x.DescriptionEn).NotEmpty();
            RuleFor(x => x.LocationAr).NotEmpty();
            RuleFor(x => x.LocationEn).NotEmpty();
            RuleFor(x => x.Area).GreaterThan(0);
            RuleFor(x => x.Cost).GreaterThan(0);
            RuleFor(x => x.Type).IsInEnum();
            RuleFor(x => x.Status).IsInEnum();
        }
    }
} 