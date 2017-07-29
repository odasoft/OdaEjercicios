using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SpanishStudentGrades : StudentGrades
    {
        public decimal EssayGrade { get; set; }
        public decimal ConversationGrade { get; set; }
    }
}
