using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BiologyCalculator : IGradeCalculator
    {
        public decimal CalculateGrade(StudentGrades studentGrade)
        {
            BiologyStudentGrade grade = (BiologyStudentGrade)studentGrade;
            BiologyCourse course = grade.Course as BiologyCourse;
            return course.AttendanceCriteria * grade.AttendanceGrade+
                course.ExamenCriteria * grade.ExamenGrade + 
                course.HomeworkCriteria * grade.HomeWorkGrade;
        }
    }
}
