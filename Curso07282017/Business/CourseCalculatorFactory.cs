﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CourseCalculatorFactory
    {
        private Dictionary<Type, GradeCalculator> Container { get; set; }

        public CourseCalculatorFactory()
        {
            Container = new Dictionary<Type, GradeCalculator>();
        }
    }
}
