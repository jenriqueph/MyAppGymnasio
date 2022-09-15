﻿// <auto-generated />
using System;
using AppGimnasio.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppGimnasio.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220915151923_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AppGimnasio.App.Dominio.IngresoGimnasio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Bloqueado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("IngresosGimnasio");
                });

            modelBuilder.Entity("AppGimnasio.App.Dominio.Mensualidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Bloqueado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<double>("ValorMensualidad")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Mensualidades");
                });

            modelBuilder.Entity("AppGimnasio.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Bloqueado")
                        .HasColumnType("bit");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NumeroIdentificacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("TipoDocIdentificacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("AppGimnasio.App.Dominio.Rutina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Bloqueado")
                        .HasColumnType("bit");

                    b.Property<string>("Cardio")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Ejercicio1")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Ejercicio2")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Ejercicio3")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Ejercicio4")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Ejercicio5")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Rutinas");
                });

            modelBuilder.Entity("AppGimnasio.App.Dominio.Cliente", b =>
                {
                    b.HasBaseType("AppGimnasio.App.Dominio.Persona");

                    b.Property<int?>("IngresoGimnasioId")
                        .HasColumnType("int");

                    b.Property<int?>("MensualidadId")
                        .HasColumnType("int");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RutinaId")
                        .HasColumnType("int");

                    b.HasIndex("IngresoGimnasioId");

                    b.HasIndex("MensualidadId");

                    b.HasIndex("RutinaId");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("AppGimnasio.App.Dominio.Entrenador", b =>
                {
                    b.HasBaseType("AppGimnasio.App.Dominio.Persona");

                    b.Property<string>("NumeroCuenta")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasDiscriminator().HasValue("Entrenador");
                });

            modelBuilder.Entity("AppGimnasio.App.Dominio.Cliente", b =>
                {
                    b.HasOne("AppGimnasio.App.Dominio.IngresoGimnasio", "IngresoGimnasio")
                        .WithMany()
                        .HasForeignKey("IngresoGimnasioId");

                    b.HasOne("AppGimnasio.App.Dominio.Mensualidad", "Mensualidad")
                        .WithMany()
                        .HasForeignKey("MensualidadId");

                    b.HasOne("AppGimnasio.App.Dominio.Rutina", "Rutina")
                        .WithMany()
                        .HasForeignKey("RutinaId");

                    b.Navigation("IngresoGimnasio");

                    b.Navigation("Mensualidad");

                    b.Navigation("Rutina");
                });
#pragma warning restore 612, 618
        }
    }
}