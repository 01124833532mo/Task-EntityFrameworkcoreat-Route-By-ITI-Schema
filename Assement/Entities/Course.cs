using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement.Entities
{
    internal class Course
    {
        #region by convintion
        //public int ID { get; set; }
        //DateOnly Duration { get; set; }

        //public string Name { get; set; }
        //public string Description { get; set; }

        //public ICollection<Student> students { get; set; } = new HashSet<Student>();
        //public ICollection<Instructor> instructors { get; set; } = new HashSet<Instructor>();

        //public Topic? topic { get; set; } 
        #endregion

        #region dataannotation
        //[Key]
        //public int ID { get; set; }
        //DateOnly Duration { get; set; }

        //[Column(TypeName = "varchar")]
        //[StringLength(50)]
        //public string Name { get; set; }
        //[Column(TypeName = "varchar")]
        //[StringLength(50)]
        //public string Description { get; set; }
        //[InverseProperty (nameof(Entities.Student.courses))]
        //public ICollection<Student> students { get; set; } = new HashSet<Student>();

        //[ForeignKey(nameof(Entities.Topic.ID))]
        //public int? Top_ID { get; set; }

        //[InverseProperty(nameof(Entities.Instructor.courses))]
        //public ICollection<Instructor> instructors { get; set; } = new HashSet<Instructor>();

        //[InverseProperty(nameof(Entities.Topic.courses))]
        //public Topic? topic { get; set; }

        #endregion




        public int ID { get; set; }
        public DateOnly Duration { get; set; }

      
        public string Name { get; set; }
    
        public string Description { get; set; }
        public ICollection<Student_Cours> student_Cours { get; set; } = new HashSet<Student_Cours>();

        public int Top_ID { get; set; }

        public ICollection<Course_Inst>? course_Insts { get; set; } = new HashSet<Course_Inst>();

        public Topic topic { get; set; }



    }
}
