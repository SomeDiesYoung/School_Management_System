using School_Management_System.Services.Abstractions;
using School_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Services.Inplementations
{
    public class InMemoryGradeRepository : IGradeRepository
    {
        private readonly List<Grade> _grades;

        public InMemoryGradeRepository()
        {
            _grades = new List<Grade>
            {
                new Grade
                {
                    Id = 1,
                    StudentId =1,
                    SubjectId = 1,
                    Date = new DateTime(2011, 6, 10),
                    Points = 55
                },
                new Grade
                {
                    Id = 2,
                    StudentId =1,
                    SubjectId = 2,
                    Date = new DateTime(2011, 6, 10),
                    Points = 63
                }
            };
        }

        public Grade GetById(int id)
        {
            return _grades.FirstOrDefault(grade => grade.Id==id);
        }

        public void SaveInfo(Grade grade)
        {
                throw new NotImplementedException();
        }
    }
}
