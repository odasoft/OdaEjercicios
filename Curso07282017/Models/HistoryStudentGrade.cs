using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HistoryStudentGrade : StudentGrades
    {
        public decimal ExcerciseGrade { get; set; }
        public decimal ParticipationGrade { get; set; }
    }
}
