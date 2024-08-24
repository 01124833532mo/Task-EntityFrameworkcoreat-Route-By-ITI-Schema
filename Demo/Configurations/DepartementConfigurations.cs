using Demo.Context;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{
    internal class DepartementConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> E)
        {

            E.ToTable("Department", "dbo") // pk
                         .HasKey(d => d.DeptID);
            E.Property(d => d.DeptID).UseIdentityColumn(10, 10);


            E
                     .Property(d => d.Name)
                     .HasColumnName("DepartmentName")
                     .HasMaxLength(50)
                     .HasColumnType(SQLdatatype.Varchar)
                     ////.HasAnnotation("MaxLength",50)
                     ;

            E
                         .Property(d => d.CreationDate)
                         .HasComputedColumnSql("GETDATE()");

            E.
                HasMany(e => e.Emploees)
                .WithOne(d => d.Department)
                .HasForeignKey(e => e.DepartmentDeptID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
