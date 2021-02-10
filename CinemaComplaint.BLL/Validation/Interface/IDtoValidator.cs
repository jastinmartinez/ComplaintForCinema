using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComplaint.BLL.Validation.Interface
{
    public interface IDtoValidator<T>
    {
        ValidationResult ValidationResult(T obj);

    }
}
