using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Management_System.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace School_Management_System.Commands;

public class AttendanceCommand
{
    public int AttendanceId { get; set; }
    public int StudentId { get; set; }
    public int ClassId { get; set; }
    public int GroupId { get; set; }
    public DateTime LessonDate { get; set; }
    //public AttendanceStatus attendancestatus { get; set; }

    public int DaysAfterLessonDate() { return (DateTime.Today - LessonDate).Days; }

    public void Validate()
    {
        //Need to validate Attendace status later
        if (AttendanceId <= 0) throw new ValidationException("Attendance Id must be positive");
        if (StudentId <= 0) throw new ValidationException("Student Id must be positive");
        if (ClassId <= 0) throw new ValidationException("Class Id must be positive");
        if (GroupId <= 0) throw new ValidationException("Group Id must be positive");
        if (DaysAfterLessonDate() > 10) { throw new ValidationException("Attendance could not be changed after 10 days"); } 
    
    }
}
