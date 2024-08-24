using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    //EF core support 4 ways for mapping
    internal class Emploee
    {
        #region By convention
        //public int Id { get; set; } // public numeric property named "Id" || "EmpleeId" --> pk Identity (1,1)

        //public string EmpName { get; set; } // referencetype : allow null [optinal]

        //public double Salary { get; set; } // value type : not allow null [requerd]

        //public int? Age { get; set; } // nullable : allow null [optinal ] 
        #endregion
        // by dataAnotation

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // public numeric property named "Id" || "EmpleeId" --> pk Identity (1,1)
        [Required]
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string EmpName { get; set; } // referencetype : allow null [optinal]
        [DataType(DataType.Currency)]

        [Column(TypeName ="money")]
        public double Salary { get; set; } // value type : not allow null [requerd]

        [Range(15,20)]
        public int? Age { get; set; } // nullable : allow null [optinal ] 
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }

        public string Adress    { get; set; }

        //[ForeignKey("Department")]

        //[ForeignKey(nameof(Entities.Department.DeptID))]
        public int? DepartmentDeptID { get; set; }

        //[InverseProperty(nameof(Entities.Department.Emploees))]
        public Department? Department { get; set; }
    }
}
