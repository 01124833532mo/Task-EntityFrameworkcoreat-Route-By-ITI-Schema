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
    internal class InstracturConfigure : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {

            //     builder.HasKey(p => p.ID);
            //     builder.Property(p => p.ID).UseIdentityColumn(1, 1);

            //     builder.Property(d => d.Name)
            //.HasColumnType("varchar")
            //.HasMaxLength(50);

            //     builder.Property(d => d.Adress)
            //.HasColumnType("varchar")
            //.HasMaxLength(50);

            //     builder.Property(d => d.Salary)
            //.HasColumnType("decimal(12,2)");

            //     builder.HasMany(p => p.course_Insts).WithOne(p => p.instructor)
            //         .HasForeignKey(p => p.Inst_ID)
            //         .IsRequired(false)
            //         .OnDelete(DeleteBehavior.NoAction);


            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).UseIdentityColumn(1, 1);

            builder.Property(d => d.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(d => d.Adress)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(d => d.Salary)
                   .HasColumnType("decimal(12,2)");

            builder.HasMany(p => p.course_Insts)
                   .WithOne(p => p.instructor)
                   .HasForeignKey(p => p.Inst_ID)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
