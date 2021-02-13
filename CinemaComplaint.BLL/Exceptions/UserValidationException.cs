using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintForCinema.BLL.Exceptions
{
    public class UserValidationException : Exception
    {
        public IList<ValidationFailure> ValidationFailures { get; set; }
        public UserValidationException(IList<ValidationFailure> ValidationFailures)
        {
            this.ValidationFailures = ValidationFailures;
        }
    }
}
