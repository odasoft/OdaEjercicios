using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhysicStudentGrade: StudentGrades
    {
        public decimal PresentationGrade { set; get; }
        public PhysicCourse Course { set; get; }


        public PhysicStudentGrade(decimal ExamenGrade, decimal AttendanceGrade, decimal HomeWorkGrade, decimal PresentationGrade, PhysicCourse Course) {
            this.ExamenGrade = ExamenGrade;
            this.AttendanceGrade = AttendanceGrade;
            this.HomeWorkGrade = HomeWorkGrade;
            this.PresentationGrade = PresentationGrade;
            this.Course = Course;

        }


    }
}
