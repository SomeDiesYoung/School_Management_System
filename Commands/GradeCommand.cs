using School_Management_System.Exceptions;
using School_Management_System.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Commands;

public  class GradeCommand
{
    public int GradeId {  get; set; }
    public int StudentId { get; set; }
    public int SubjectId { get; set; }
    public DateTime Date { get; set; }
    public double Points { get; set; }

    public int DaysAfterGraded() { return (DateTime.Today - Date).Days; }

    public void Validate()
    {
        if (GradeId <= 0) throw new ValidationException("Grade Id Must be Positive");

        if (StudentId <= 0) throw new ValidationException("Student Id Must be Positive");

        if (SubjectId <= 0) throw new ValidationException("Subject Id Must be Positive");
        // If you got grade it could not be changed after 10 days(prevents stupid situations ((from my expirience))
        if (DaysAfterGraded() > 10) { throw new ValidationException("Grade could not be changed after 10 days"); } 
        if (Points < 0 || Points >100) throw new ValidationException("Point must be in range from 0 to 100");
        //Validacia AttendanceStatus Tu aris false qula ver daiwereba
    }
}
