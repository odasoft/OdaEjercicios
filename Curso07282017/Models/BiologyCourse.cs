using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BiologyCourse : GradeableCourse
    {
        public int Id { get; set; }
        public decimal LabPractices { get; set; }
        public decimal ExposureOfThemes { get; set; }
        public BiologyCourse()
        {
            ExamenCriteria = 5;
            HomeworkCriteria = 4;
            AttendanceCriteria = 2;
            LabPractices = 4;
            ExposureOfThemes = 4;
        }
    }
}
