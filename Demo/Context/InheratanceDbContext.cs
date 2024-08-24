using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Context
{
    internal class InheratanceDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = InhertanceG04; Trusted_Connection = True; TrustServerCertificate = True", optin => optin.UseDateOnlyTimeOnly());



            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullTimeEmployee>()
                .Property(p => p.Salary)
                .HasColumnType("decimal(12,2)");

            modelBuilder.Entity<PartialTimeEmployee>()
                .Property(p => p.HourRate)
                .HasColumnType("decimal(12,2)");



            //TPH
            //modelBuilder.Entity<PartialTimeEmployee>().HasBaseType<Person>();
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Person>();



            base.OnModelCreating(modelBuilder);



        }

        //public DbSet<Person> person { get; set; }

        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartialTimeEmployee> PartialTimeEmployees { get; set; }


    }
}
