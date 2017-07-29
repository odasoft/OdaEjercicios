using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhysicCourse : GradeableCourse
    {

        public decimal PresentationCriteria { get; set; }
        PhysicCourse(int examenCriteria, int homeworkCriteria, int attendanceCriteria, int presentationCriteria)
        {
            this.ExamenCriteria = examenCriteria;
            this.HomeworkCriteria = homeworkCriteria;
            this.AttendanceCriteria = attendanceCriteria;
            this.PresentationCriteria = presentationCriteria;
        }
    }
}
