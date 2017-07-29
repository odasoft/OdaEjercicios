using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MathCourse : GradeableCourse
    {
        public int Id { get; set; }
        public decimal ExcercisesCriteria { get; set; }
        public decimal ParticipationCriteria { get; set; }
    }
}
