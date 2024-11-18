using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Exceptions;

public class ValidationException : DomainException
{
    public ValidationException(string message) : base(message) { }
}
