﻿// <auto-generated />
using System;
using ExtCore.Data.EntityFramework.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.WebApp.Migrations
{
    [DbContext(typeof(StorageContext))]
    partial class StorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Employees.Data.Entities.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<string>("ReceiverName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("Employees.Data.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Employees.Data.Entities.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastEducation")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Employees.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankAccountId");

                    b.Property<DateTimeOffset>("BirthDate");

                    b.Property<string>("BirthLocation")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.Property<decimal>("CashOutLeave");

                    b.Property<int>("ComplimentLeaveTotal");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("CurrentAddress")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.Property<int>("DebtHour");

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<int>("DepartmentId");

                    b.Property<int>("EducationId");

                    b.Property<string>("EmergencyContactName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("EmergencyContactNumber")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("EmergencyContactRelationship")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("EmployeeRoleId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("Gender");

                    b.Property<int>("Grading");

                    b.Property<int>("GradingTitleId");

                    b.Property<int>("IdentityCardNumber");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("InitialName")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset>("JoinDate");

                    b.Property<string>("KTPAddress")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.Property<string>("LastEducation");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("LeaveTotal");

                    b.Property<string>("LineManager")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("MaritalStatus");

                    b.Property<decimal>("MedicalPlafon");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<string>("NPWP");

                    b.Property<string>("NPWPAddress");

                    b.Property<string>("NoSurat")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("OfficeEmail")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset>("PassProbation");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("PersonalEmail")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("ReasonLeaving")
                        .HasMaxLength(225);

                    b.Property<int>("ReligionId");

                    b.Property<int>("RemainingComplimentLeave");

                    b.Property<int>("RemainingLeave");

                    b.Property<int>("RemainingSickLeave");

                    b.Property<DateTimeOffset>("ResignationDate");

                    b.Property<decimal>("Salary");

                    b.Property<int>("SickLeaveTotal");

                    b.Property<string>("SpecialNotes")
                        .HasMaxLength(225);

                    b.Property<int>("StatusWorker");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTimeOffset>("TransferDate");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("WorkPlacementId");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EducationId");

                    b.HasIndex("EmployeeRoleId");

                    b.HasIndex("GradingTitleId");

                    b.HasIndex("ReligionId");

                    b.HasIndex("WorkPlacementId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Employees.Data.Entities.EmployeeRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<string>("PositionTitle")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Employees.Data.Entities.GradingTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<string>("GradingName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("GradingTitles");
                });

            modelBuilder.Entity("Employees.Data.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Employees.Data.Entities.Religion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<string>("ReligionName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Religions");
                });

            modelBuilder.Entity("Employees.Data.Entities.WorkPlacement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<string>("OfficeAddress")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.Property<string>("WorkLocation")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.HasKey("Id");

                    b.ToTable("Placements");
                });

            modelBuilder.Entity("Employees.Data.Entities.Employee", b =>
                {
                    b.HasOne("Employees.Data.Entities.BankAccount", "BankAccount")
                        .WithMany()
                        .HasForeignKey("BankAccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Employees.Data.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Employees.Data.Entities.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Employees.Data.Entities.EmployeeRole", "EmployeeRole")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeRoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Employees.Data.Entities.GradingTitle", "GradingPosition")
                        .WithMany()
                        .HasForeignKey("GradingTitleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Employees.Data.Entities.Religion", "Faith")
                        .WithMany()
                        .HasForeignKey("ReligionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Employees.Data.Entities.WorkPlacement", "WorkPlacement")
                        .WithMany()
                        .HasForeignKey("WorkPlacementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Employees.Data.Entities.EmployeeRole", b =>
                {
                    b.HasOne("Employees.Data.Entities.Group", "Group")
                        .WithMany("EmployeeRoles")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
