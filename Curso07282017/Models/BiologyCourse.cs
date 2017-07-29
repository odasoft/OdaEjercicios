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
            ExamenCriteria = 30;
            HomeworkCriteria = 5;
            AttendanceCriteria = 5;

            LabPractices = 20;
            ExposureOfThemes = 40;
        }
    }
}
