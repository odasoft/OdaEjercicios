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

        public SpanishCourse(decimal examenCriteria, decimal homeworkCriteria, decimal attendanceCriteria, decimal essayCriteria, decimal conversationCriteria)
        {
            ExamenCriteria = examenCriteria;
            HomeworkCriteria = homeworkCriteria;
            AttendanceCriteria = attendanceCriteria;
            EssayCriteria = essayCriteria;
            ConversationCriteria = conversationCriteria;
        }


    }
}
