using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StudentGrade
    {
        public DateTime GradedOn { get; set; }
        public decimal Grade { get; set; }
        public GradeableCourse Course { get; set; }
    }
}
