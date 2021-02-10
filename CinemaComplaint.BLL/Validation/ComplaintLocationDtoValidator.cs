using CinemaComplaint.BLL.Dto;
using CinemaComplaint.BLL.Validation.Interface;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComplaint.BLL.Validation
{
   public class ComplaintLocationDtoValidator : AbstractValidator<ComplaintLocationDto>, IDtoValidator<ComplaintLocationDto>
    {
        public ComplaintLocationDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().NotNull().WithMessage("Nombre de ubicacion es requerido");
        }

        public ValidationResult ValidationResult(ComplaintLocationDto obj)
        {
            return Validate(obj);
        }
    }
}
