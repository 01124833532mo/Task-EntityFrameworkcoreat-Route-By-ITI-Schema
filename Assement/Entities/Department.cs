using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement.Entities
{
    internal class Department
    {
        #region by convintion
        //public int ID { get; set; }

        //public string Name { get; set; }

        //public DateOnly HiringDate { get; set; }

        //public ICollection<Student> students { get; set; } = new HashSet<Student>();

        //public ICollection<Instructor> instructors  { get; set; } = new HashSet<Instructor>(); 

        public Instructor instructor { get; set; }
        #endregion

        #region DataAnnotation
        //[Key]
        //public int ID { get; set; }
        //[Column(TypeName = "varchar")]
        //[StringLength(50)]
        //public string Name { get; set; }

        //public DateOnly HiringDate { get; set; }
        //[InverseProperty(nameof(Entities.Student.department))]
        //public ICollection<Student> students { get; set; } = new HashSet<Student>();


        //[InverseProperty(nameof(Entities.Instructor.department))]
        //public ICollection<Instructor> instructors { get; set; } = new HashSet<Instructor>();

        ////one to one
        //[ForeignKey(nameof(Instructor))]
        //public int? InstructorID { get; set; }
        //[InverseProperty(nameof(Entities.Instructor.DepartmentManager))]
        //public Instructor Instructor { get; set; } 
        #endregion

      
        public int ID { get; set; }

        public string Name { get; set; }

        public DateOnly HiringDate { get; set; }
        public ICollection<Student>? students { get; set; } = new HashSet<Student>();


        public ICollection<Instructor> instructors { get; set; } = new HashSet<Instructor>();

        //one to one
        public int Ins_ID { get; set; }
        public Instructor Instructor { get; set; }

    }
}
