using School_Management_System.Models;
using School_Management_System.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Commands;

namespace School_Management_System.Services.Inplementations;

public class SubjectServices
{
    private ISubjectRepository _subjectRepository;
    public SubjectServices(ISubjectRepository subjectRepository)
    {
        _subjectRepository = subjectRepository;
    }

    public void SomeMethod(SubjectCommand subjectInfo)
    {
        subjectInfo.Validate();
    }
}
