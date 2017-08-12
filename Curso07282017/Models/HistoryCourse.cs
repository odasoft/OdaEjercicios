using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HistoryCourse : GradeableCourse
    {
        public int Id { get; set; }
        public decimal ExcercisesCriteria { get; set; }
        public decimal ParticipationCriteria { get; set; }

        public HistoryCourse(decimal ExamenCriteria, decimal HomeworkCriteria, decimal AttendanceCriteria,
            decimal ExcercisesCriteria, decimal ParticipationCriteria)
        {
            this.ExamenCriteria = ExamenCriteria;
            this.HomeworkCriteria = HomeworkCriteria;
            this.AttendanceCriteria = AttendanceCriteria;
            this.ExcercisesCriteria = ExcercisesCriteria;
            this.ParticipationCriteria = ParticipationCriteria;
        }
    }
}
