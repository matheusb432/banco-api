﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaBanco.Infra;

namespace BancoAPI.Infra.Data.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20211003204258_AddingSeddingData")]
    partial class AddingSeddingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SistemaBanco.Domain.Afiliado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTimeOffset>("DataDeRegistro")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<int>("VendasNoMes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Afiliados");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Cargo = "Vendedor 01",
                            Cpf = "123.456.777-00",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(876), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Afiliado 01",
                            VendasNoMes = 150
                        },
                        new
                        {
                            Id = 2L,
                            Cargo = "Vendedor 02",
                            Cpf = "777.456.789-00",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(1222), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Afiliado 02",
                            VendasNoMes = 250
                        },
                        new
                        {
                            Id = 3L,
                            Cargo = "Vendedor 03",
                            Cpf = "123.777.789-00",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(1225), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Afiliado 03",
                            VendasNoMes = 400
                        });
                });

            modelBuilder.Entity("SistemaBanco.Domain.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTimeOffset>("DataDeRegistro")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Cpf = "111.456.789-00",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(3735), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Funcionario 01"
                        },
                        new
                        {
                            Id = 2L,
                            Cpf = "123.222.789-00",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(4058), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Funcionario 02"
                        },
                        new
                        {
                            Id = 3L,
                            Cpf = "123.456.333-00",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(4061), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Funcionario 03"
                        },
                        new
                        {
                            Id = 4L,
                            Cpf = "423.456.789-44",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Funcionario 04"
                        },
                        new
                        {
                            Id = 5L,
                            Cpf = "155.556.789-00",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(4065), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Funcionario 05"
                        });
                });

            modelBuilder.Entity("SistemaBanco.Domain.Conta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("ClienteRefId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("DataDeRegistro")
                        .HasColumnType("datetimeoffset");

                    b.Property<double>("Limite")
                        .HasColumnType("float");

                    b.Property<double>("Saldo")
                        .HasColumnType("float");

                    b.Property<string>("TipoConta")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteRefId");

                    b.ToTable("Contas");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ClienteRefId = 1L,
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(6454), new TimeSpan(0, 0, 0, 0, 0)),
                            Limite = 500.0,
                            Saldo = 15000.0,
                            TipoConta = "credit"
                        },
                        new
                        {
                            Id = 2L,
                            ClienteRefId = 2L,
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(7101), new TimeSpan(0, 0, 0, 0, 0)),
                            Limite = 1500.0,
                            Saldo = 20000.0,
                            TipoConta = "debit"
                        },
                        new
                        {
                            Id = 3L,
                            ClienteRefId = 3L,
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(7104), new TimeSpan(0, 0, 0, 0, 0)),
                            Limite = 2500.0,
                            Saldo = 30000.0,
                            TipoConta = "debit"
                        },
                        new
                        {
                            Id = 4L,
                            ClienteRefId = 4L,
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(7106), new TimeSpan(0, 0, 0, 0, 0)),
                            Limite = 200.0,
                            Saldo = 10000.0,
                            TipoConta = "debit"
                        },
                        new
                        {
                            Id = 5L,
                            ClienteRefId = 5L,
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(7107), new TimeSpan(0, 0, 0, 0, 0)),
                            Limite = 300.0,
                            Saldo = 50000.0,
                            TipoConta = "credit"
                        });
                });

            modelBuilder.Entity("SistemaBanco.Domain.Corretora", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTimeOffset>("DataDeRegistro")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsInternacional")
                        .HasColumnType("bit");

                    b.Property<double>("LucroLiquido")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<double>("RendaBruta")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Corretoras");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 134, DateTimeKind.Unspecified).AddTicks(9063), new TimeSpan(0, 0, 0, 0, 0)),
                            IsInternacional = false,
                            LucroLiquido = 35000.5,
                            Nome = "Corretora 01",
                            RendaBruta = 10000000.5
                        },
                        new
                        {
                            Id = 2L,
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 134, DateTimeKind.Unspecified).AddTicks(9867), new TimeSpan(0, 0, 0, 0, 0)),
                            IsInternacional = true,
                            LucroLiquido = 25.0,
                            Nome = "Corretora 02",
                            RendaBruta = 10000.5
                        },
                        new
                        {
                            Id = 3L,
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 134, DateTimeKind.Unspecified).AddTicks(9871), new TimeSpan(0, 0, 0, 0, 0)),
                            IsInternacional = false,
                            LucroLiquido = 525000.0,
                            Nome = "Corretora 03",
                            RendaBruta = 100000000.0
                        });
                });

            modelBuilder.Entity("SistemaBanco.Domain.Funcionario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTimeOffset>("DataDeRegistro")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Cargo = "Atendente",
                            Cpf = "123.456.789-00",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 135, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Funcionario 01"
                        },
                        new
                        {
                            Id = 2L,
                            Cargo = "Chefe",
                            Cpf = "456.456.789-00",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 135, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Funcionario 02"
                        },
                        new
                        {
                            Id = 3L,
                            Cargo = "Analista",
                            Cpf = "789.456.789-00",
                            DataDeRegistro = new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 135, DateTimeKind.Unspecified).AddTicks(8920), new TimeSpan(0, 0, 0, 0, 0)),
                            Nome = "Funcionario 03"
                        });
                });

            modelBuilder.Entity("SistemaBanco.Domain.Conta", b =>
                {
                    b.HasOne("SistemaBanco.Domain.Cliente", null)
                        .WithMany("Contas")
                        .HasForeignKey("ClienteRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaBanco.Domain.Cliente", b =>
                {
                    b.Navigation("Contas");
                });
#pragma warning restore 612, 618
        }
    }
}