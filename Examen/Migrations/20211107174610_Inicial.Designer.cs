﻿// <auto-generated />
using System;
using Examen.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Examen.Migrations
{
    [DbContext(typeof(Conn))]
    [Migration("20211107174610_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Examen.Models.AlumnosModel", b =>
                {
                    b.Property<int>("IDAlumno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDAlumno");

                    b.ToTable("Tbl_Alumnos");
                });

            modelBuilder.Entity("Examen.Models.MateriasModel", b =>
                {
                    b.Property<int>("IDMateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreMateria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDMateria");

                    b.ToTable("Tbl_Materias");
                });

            modelBuilder.Entity("Examen.Models.NotasModel", b =>
                {
                    b.Property<int>("IDNota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IDAlumno")
                        .HasColumnType("int");

                    b.Property<int?>("IDMateria")
                        .HasColumnType("int");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("IDNota");

                    b.HasIndex("IDAlumno");

                    b.HasIndex("IDMateria");

                    b.ToTable("Tbl_Notas");
                });

            modelBuilder.Entity("Examen.Models.NotasModel", b =>
                {
                    b.HasOne("Examen.Models.AlumnosModel", "Alumno")
                        .WithMany()
                        .HasForeignKey("IDAlumno");

                    b.HasOne("Examen.Models.MateriasModel", "Materia")
                        .WithMany()
                        .HasForeignKey("IDMateria");

                    b.Navigation("Alumno");

                    b.Navigation("Materia");
                });
#pragma warning restore 612, 618
        }
    }
}
