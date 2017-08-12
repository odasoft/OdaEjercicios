using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CourseCalculatorFactory
    {
        private Dictionary<Type, IGradeCalculator> Container { get; set; }

        public CourseCalculatorFactory()
        {
            Container = new Dictionary<Type, IGradeCalculator>();
            Container.Add(typeof(MathCourse), new MathCalculator());
            Container.Add(typeof(BiologyCourse), new BiologyCalculator());
            Container.Add(typeof(PhysicCourse), new PhysicCalculator());
            Container.Add(typeof(SpanishCourse), new SpanishCalculator());
        }

        public IGradeCalculator GetCourseCalculator(GradeableCourse gradeableCourse)
        {
            return Container[gradeableCourse.GetType()];
        }
    }
}
