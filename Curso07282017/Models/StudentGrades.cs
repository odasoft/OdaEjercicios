using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StudentGrades
    {
        public GradeableCourse Course { get; set; }
        public decimal ExamenGrade { get; set; }
        public decimal AttendanceGrade { get; set; }
        public decimal HomeWorkGrade { get; set; }
    }
}
