using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }


        //[InverseProperty(nameof(Entities.Emploee.Department))]
        public ICollection<Emploee> Emploees { get; set; } = new HashSet<Emploee>();
    }
}
