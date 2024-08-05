﻿// <auto-generated />
using System;
using MagicVilla_API.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_API.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    partial class AplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_API.modelos.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagenURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetrosCuadrados")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Ocupantes")
                        .HasColumnType("int");

                    b.Property<double>("Tarifa")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenidad = "",
                            Detalle = "Explicación de la villa",
                            FechaActualizacion = new DateTime(2024, 8, 4, 12, 22, 40, 420, DateTimeKind.Local).AddTicks(3518),
                            FechaCreacion = new DateTime(2024, 8, 4, 12, 22, 40, 420, DateTimeKind.Local).AddTicks(3466),
                            ImagenURL = "",
                            MetrosCuadrados = 120,
                            Nombre = "Villa Real",
                            Ocupantes = 5,
                            Tarifa = 120.0
                        },
                        new
                        {
                            Id = 2,
                            Amenidad = "",
                            Detalle = "Explicación de la degunda",
                            FechaActualizacion = new DateTime(2024, 8, 4, 12, 22, 40, 420, DateTimeKind.Local).AddTicks(3522),
                            FechaCreacion = new DateTime(2024, 8, 4, 12, 22, 40, 420, DateTimeKind.Local).AddTicks(3521),
                            ImagenURL = "",
                            MetrosCuadrados = 110,
                            Nombre = "Villa Segunda",
                            Ocupantes = 3,
                            Tarifa = 100.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
