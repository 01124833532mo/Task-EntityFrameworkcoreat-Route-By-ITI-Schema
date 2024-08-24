using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement.Entities
{
    internal class Student_Cours
    {
        //public int? Stud_ID { get; set; }

        //public int? Cours_ID { get; set; }

        //public int Grade { get; set; }

        //public Student? student { get; set; }
        //public Course? course { get; set; }

        public int Stud_ID { get; set; }

        public int Cours_ID { get; set; }

        public int Grade { get; set; }

        public Student student { get; set; }
        public Course course { get; set; }


    }
}
