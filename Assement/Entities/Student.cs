using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement.Entities
{
    internal class Student
    {
        #region by convintion
        //public int ID { get; set; }
        //public string Fname { get; set; }
        //public string Lname { get; set; }

        //public string Adress { get; set; }

        //public int Age { get; set; }

        //public Department? department { get; set; }

        //public ICollection<Course> courses { get; set; } = new HashSet<Course>();

        #endregion

        #region dataannotation
        //[Key]
        //public int ID { get; set; }
        //[Column(TypeName ="varchar")]
        //[StringLength(50)]
        //public string Fname { get; set; }
        //[Column(TypeName = "varchar")]
        //[StringLength(50)]
        //public string Lname { get; set; }
        //[Column(TypeName = "varchar")]
        //[StringLength(50)]
        //public string Adress { get; set; }
        //[Range(11,44)]
        //public int Age { get; set; }
        //[ForeignKey(nameof(Entities.Department.ID))]
        //public int Dept_id { get; set; }
        //[InverseProperty(nameof(Entities.Department.students))]
        //public Department? department { get; set; }
        //[InverseProperty(nameof(Entities.Course.students))]
        //public ICollection<Course> courses { get; set; } = new HashSet<Course>(); 
        #endregion

       

        public int ID { get; set; }
       
        public string Fname { get; set; }
   
        public string Lname { get; set; }
    
        public string Adress { get; set; }
        public int Age { get; set; }
        public int Dept_id { get; set; }
        public Department department { get; set; }
        public ICollection<Student_Cours> student_Cours { get; set; } = new HashSet<Student_Cours>();


    }
}
