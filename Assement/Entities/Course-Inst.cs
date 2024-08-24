using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement.Entities
{
    internal class Course_Inst
    {
      

        public int? Inst_ID { get; set; }

        public int? Course_ID { get; set; }

        public string evaluate { get; set; }

        public Instructor? instructor { get; set; }

        public Course? course { get; set; }

    }
}
