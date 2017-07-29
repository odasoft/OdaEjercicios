using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MathCalculator : IGradeCalculator
    {
        public decimal CalculateGrade(StudentGrades studentGrade)
        {
            MathStudentGrade grade = studentGrade as MathStudentGrade;
            MathCourse course = studentGrade.Course as MathCourse;

            return (course.AttendanceCriteria * studentGrade.AttendanceGrade) +
                (course.ExamenCriteria * studentGrade.ExamenGrade) + 
                (course.ExcercisesCriteria * studentGrade.ExcerciseGrade) +
                (course.HomeworkCriteria * studentGrade.HomeWorkGrade) +
                (course.ParticipationCriteria * studentGrade.ParticipationGrade);
        }
    }
}
