using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement.Entities
{
    internal class Instructor
    {
        #region by convintion
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public decimal Salary { get; set; }

        //public string Adress { get; set; }

        //public decimal HourRateBonous { get; set; }

        //public Department department { get; set; }
        //public ICollection<Course> courses { get; set; } = new HashSet<Course>(); 


        #endregion
        #region dataannotation
        //[Key]
        //public int ID { get; set; }
        //[Column(TypeName = "varchar")]
        //[StringLength(50)]
        //public string Name { get; set; }
        //[Column(TypeName = "varchar")]
        //[StringLength(50)]
        //public decimal Salary { get; set; }

        //[Column(TypeName = "varchar")]
        //[StringLength(50)]
        //public string Adress { get; set; }

        //[Column(TypeName ="decimal(12,2)")]
        //public decimal HourRateBonous { get; set; }
        //[ForeignKey(nameof(Entities.Department.ID))]
        //public int Dept_ID { get; set; }
        //[InverseProperty(nameof(Entities.Department.instructors))]
        //public Department department { get; set; }



        ////one to one
        //[InverseProperty(nameof(Entities.Department.Instructor))]
        //public Department DepartmentManager { get; set; }


        //[InverseProperty(nameof(Entities.Course.instructors))]
        //public ICollection<Course> courses { get; set; } = new HashSet<Course>(); 
        #endregion

      
        public int ID { get; set; }
     
        public string Name { get; set; }
    
        public decimal Salary { get; set; }

   
        public string Adress { get; set; }

        public decimal HourRateBonous { get; set; }
        public int? Dept_ID { get; set; }
        public Department? department { get; set; }



        //one to one
        public Department? DepartmentManager { get; set; }


        public ICollection<Course_Inst>? course_Insts { get; set; } = new HashSet<Course_Inst>();

    }
}
