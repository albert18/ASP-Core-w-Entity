﻿// <auto-generated />
using System;
using EFCoreClassdesign;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreClassdesign.Migrations
{
    [DbContext(typeof(EFCoreQorganizationDb))]
    [Migration("20190313011133_EFCoreSchool_1")]
    partial class EFCoreSchool_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreClassdesign.ClassStandard", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName");

                    b.Property<string>("Description");

                    b.HasKey("ClassId");

                    b.ToTable("ClassStandards");
                });

            modelBuilder.Entity("EFCoreClassdesign.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassStandardClassId");

                    b.Property<string>("Gender");

                    b.Property<string>("StudentName");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassStandardClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFCoreClassdesign.Student", b =>
                {
                    b.HasOne("EFCoreClassdesign.ClassStandard", "ClassStandard")
                        .WithMany("Students")
                        .HasForeignKey("ClassStandardClassId");
                });
#pragma warning restore 612, 618
        }
    }
}
