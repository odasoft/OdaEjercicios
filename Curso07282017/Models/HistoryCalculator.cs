using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HistoryCalculator : IGradeCalculator
    {
        public decimal CalculateGrade(StudentGrades studentGrade)
        {
            HistoryStudentGrade historyStudentGrade = studentGrade as HistoryStudentGrade;
            HistoryCourse historyCourse = studentGrade.Course as HistoryCourse;

            return historyCourse.AttendanceCriteria * historyStudentGrade.AttendanceGrade +
                historyCourse.ExamenCriteria + historyStudentGrade.ExamenGrade +
                historyCourse.ExcercisesCriteria * historyStudentGrade.ExcerciseGrade +
                historyCourse.HomeworkCriteria * historyStudentGrade.HomeWorkGrade +
                historyCourse.ParticipationCriteria * historyStudentGrade.ParticipationGrade;
        }
    }
}
