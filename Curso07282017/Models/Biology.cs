using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Biology : GradeableCourse
    {
        public int Id { get; set; }
        public Biology()
        {
            ExamenCriteria = 4;
            HomeworkCriteria = 4;
            AttendanceCriteria = 5;
        }
    }
}
