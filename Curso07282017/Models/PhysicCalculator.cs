using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhysicCalculator : IGradeCalculator
    {
        public decimal CalculateGrade(StudentGrades studentGrade)
        {
            PhysicStudentGrade physicStudentGrade = studentGrade as PhysicStudentGrade;
            PhysicCourse physicCourse = studentGrade.Course as PhysicCourse;

            return
                physicCourse.ExamenCriteria * physicStudentGrade.ExamenGrade +
                physicCourse.HomeworkCriteria * physicStudentGrade.HomeWorkGrade +
                physicCourse.AttendanceCriteria * physicStudentGrade.AttendanceGrade +
                physicCourse.PresentationCriteria * physicStudentGrade.PresentationGrade;

        }
    }
}
