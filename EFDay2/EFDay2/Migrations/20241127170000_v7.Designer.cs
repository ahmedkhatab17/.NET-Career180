﻿// <auto-generated />
using System;
using EFDay2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDay2.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20241127170000_v7")]
    partial class v7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFDay2.Models.Department", b =>
                {
                    b.Property<int>("deptid")
                        .HasColumnType("int");

                    b.Property<string>("deptname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("deptid");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EFDay2.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("fullname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("hiredate")
                        .HasColumnType("date");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("salary")
                        .HasColumnType("money")
                        .HasColumnName("netsalary");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}