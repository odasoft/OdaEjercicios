using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhysicCalculator : IGradeCalculator
    {
        public decimal CalculateGrade(StudentGrades studentGrade)
        {
            PhysicStudentGrade physicStudentGrade = studentGrade as PhysicStudentGrade;

            return 
        }
    }
}
