using School_Management_System.Exceptions;
using School_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Commands;

public class GroupCommand
{
    public int GroupId { get; set; }
    public List<int> studentIds { get; set; }
    public string Name { get; set; }


    public void Validate()
    {
        if(GroupId <= 0) throw new ValidationException("Group Id must not be Negative");
        if (studentIds?.Count == 0) throw new ValidationException("The list is empty or null");// ar vici nullable kargi ideaa tu ara
        if (string.IsNullOrEmpty(Name)) throw new ValidationException("Name must not be empty");
    }
}