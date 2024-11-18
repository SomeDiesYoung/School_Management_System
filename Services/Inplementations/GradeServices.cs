using School_Management_System.Services.Abstractions;
using School_Management_System.Models;
using School_Management_System.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Services.Inplementations;

public class GradeServices 
{
    private readonly IGradeRepository _gradeRepository;

    public GradeServices(IGradeRepository gradeRepository)
    {
        _gradeRepository = gradeRepository;
    }
    public void CalculateGrade(GradeCommand gradeInfo)
    {
        gradeInfo.Validate();
        
    }
}
