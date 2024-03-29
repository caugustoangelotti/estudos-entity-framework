﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gtauto_api.Entities;

namespace gtauto_api.Migrations
{
    [DbContext(typeof(GtAutoEfDbContext))]
    [Migration("20220108073803_Alteracao entidade aluguel")]
    partial class Alteracaoentidadealuguel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("gtauto_api.Entities.Aluguel", b =>
                {
                    b.Property<int>("IdAluguel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAluguel")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdFilial")
                        .HasColumnType("int");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("IdVeiculo")
                        .HasColumnType("int");

                    b.HasKey("IdAluguel");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdFilial");

                    b.HasIndex("IdFuncionario");

                    b.HasIndex("IdVeiculo");

                    b.ToTable("Alugueis");

                    b.HasData(
                        new
                        {
                            IdAluguel = 1,
                            DataAluguel = new DateTime(2022, 1, 8, 3, 38, 2, 891, DateTimeKind.Local).AddTicks(4655),
                            IdCliente = 1,
                            IdFilial = 1,
                            IdFuncionario = 2,
                            IdVeiculo = 6
                        },
                        new
                        {
                            IdAluguel = 2,
                            DataAluguel = new DateTime(2022, 1, 8, 3, 38, 2, 892, DateTimeKind.Local).AddTicks(3304),
                            IdCliente = 1,
                            IdFilial = 2,
                            IdFuncionario = 1,
                            IdVeiculo = 3
                        },
                        new
                        {
                            IdAluguel = 3,
                            DataAluguel = new DateTime(2022, 1, 8, 3, 38, 2, 892, DateTimeKind.Local).AddTicks(3352),
                            IdCliente = 1,
                            IdFilial = 2,
                            IdFuncionario = 1,
                            IdVeiculo = 4
                        });
                });

