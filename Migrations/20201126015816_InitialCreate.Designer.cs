﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETCOREM3_CodeFirst.Models;

namespace NETCOREM3_CodeFirst.Migrations
{
    [DbContext(typeof(ERPDBContext))]
    [Migration("20201126015816_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NETCOREM3_CodeFirst.Models.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("correoElectronico")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<string>("nombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("id");

                    b.ToTable("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
