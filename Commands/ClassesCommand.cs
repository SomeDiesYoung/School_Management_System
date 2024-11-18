using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Exceptions;
namespace School_Management_System.Commands;

public class ClassesCommand
{
    public int ClassesId { get; set; }
    public string Room { get; set; }
    public int TeacherId { get; set; }
    public int GroupId { get; set; }

    public void Validate()
    {
        if (ClassesId <= 0) throw new ValidationException("Classes Id can not be Negative");
        if (TeacherId <= 0) throw new ValidationException("Teacher Id can not be Negative");
        if (GroupId <= 0) throw new ValidationException("group Id can not be Negative");
        if (string.IsNullOrEmpty(Room)) throw new ValidationException("Room`s naming can not be empty");
    }
}
