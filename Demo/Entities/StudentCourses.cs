﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class StudentCourses
    {
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public int Crade { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}
