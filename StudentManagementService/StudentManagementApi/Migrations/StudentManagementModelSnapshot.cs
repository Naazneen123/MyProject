﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using StudentService.Data;
using System;

namespace StudentManagementApi.Migrations
{
    [DbContext(typeof(StudentManagement))]
    partial class StudentManagementModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentService.Domain.ProgramType", b =>
                {
                    b.Property<int>("ProgramTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProgramTypeName");

                    b.HasKey("ProgramTypeId");

                    b.ToTable("ProgramType");
                });

            modelBuilder.Entity("StudentService.Domain.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("FName");

                    b.Property<string>("LName");

                    b.Property<int>("ProgramTypeId");

                    b.HasKey("StudentId");

                    b.HasIndex("ProgramTypeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentService.Domain.Student", b =>
                {
                    b.HasOne("StudentService.Domain.ProgramType", "ProgramType")
                        .WithMany("Students")
                        .HasForeignKey("ProgramTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
