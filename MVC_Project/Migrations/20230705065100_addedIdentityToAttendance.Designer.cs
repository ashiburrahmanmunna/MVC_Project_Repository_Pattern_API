﻿// <auto-generated />
using System;
using MVC_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230705065100_addedIdentityToAttendance")]
    partial class addedIdentityToAttendance
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_Project.Models.Attendance", b =>
                {
                    b.Property<string>("ComId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("EmpId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("dtDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AttStatus")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceId"));

                    b.Property<TimeSpan>("InTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("OutTime")
                        .HasColumnType("time");

                    b.HasKey("ComId", "EmpId", "dtDate");

                    b.HasIndex("EmpId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("MVC_Project.Models.AttendanceSummary", b =>
                {
                    b.Property<string>("ComId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("EmpId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("dtYear")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("dtMonth")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("Absent")
                        .HasColumnType("int");

                    b.Property<int>("Holiday")
                        .HasColumnType("int");

                    b.Property<int>("Late")
                        .HasColumnType("int");

                    b.Property<int>("MonthDays")
                        .HasColumnType("int");

                    b.Property<int>("Present")
                        .HasColumnType("int");

                    b.HasKey("ComId", "EmpId", "dtYear", "dtMonth");

                    b.HasIndex("EmpId");

                    b.ToTable("AttendanceSummaries");
                });

            modelBuilder.Entity("MVC_Project.Models.Company", b =>
                {
                    b.Property<string>("ComId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Basic")
                        .HasColumnType("int");

                    b.Property<string>("ComName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Hrent")
                        .HasColumnType("int");

                    b.Property<bool>("IsInactive")
                        .HasColumnType("bit");

                    b.Property<int>("Medical")
                        .HasColumnType("int");

                    b.HasKey("ComId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("MVC_Project.Models.Department", b =>
                {
                    b.Property<string>("DeptId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ComId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("DeptId");

                    b.HasIndex("ComId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MVC_Project.Models.Designation", b =>
                {
                    b.Property<string>("DesigId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ComId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("DesigName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("DesigId");

                    b.HasIndex("ComId");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("MVC_Project.Models.Employee", b =>
                {
                    b.Property<string>("EmpId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal?>("Basic")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ComId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("DeptId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("DesigId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("EmpCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Gross")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("HRent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Medical")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Others")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShiftId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("dtJoin")
                        .HasColumnType("datetime2");

                    b.HasKey("EmpId");

                    b.HasIndex("ComId");

                    b.HasIndex("DeptId");

                    b.HasIndex("DesigId");

                    b.HasIndex("ShiftId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MVC_Project.Models.Salary", b =>
                {
                    b.Property<string>("ComId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("EmpId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("dtYear")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("dtMonth")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<decimal>("AbsentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Basic")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Gross")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HRent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<decimal>("Medical")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Others")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ComId", "EmpId", "dtYear", "dtMonth");

                    b.HasIndex("EmpId");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("MVC_Project.Models.Shift", b =>
                {
                    b.Property<string>("ShiftId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ComId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("ShiftIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ShiftLate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShiftName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ShiftOut")
                        .HasColumnType("datetime2");

                    b.HasKey("ShiftId");

                    b.HasIndex("ComId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("MVC_Project.Models.Attendance", b =>
                {
                    b.HasOne("MVC_Project.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MVC_Project.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmpId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("MVC_Project.Models.AttendanceSummary", b =>
                {
                    b.HasOne("MVC_Project.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MVC_Project.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmpId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("MVC_Project.Models.Department", b =>
                {
                    b.HasOne("MVC_Project.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("MVC_Project.Models.Designation", b =>
                {
                    b.HasOne("MVC_Project.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("MVC_Project.Models.Employee", b =>
                {
                    b.HasOne("MVC_Project.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Project.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Project.Models.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Project.Models.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Department");

                    b.Navigation("Designation");

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("MVC_Project.Models.Salary", b =>
                {
                    b.HasOne("MVC_Project.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MVC_Project.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmpId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("MVC_Project.Models.Shift", b =>
                {
                    b.HasOne("MVC_Project.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
