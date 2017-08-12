using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SpanishCalculator : IGradeCalculator
    {
        private const decimal NOCRITERIAS = 5;

        public decimal CalculateGrade(StudentGrades studentGrade)
        {
            var spanishGrades = studentGrade as SpanishStudentGrades;
            var spanishCourse = studentGrade.Course as SpanishCourse; 

            return (spanishGrades.AttendanceGrade * spanishCourse.AttendanceCriteria +                 
                spanishGrades.ExamenGrade * spanishCourse.ExamenCriteria + 
                spanishGrades.HomeWorkGrade * spanishCourse.HomeworkCriteria +
                spanishGrades.EssayGrade * spanishCourse.EssayCriteria +
                spanishGrades.ConversationGrade * spanishCourse.ConversationCriteria) / NOCRITERIAS;
        }
    }
}
