﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestEducationCenterUoW.Data.Contexts;

namespace TestEducationUow.Data.Migrations
{
    [DbContext(typeof(EducationCenterDbContext))]
    partial class EducationCenterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Courses.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Departments.EmployeeSalary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uuid");

                    b.Property<int>("PaymentType")
                        .HasColumnType("integer");

                    b.Property<decimal>("Salary")
                        .HasColumnType("numeric");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeSalaries");
                });

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Groups.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.Property<string>("NameRu")
                        .HasColumnType("text");

                    b.Property<string>("NameUz")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Students.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uuid");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Teachers.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("TestEducationUow.Domain.Entities.Departments.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Courses.Course", b =>
                {
                    b.HasOne("TestEducationCenterUoW.Domain.Entities.Teachers.Teacher", null)
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Departments.EmployeeSalary", b =>
                {
                    b.HasOne("TestEducationUow.Domain.Entities.Departments.Employee", null)
                        .WithMany("EmployeeSalaries")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Groups.Group", b =>
                {
                    b.HasOne("TestEducationCenterUoW.Domain.Entities.Courses.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("TestEducationCenterUoW.Domain.Entities.Teachers.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Students.Student", b =>
                {
                    b.HasOne("TestEducationCenterUoW.Domain.Entities.Groups.Group", null)
                        .WithMany("Students")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Groups.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("TestEducationCenterUoW.Domain.Entities.Teachers.Teacher", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("TestEducationUow.Domain.Entities.Departments.Employee", b =>
                {
                    b.Navigation("EmployeeSalaries");
                });
#pragma warning restore 612, 618
        }
    }
}
