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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            //builder.HasKey(p => p.ID);

            //builder.Property(p => p.ID).UseIdentityColumn(10, 10);

            //builder.Property(d => d.Name)
            //.HasColumnType("varchar")
            //.HasMaxLength(50);


            //builder.Property(p => p.HiringDate).HasComputedColumnSql("GETDATE()");

            //builder.HasOne(p => p.Instructor)
            //   .WithOne(p => p.DepartmentManager)
            //   .HasForeignKey<Department>(p => p.Ins_ID)
            //   .OnDelete(DeleteBehavior.NoAction);


            //builder.HasMany(p=>p.instructors).WithOne(p=>p.department)
            //    .HasForeignKey(p=>p.Dept_ID)
            //    .IsRequired(true)
            //     .OnDelete(DeleteBehavior.NoAction);

            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).UseIdentityColumn(10, 10);

            builder.Property(d => d.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(p => p.HiringDate).HasComputedColumnSql("GETDATE()");

            builder.HasOne(p => p.Instructor)
                   .WithOne(p => p.DepartmentManager)
                   .HasForeignKey<Department>(d=>d.Ins_ID)
                   .OnDelete(DeleteBehavior.NoAction); 

            builder.HasMany(p => p.instructors)
                   .WithOne(p => p.department)
                   .HasForeignKey(p => p.Dept_ID)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.NoAction);



        }
    }
}
