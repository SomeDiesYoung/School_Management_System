using School_Management_System.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Commands;

public class StudentCommand
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //public bool StudentStatus { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public int ClassId { get; set; }
    public void Validate()
    {
        if (StudentId <= 0) throw new ValidationException("Student Id Must be Positive");

        if (ClassId <= 0) throw new ValidationException("Class Id Must be Positive");
        // If you got grade it could not be changed after 10 days(prevents stupid situations ((from my expirience))
        
        if (string.IsNullOrWhiteSpace(FirstName)) 
             throw new ValidationException("FirstName must not be empty");

        if (string.IsNullOrWhiteSpace(LastName)) 
             throw new ValidationException("LastName must not be empty");

        if (string.IsNullOrWhiteSpace(Email)) 
             throw new ValidationException("Email must not be empty");

        if (string.IsNullOrWhiteSpace(PhoneNumber)) 
             throw new ValidationException("PhoneNumber must not be empty");

        if (string.IsNullOrWhiteSpace(Address)) 
             throw new ValidationException("Address must not be empty");
    }
}
