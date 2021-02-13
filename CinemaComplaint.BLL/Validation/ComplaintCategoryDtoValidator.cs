using ComplaintForCinema.BLL.Dto;
using ComplaintForCinema.BLL.Validation.Interface;
using FluentValidation;
using FluentValidation.Results;

namespace ComplaintForCinema.BLL.Validation
{
    public class ComplaintCategoryDtoValidator : AbstractValidator<ComplaintCategoryDto>, IDtoValidator<ComplaintCategoryDto>
    {
        public ComplaintCategoryDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Nombre de categoria es requerido");
        }

        public ValidationResult ValidationResult(ComplaintCategoryDto obj)
        {
            return Validate(obj);
        }
    }
}
