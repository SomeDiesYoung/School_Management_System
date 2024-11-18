using School_Management_System.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Commands;

public class SubjectCommand
{
    public int SubjectId { get; set; }
    public int TeacherId { get; set; }
    public string Name { get; set; }

    public void Validate()
    {
        if (SubjectId <= 0) throw new ValidationException("Subject Id must be positive");
        if (TeacherId <= 0) throw new ValidationException("Teacher Id must be positive");
    if(string.IsNullOrEmpty(Name)) throw new ValidationException("Name can not be empty");
    }
}
