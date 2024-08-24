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
    internal class TopConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {

            builder.HasKey(p => p.ID)
                            ;

            builder.Property(p => p.ID).UseIdentityColumn(1, 1);

            builder.Property(d => d.Name)
       .HasColumnType("varchar")
       .HasMaxLength(50);


        }
    }
}
