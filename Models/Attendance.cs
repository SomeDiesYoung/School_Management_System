using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Models;

public  class Attendance
{
    public int Id { get; set; }
    public int StudentId {  get; set; }
    public int ClassId {  get; set; }
    public int GroupId { get; set; }
    public DateTime LessonDate { get; set; }
    //public AttendanceStatus attendancestatus { get; set; }
   
}

//public enum AttendanceStatus
//{
//    present,
//    absent,
//    late,
//    Excused
//}
