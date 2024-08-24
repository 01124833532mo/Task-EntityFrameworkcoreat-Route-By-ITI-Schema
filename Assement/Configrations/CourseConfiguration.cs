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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.Duration).HasComputedColumnSql("GETDATE()");

            builder.HasOne(p => p.topic).WithMany(p => p.courses)
                .HasForeignKey(p => p.Top_ID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.course_Insts).WithOne(p => p.course)
               .HasForeignKey(p =>p.Course_ID)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
