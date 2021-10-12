﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Dominio.Directivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId")
                        .IsUnique();

                    b.ToTable("Directivos");
                });

            modelBuilder.Entity("Dominio.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("SueldoBruto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Dominio.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CIF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Dominio.Cliente", b =>
                {
                    b.HasOne("Dominio.Empresa", "EmpRef")
                        .WithMany("ClienteLista")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Persona", "PerRef")
                        .WithOne("CliRef")
                        .HasForeignKey("Dominio.Cliente", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmpRef");

                    b.Navigation("PerRef");
                });

            modelBuilder.Entity("Dominio.Directivo", b =>
                {
                    b.HasOne("Dominio.Empleado", "EmpleadoRef")
                        .WithOne("DirRef")
                        .HasForeignKey("Dominio.Directivo", "EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmpleadoRef");
                });

            modelBuilder.Entity("Dominio.Empleado", b =>
                {
                    b.HasOne("Dominio.Empresa", "EmpresaRef")
                        .WithMany("EmpleadoLista")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Persona", "PersonaRef")
                        .WithOne("EmpRef")
                        .HasForeignKey("Dominio.Empleado", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmpresaRef");

                    b.Navigation("PersonaRef");
                });

            modelBuilder.Entity("Dominio.Empleado", b =>
                {
                    b.Navigation("DirRef");
                });

            modelBuilder.Entity("Dominio.Empresa", b =>
                {
                    b.Navigation("ClienteLista");

                    b.Navigation("EmpleadoLista");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Navigation("CliRef");

                    b.Navigation("EmpRef");
                });
#pragma warning restore 612, 618
        }
    }
}
