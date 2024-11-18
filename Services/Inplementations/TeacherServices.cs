using School_Management_System.Commands;
using School_Management_System.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Services.Inplementations;

public class TeacherServices
{
    private readonly ITeacherRepository _teacherRepository;
    public TeacherServices(ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }

    public void SomeMethod(TeacherCommand teacherInfo)
    {

    }
}
