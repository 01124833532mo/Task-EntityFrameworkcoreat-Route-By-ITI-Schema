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
    internal class StudentConfigure : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.HasKey(p => p.ID);

            builder.Property(d => d.Fname)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder.Property(p => p.ID).UseIdentityColumn(1, 1);

            builder.Property(d => d.Lname)
          .HasColumnType("varchar")
          .HasMaxLength(50);
            builder.Property(d => d.Lname)
         .HasColumnType("varchar")
         .HasMaxLength(50);

            builder.Property(d => d.Adress)
         .HasColumnType("varchar")
         .HasMaxLength(50);

            builder.HasOne(p=>p.department)
                .WithMany(p=>p.students)
                .HasForeignKey(p=>p.Dept_id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p=>p.student_Cours)
                .WithOne(p=>p.student)
                .HasForeignKey(p => p.Stud_ID)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);




        }
    }
}
