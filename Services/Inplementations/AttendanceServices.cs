using School_Management_System.Commands;
using School_Management_System.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Services.Inplementations
{
    public class AttendanceServices
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public AttendanceServices(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public void SomeMethod(AttendanceCommand attendanceInfo)
        {
            attendanceInfo.Validate();
        }
    }
}
