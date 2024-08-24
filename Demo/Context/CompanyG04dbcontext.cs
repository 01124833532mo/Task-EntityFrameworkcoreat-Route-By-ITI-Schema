using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Context
{
   static class SQLdatatype
    {
        public static string Varchar => "varchar";



    }
    internal class CompanyG04dbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = CampanyG04; Trusted_Connection = True; TrustServerCertificate = True",optin=>optin.UseDateOnlyTimeOnly());
        }

        public DbSet<Emploee> Emploeyes { get; set; }
        //public DbSet<Department> Department { get; set; }
        public DbSet<Progect> Project { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Emploee>()
            //    .Property("Adress").HasDefaultValue("cairo");

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
         
            modelBuilder.Entity<Student>()
                .HasMany(s=>s.Courses)
                .WithOne(sc=>sc.Student)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Course>()
                .HasMany(c=>c.Students)
                .WithOne(sc=>sc.Course).IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StudentCourses>()
                .HasKey(p => new { p.StudentId, p.CourseId });

            base.OnModelCreating(modelBuilder);
        }


    }
}
