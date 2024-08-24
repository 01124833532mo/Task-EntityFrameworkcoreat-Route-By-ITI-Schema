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
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Emploee>
    {
        public void Configure(EntityTypeBuilder<Emploee> builder)
        {
            builder.HasKey(E => E.Id);

            builder.Property(E => E.Id).UseIdentityColumn(1, 1);

            builder.Property(e => e.Adress)
                .IsRequired()
                .HasDefaultValue("Cairo");


        }
    }
}
