﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaBancoBack.Context;

#nullable disable

namespace SistemaBancoBack.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaBancoBack.Models.Cliente", b =>
                {
                    b.Property<int>("CodigoCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoCliente"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("LimiteCredito")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NumeroTarjeta")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<decimal>("SaldoDisponible")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("CodigoCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SistemaBancoBack.Models.Configuracion", b =>
                {
                    b.Property<int>("CodigoConfiguracion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoConfiguracion"));

                    b.Property<decimal>("PorcentajeInteres")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("PorcentajeSaldoMinimo")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("CodigoConfiguracion");

                    b.ToTable("Configuracion");
                });

            modelBuilder.Entity("SistemaBancoBack.Models.TipoTransaccion", b =>
                {
                    b.Property<int>("CodigoTipoTransaccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoTipoTransaccion"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CodigoTipoTransaccion");

                    b.ToTable("TipoTransaccion");
                });

            modelBuilder.Entity("SistemaBancoBack.Models.Transaccion", b =>
                {
                    b.Property<int>("CodigoTransaccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoTransaccion"));

                    b.Property<int>("CodigoCliente")
                        .HasColumnType("int");

                    b.Property<int>("CodigoTipoTransaccion")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("CodigoTransaccion");

                    b.HasIndex("CodigoCliente");

                    b.HasIndex("CodigoTipoTransaccion");

                    b.ToTable("Transaccion");
                });

            modelBuilder.Entity("SistemaBancoBack.Models.Transaccion", b =>
                {
                    b.HasOne("SistemaBancoBack.Models.Cliente", "Cliente")
                        .WithMany("Transacciones")
                        .HasForeignKey("CodigoCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaBancoBack.Models.TipoTransaccion", "TipoTransaccion")
                        .WithMany("Transacciones")
                        .HasForeignKey("CodigoTipoTransaccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TipoTransaccion");
                });

            modelBuilder.Entity("SistemaBancoBack.Models.Cliente", b =>
                {
                    b.Navigation("Transacciones");
                });

            modelBuilder.Entity("SistemaBancoBack.Models.TipoTransaccion", b =>
                {
                    b.Navigation("Transacciones");
                });
#pragma warning restore 612, 618
        }
    }
}
