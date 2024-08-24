﻿// <auto-generated />
using System;
using Demo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo.Migrations
{
    [DbContext(typeof(CompanyG04dbcontext))]
    partial class CompanyG04dbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demo.Entities.Department", b =>
                {
                    b.Property<int>("DeptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptID"), 10L, 10);

                    b.Property<DateOnly>("CreationDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("date")
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("DepartmentName");

                    b.HasKey("DeptID");

                    b.ToTable("Department", "dbo");
                });

            modelBuilder.Entity("Demo.Entities.Emploee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Cairo");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentDeptID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Salary")
                        .HasColumnType("money");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentDeptID");

                    b.ToTable("Emploeyes");
                });

            modelBuilder.Entity("Demo.Entities.Progect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Demo.Entities.Emploee", b =>
                {
                    b.HasOne("Demo.Entities.Department", "Department")
                        .WithMany("Emploees")
                        .HasForeignKey("DepartmentDeptID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Demo.Entities.Department", b =>
                {
                    b.Navigation("Emploees");
                });
#pragma warning restore 612, 618
        }
    }
}
