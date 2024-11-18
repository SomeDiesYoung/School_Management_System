using School_Management_System.Commands;
using School_Management_System.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Services.Inplementations;

public class StudentServices
{
    private readonly IStudentRepository _studentRepository;
    public StudentServices(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    
    public void someMethod(StudentCommand studentInfo)
    {
        studentInfo.Validate();
    }
}