            modelBuilder.Entity("gtauto_api.Entities.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            IdCliente = 1,
                            Cpf = "09758123784",
                            DataNascimento = new DateTime(1960, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "garry@mail.com",
                            Nome = "Garry",
                            Sobrenome = "Kasparov"
                        },
                        new
                        {
                            IdCliente = 2,
                            Cpf = "79857403185",
                            DataNascimento = new DateTime(1997, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "karpov@mail.com",
                            Nome = "Anatoly",
                            Sobrenome = "Karpov"
                        });
                });

            modelBuilder.Entity("gtauto_api.Entities.Devolucao", b =>
                {
                    b.Property<int>("IdDevolucao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdFilial")
                        .HasColumnType("int");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("IdVeiculo")
                        .HasColumnType("int");

                    b.HasKey("IdDevolucao");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdFilial");

                    b.HasIndex("IdFuncionario");

                    b.HasIndex("IdVeiculo");

                    b.ToTable("Devolucoes");

                    b.HasData(
                        new
                        {
                            IdDevolucao = 1,
                            DataDevolucao = new DateTime(2022, 1, 8, 3, 38, 2, 892, DateTimeKind.Local).AddTicks(5455),
                            IdCliente = 1,
                            IdFilial = 1,
                            IdFuncionario = 2,
                            IdVeiculo = 3
                        },
                        new
                        {
                            IdDevolucao = 2,
                            DataDevolucao = new DateTime(2022, 1, 8, 3, 38, 2, 892, DateTimeKind.Local).AddTicks(6568),
                            IdCliente = 1,
                            IdFilial = 2,
                            IdFuncionario = 1,
                            IdVeiculo = 4
                        });
                });

            modelBuilder.Entity("gtauto_api.Entities.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdFilial")
                        .HasColumnType("int");

                    b.Property<int?>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEndereco");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdFilial");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("Enderecos");

                    b.HasData(
                        new
                        {
                            IdEndereco = 1,
                            Bairro = "Centro",
                            Cep = "78118182",
                            Cidade = "Varzea Grande",
                            Complemento = "Entrada pela parte de tras",
                            IdFilial = 1,
                            Numero = "S/N",
                            Referencia = "Proximo escola",
                            Rua = "Av. Central",
                            Uf = "MT"
                        },
                        new
                        {
                            IdEndereco = 2,
                            Bairro = "Boa Esperanca",
                            Cep = "78068300",
                            Cidade = "Cuiaba",
                            Complemento = "",
                            IdFilial = 2,
                            Numero = "1312",
                            Referencia = "Proximo escola",
                            Rua = "Av. Moinho",
                            Uf = "MT"
                        },
                        new
                        {
                            IdEndereco = 3,
                            Bairro = "Ermelino Matarazzo",
                            Cep = "698754320",
                            Cidade = "Sao Paulo",
                            Complemento = "",
                            IdCliente = 1,
                            Numero = "12",
                            Referencia = "Proximo shopping",
                            Rua = "RUA 16",
                            Uf = "SP"
                        },
                        new
                        {
                            IdEndereco = 4,
                            Bairro = "Central",
                            Cep = "74520197",
                            Cidade = "Sinop",
                            Complemento = "",
                            IdCliente = 1,
                            Numero = "315",
                            Referencia = "Proximo casas bahia",
                            Rua = "Av. Doze",
                            Uf = "MT"
                        },
                        new
                        {
                            IdEndereco = 5,
                            Bairro = "Perimetral",
                            Cep = "36874987",
                            Cidade = "Umuarama",
                            Complemento = "",
                            IdCliente = 2,
                            Numero = "5564",
                            Referencia = "",
                            Rua = "121",
                            Uf = "PR"
                        },
                        new
                        {
                            IdEndereco = 6,
                            Bairro = "Grande Terceiro",
                            Cep = "32587410",
                            Cidade = "Campo Grande",
                            Complemento = "",
                            IdFuncionario = 1,
                            Numero = "5",
                            Referencia = "",
                            Rua = "12",
                            Uf = "MS"
                        },
                        new
                        {
                            IdEndereco = 7,
                            Bairro = "Cristo Rei",
                            Cep = "78118218",
                            Cidade = "Varzea Grande",
                            Complemento = "",
                            IdFuncionario = 2,
                            Numero = "12",
                            Referencia = "",
                            Rua = "rua 9",
                            Uf = "MT"
                        });
                });

            modelBuilder.Entity("gtauto_api.Entities.Filial", b =>
                {
                    b.Property<int>("IdFilial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFilial");

                    b.ToTable("Filiais");

                    b.HasData(
                        new
                        {
                            IdFilial = 1,
                            Cnpj = "70603205000147",
                            NomeFantasia = "GtAuto Varzea Grande"
                        },
                        new
                        {
                            IdFilial = 2,
                            Cnpj = "70170979000121",
                            NomeFantasia = "GtAuto Cuiaba"
                        });
                });

            modelBuilder.Entity("gtauto_api.Entities.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdFilial")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFuncionario");

                    b.HasIndex("IdFilial");

                    b.ToTable("Funcionarios");

                    b.HasData(
                        new
                        {
                            IdFuncionario = 1,
                            Cpf = "65412387621",
                            DataNascimento = new DateTime(1975, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tal@mail.com",
                            IdFilial = 2,
                            Nome = "Mikhail",
                            Sobrenome = "Tal"
                        },
                        new
                        {
                            IdFuncionario = 2,
                            Cpf = "97834268712",
                            DataNascimento = new DateTime(1979, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ivanchuck@mail.com",
                            IdFilial = 1,
                            Nome = "Vasyl",
                            Sobrenome = "Ivanchuck"
                        });
                });

            modelBuilder.Entity("gtauto_api.Entities.Telefone", b =>
                {
                    b.Property<int>("IdTelefone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoPais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdFilial")
                        .HasColumnType("int");

                    b.Property<int?>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<string>("NumeroTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTelefone");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdFilial");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("Telefones");

                    b.HasData(
                        new
                        {
                            IdTelefone = 1,
                            CodigoPais = "15",
                            IdCliente = 1,
                            NumeroTelefone = "65981549785"
                        },
                        new
                        {
                            IdTelefone = 2,
                            CodigoPais = "15",
                            IdCliente = 2,
                            NumeroTelefone = "65981473274"
                        },
                        new
                        {
                            IdTelefone = 3,
                            CodigoPais = "15",
                            IdFuncionario = 1,
                            NumeroTelefone = "65978413025"
                        },
                        new
                        {
                            IdTelefone = 4,
                            CodigoPais = "15",
                            IdFuncionario = 2,
                            NumeroTelefone = "65978452136"
                        },
                        new
                        {
                            IdTelefone = 5,
                            CodigoPais = "15",
                            IdFilial = 1,
                            NumeroTelefone = "6537458974"
                        },
                        new
                        {
                            IdTelefone = 6,
                            CodigoPais = "15",
                            IdFilial = 2,
                            NumeroTelefone = "6538741897"
                        });
                });

            modelBuilder.Entity("gtauto_api.Entities.Veiculo", b =>
                {
                    b.Property<int>("IdVeiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdFilial")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVeiculo");

                    b.HasIndex("IdFilial");

                    b.ToTable("Veiculos");

                    b.HasData(
                        new
                        {
                            IdVeiculo = 1,
                            Ano = "2020/21",
                            Categoria = "Luxo",
                            IdFilial = 1,
                            Modelo = "VW Golf Gti",
                            Placa = "OBJ1231"
                        },
                        new
                        {
                            IdVeiculo = 2,
                            Ano = "2020/21",
                            Categoria = "Utilitario",
                            IdFilial = 2,
                            Modelo = "Fiat Estrada",
                            Placa = "HVH1010"
                        },
                        new
                        {
                            IdVeiculo = 3,
                            Ano = "2020/21",
                            Categoria = "Luxo/Utilitario",
                            IdFilial = 1,
                            Modelo = "Fiat Toro",
                            Placa = "NGJ1231"
                        },
                        new
                        {
                            IdVeiculo = 4,
                            Ano = "2020/21",
                            Categoria = "Luxo",
                            IdFilial = 2,
                            Modelo = "Land Rover Evoque",
                            Placa = "NBM1290"
                        },
                        new
                        {
                            IdVeiculo = 5,
                            Ano = "2021/22",
                            Categoria = "Popular",
                            IdFilial = 1,
                            Modelo = "Fait Uno",
                            Placa = "PIY7689"
                        },
                        new
                        {
                            IdVeiculo = 6,
                            Ano = "2010/11",
                            Categoria = "Popular",
                            IdFilial = 1,
                            Modelo = "VW Up",
                            Placa = "GRU3412"
                        });
                });

            modelBuilder.Entity("gtauto_api.Entities.Aluguel", b =>
                {
                    b.HasOne("gtauto_api.Entities.Cliente", "Cliente")
                        .WithMany("Alugueis")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("gtauto_api.Entities.Filial", "Filial")
                        .WithMany("Alugueis")
                        .HasForeignKey("IdFilial")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("gtauto_api.Entities.Funcionario", "Funcionario")
                        .WithMany("Alugueis")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("gtauto_api.Entities.Veiculo", "Veiculo")
                        .WithMany("Alugueis")
                        .HasForeignKey("IdVeiculo")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("gtauto_api.Entities.Devolucao", b =>
                {
                    b.HasOne("gtauto_api.Entities.Cliente", "Cliente")
                        .WithMany("Devolucoes")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("gtauto_api.Entities.Filial", "Filial")
                        .WithMany("Devolucoes")
                        .HasForeignKey("IdFilial")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("gtauto_api.Entities.Funcionario", "Funcionario")
                        .WithMany("Devolucoes")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("gtauto_api.Entities.Veiculo", "Veiculo")
                        .WithMany("Devolucoes")
                        .HasForeignKey("IdVeiculo")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("gtauto_api.Entities.Endereco", b =>
                {
                    b.HasOne("gtauto_api.Entities.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("gtauto_api.Entities.Filial", "Filial")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdFilial")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("gtauto_api.Entities.Funcionario", "Funcionario")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("gtauto_api.Entities.Funcionario", b =>
                {
                    b.HasOne("gtauto_api.Entities.Filial", "Filial")
                        .WithMany("Funcionarios")
                        .HasForeignKey("IdFilial")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("gtauto_api.Entities.Telefone", b =>
                {
                    b.HasOne("gtauto_api.Entities.Cliente", "Cliente")
                        .WithMany("Telefones")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("gtauto_api.Entities.Filial", "Filial")
                        .WithMany("Telefones")
                        .HasForeignKey("IdFilial")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("gtauto_api.Entities.Funcionario", "Funcionario")
                        .WithMany("Telefones")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("gtauto_api.Entities.Veiculo", b =>
                {
                    b.HasOne("gtauto_api.Entities.Filial", "Filial")
                        .WithMany("Veiculos")
                        .HasForeignKey("IdFilial")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
