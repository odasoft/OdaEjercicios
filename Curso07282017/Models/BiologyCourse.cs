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
            ExamenCriteria = 0.20m;
            HomeworkCriteria = 0.05m;
            AttendanceCriteria = 0.05m;

            LabPractices = 0.20m;
            ExposureOfThemes = 0.40m;
        }
    }
}
