using Assement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement.Configrations
{
    internal class StudentCoursConfige : IEntityTypeConfiguration<Student_Cours>
    {
        public void Configure(EntityTypeBuilder<Student_Cours> builder)
        {
            builder.HasKey(p => new { p.Stud_ID, p.Cours_ID });

            builder.HasOne(p => p.course)
                    .WithMany(p => p.student_Cours)
                    .HasForeignKey(p=>p.Cours_ID)
                    .IsRequired(true)
                    .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
