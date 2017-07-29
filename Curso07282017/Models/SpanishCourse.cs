using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SpanishCourse : GradeableCourse
    {
        public decimal EssayCriteria { get; set; }
        public decimal ConversationCriteria { get; set; }

        public SpanishCourse()
        {
            ExamenCriteria = 10;
            HomeworkCriteria = 10;
            AttendanceCriteria = 10;
            EssayCriteria = 10;
            ConversationCriteria = 10;
        }


    }
}
