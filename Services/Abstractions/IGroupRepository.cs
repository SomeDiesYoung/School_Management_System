using School_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Services.Abstractions
{
    public interface IGroupRepository
    { 
        Group GetById(int id);
        void SaveGroup(Group group);
    }
}
