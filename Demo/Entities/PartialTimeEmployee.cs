using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    internal class PartialTimeEmployee :Person
    {
        public decimal HourRate { get; set; }

        public int? CountOfRate { get; set; }


    }
}
