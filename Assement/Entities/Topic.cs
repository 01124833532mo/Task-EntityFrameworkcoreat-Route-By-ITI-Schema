﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement.Entities
{
    internal class Topic
    {
        #region by convintion
        //public int ID { get; set; } 

        //public string Name { get; set; }

        //public ICollection<Course> courses { get; set; } = new HashSet<Course>(); 
        #endregion

        #region dataannotation
        //[Key]
        //public int ID { get; set; }
        //[Column(TypeName = "varchar")]
        //[StringLength(50)]
        //public string Name { get; set; }

        //[InverseProperty(nameof(Entities.Course.topic))]
        //public ICollection<Course> courses { get; set; } = new HashSet<Course>(); 
        #endregion

        //[Key]
        //public int ID { get; set; }
        //[Column(TypeName = "varchar")]
        //[StringLength(50)]
        //public string Name { get; set; }

        //[InverseProperty(nameof(Entities.Course.topic))]
        //public ICollection<Course> courses { get; set; } = new HashSet<Course>();


        public int ID { get; set; }
  
        public string Name { get; set; }

        public ICollection<Course>? courses { get; set; } = new HashSet<Course>();
    }
}
