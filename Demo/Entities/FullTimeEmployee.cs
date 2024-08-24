using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class FullTimeEmployee : Person
    {
        public Decimal Salary { get; set; }

        public DateOnly Hirdate { get; set; }

         
    }
}
