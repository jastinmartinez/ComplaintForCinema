﻿using ComplaintForCinema.BLL.Dto;
using ComplaintForCinema.BLL.Validation.Interface;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintForCinema.BLL.Validation
{
    public class ComplaintStatusDtoValidator : AbstractValidator<ComplaintStatusDto>, IDtoValidator<ComplaintStatusDto>
    {
        public ComplaintStatusDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().NotNull().WithMessage("Nombre de estatus es requerido");
        }

        public ValidationResult ValidationResult(ComplaintStatusDto obj)
        {
            return Validate(obj);
        }
    }
}
