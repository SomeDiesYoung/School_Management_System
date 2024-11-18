using School_Management_System.Commands;
using School_Management_System.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Services.Inplementations
{
    public class ClassesServices
    {
        private readonly IClassesRepository _classesRepository;

        public ClassesServices(IClassesRepository classesRepository)
        {
            _classesRepository = classesRepository;
        }

        public void SomeMethod(ClassesCommand commandInfo)
        {
            commandInfo.Validate();
        }
    }
}
