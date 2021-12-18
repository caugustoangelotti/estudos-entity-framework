using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gtauto_api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Cpf = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Filiais",
                columns: table => new
                {
                    IdFilial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFantasia = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiais", x => x.IdFilial);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Cpf = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IdFilial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Filiais_IdFilial",
                        column: x => x.IdFilial,
                        principalTable: "Filiais",
                        principalColumn: "IdFilial");
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    IdVeiculo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(nullable: true),
                    Ano = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Categoria = table.Column<string>(nullable: true),
                    IdFilial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.IdVeiculo);
                    table.ForeignKey(
                        name: "FK_Veiculos_Filiais_IdFilial",
                        column: x => x.IdFilial,
                        principalTable: "Filiais",
                        principalColumn: "IdFilial");
                });

            migrationBuilder.CreateTable(
                name: "Devolucoes",
                columns: table => new
                {
                    IdDevolucao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDevolucao = table.Column<DateTime>(nullable: false),
                    IdAluguel = table.Column<int>(nullable: false),
                    IdFuncionario = table.Column<int>(nullable: false),
                    IdFilial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devolucoes", x => x.IdDevolucao);
                    table.ForeignKey(
                        name: "FK_Devolucoes_Filiais_IdFilial",
                        column: x => x.IdFilial,
                        principalTable: "Filiais",
                        principalColumn: "IdFilial");
                    table.ForeignKey(
                        name: "FK_Devolucoes_Funcionarios_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "IdFuncionario");
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uf = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Referencia = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    IdCliente = table.Column<int>(nullable: true),
                    IdFuncionario = table.Column<int>(nullable: true),
                    IdFilial = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_Enderecos_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente");
                    table.ForeignKey(
                        name: "FK_Enderecos_Filiais_IdFilial",
                        column: x => x.IdFilial,
                        principalTable: "Filiais",
                        principalColumn: "IdFilial");
                    table.ForeignKey(
                        name: "FK_Enderecos_Funcionarios_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "IdFuncionario");
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    IdTelefone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroTelefone = table.Column<string>(nullable: true),
                    CodigoPais = table.Column<string>(nullable: true),
                    IdCliente = table.Column<int>(nullable: true),
                    IdFuncionario = table.Column<int>(nullable: true),
                    IdFilial = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.IdTelefone);
                    table.ForeignKey(
                        name: "FK_Telefones_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente");
                    table.ForeignKey(
                        name: "FK_Telefones_Filiais_IdFilial",
                        column: x => x.IdFilial,
                        principalTable: "Filiais",
                        principalColumn: "IdFilial");
                    table.ForeignKey(
                        name: "FK_Telefones_Funcionarios_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "IdFuncionario");
                });

            migrationBuilder.CreateTable(
                name: "Alugueis",
                columns: table => new
                {
                    IdAluguel = table.Column<int>(nullable: false),
                    DataAluguel = table.Column<DateTime>(nullable: false),
                    IdVeiculo = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    IdFuncionario = table.Column<int>(nullable: false),
                    IdFilial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alugueis", x => x.IdAluguel);
                    table.ForeignKey(
                        name: "FK_Alugueis_Devolucoes_IdAluguel",
                        column: x => x.IdAluguel,
                        principalTable: "Devolucoes",
                        principalColumn: "IdDevolucao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alugueis_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente");
                    table.ForeignKey(
                        name: "FK_Alugueis_Filiais_IdFilial",
                        column: x => x.IdFilial,
                        principalTable: "Filiais",
                        principalColumn: "IdFilial");
                    table.ForeignKey(
                        name: "FK_Alugueis_Funcionarios_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "IdFuncionario");
                    table.ForeignKey(
                        name: "FK_Alugueis_Veiculos_IdVeiculo",
                        column: x => x.IdVeiculo,
                        principalTable: "Veiculos",
                        principalColumn: "IdVeiculo");
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "IdCliente", "Cpf", "DataNascimento", "Email", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { 1, "09758123784", new DateTime(1965, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "garry@mail.com", "Garry", "Kasparov" },
                    { 2, "79857403185", new DateTime(1960, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "karpov@mail.com", "Anatoly", "Karpov" }
                });

            migrationBuilder.InsertData(
                table: "Filiais",
                columns: new[] { "IdFilial", "Cnpj", "NomeFantasia" },
                values: new object[,]
                {
                    { 1, "70603205000147", "GtAuto Varzea Grande" },
                    { 2, "70170979000121", "GtAuto Cuiaba" }
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "IdEndereco", "Bairro", "Cep", "Cidade", "Complemento", "IdCliente", "IdFilial", "IdFuncionario", "Numero", "Referencia", "Rua", "Uf" },
                values: new object[,]
                {
                    { 3, "Ermelino Matarazzo", "698754320", "Sao Paulo", "", 1, null, null, "12", "Proximo shopping", "RUA 16", "SP" },
                    { 4, "Central", "74520197", "Sinop", "", 1, null, null, "315", "Proximo casas bahia", "Av. Doze", "MT" },
                    { 5, "Perimetral", "36874987", "Umuarama", "", 2, null, null, "5564", "", "121", "PR" },
                    { 1, "Centro", "78118182", "Varzea Grande", "Entrada pela parte de tras", null, 1, null, "S/N", "Proximo escola", "Av. Central", "MT" },
                    { 2, "Boa Esperanca", "78068300", "Cuiaba", "", null, 2, null, "1312", "Proximo escola", "Av. Moinho", "MT" }
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "IdFuncionario", "Cpf", "DataNascimento", "Email", "IdFilial", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { 2, "97834268712", new DateTime(1968, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ivanchuck@mail.com", 1, "Vasyl", "Ivanchuck" },
                    { 1, "65412387621", new DateTime(1997, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tal@mail.com", 2, "Mikhail", "Tal" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "IdTelefone", "CodigoPais", "IdCliente", "IdFilial", "IdFuncionario", "NumeroTelefone" },
                values: new object[,]
                {
                    { 1, "15", 1, null, null, "65981549785" },
                    { 2, "15", 2, null, null, "65981473274" },
                    { 5, "15", null, 1, null, "6537458974" },
                    { 6, "15", null, 2, null, "6538741897" }
                });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "IdVeiculo", "Ano", "Categoria", "IdFilial", "Modelo", "Placa" },
                values: new object[,]
                {
                    { 1, "2020/21", "Luxo", 1, "VW Golf Gti", "OBJ1231" },
                    { 5, "2021/22", "Popular", 1, "Fait Uno", "PIY7689" },
                    { 3, "2020/21", "Luxo/Utilitario", 1, "Fiat Toro", "NGJ1231" },
                    { 2, "2020/21", "Utilitario", 2, "Fiat Estrada", "HVH1010" },
                    { 6, "2010/11", "Popular", 1, "VW Up", "GRU3412" },
                    { 4, "2020/21", "Luxo", 2, "Land Rover Evoque", "NBM1290" }
                });

            migrationBuilder.InsertData(
                table: "Alugueis",
                columns: new[] { "IdAluguel", "DataAluguel", "IdCliente", "IdFilial", "IdFuncionario", "IdVeiculo" },
                values: new object[] { 3, new DateTime(2021, 12, 17, 22, 36, 50, 491, DateTimeKind.Local).AddTicks(5348), 1, 2, 1, 4 });

            migrationBuilder.InsertData(
                table: "Devolucoes",
                columns: new[] { "IdDevolucao", "DataDevolucao", "IdAluguel", "IdFilial", "IdFuncionario" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 17, 22, 36, 50, 491, DateTimeKind.Local).AddTicks(7381), 2, 1, 2 },
                    { 2, new DateTime(2021, 12, 17, 22, 36, 50, 491, DateTimeKind.Local).AddTicks(8295), 3, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "IdEndereco", "Bairro", "Cep", "Cidade", "Complemento", "IdCliente", "IdFilial", "IdFuncionario", "Numero", "Referencia", "Rua", "Uf" },
                values: new object[,]
                {
                    { 7, "Cristo Rei", "78118218", "Varzea Grande", "", null, null, 2, "12", "", "rua 9", "MT" },
                    { 6, "Grande Terceiro", "32587410", "Campo Grande", "", null, null, 1, "5", "", "12", "MS" }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "IdTelefone", "CodigoPais", "IdCliente", "IdFilial", "IdFuncionario", "NumeroTelefone" },
                values: new object[,]
                {
                    { 4, "15", null, null, 2, "65978452136" },
                    { 3, "15", null, null, 1, "65978413025" }
                });

            migrationBuilder.InsertData(
                table: "Alugueis",
                columns: new[] { "IdAluguel", "DataAluguel", "IdCliente", "IdFilial", "IdFuncionario", "IdVeiculo" },
                values: new object[] { 1, new DateTime(2021, 12, 17, 22, 36, 50, 490, DateTimeKind.Local).AddTicks(5848), 1, 1, 2, 6 });

            migrationBuilder.InsertData(
                table: "Alugueis",
                columns: new[] { "IdAluguel", "DataAluguel", "IdCliente", "IdFilial", "IdFuncionario", "IdVeiculo" },
                values: new object[] { 2, new DateTime(2021, 12, 17, 22, 36, 50, 491, DateTimeKind.Local).AddTicks(5299), 1, 2, 1, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_IdCliente",
                table: "Alugueis",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_IdFilial",
                table: "Alugueis",
                column: "IdFilial");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_IdFuncionario",
                table: "Alugueis",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_IdVeiculo",
                table: "Alugueis",
                column: "IdVeiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Devolucoes_IdFilial",
                table: "Devolucoes",
                column: "IdFilial");

            migrationBuilder.CreateIndex(
                name: "IX_Devolucoes_IdFuncionario",
                table: "Devolucoes",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_IdCliente",
                table: "Enderecos",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_IdFilial",
                table: "Enderecos",
                column: "IdFilial");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_IdFuncionario",
                table: "Enderecos",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_IdFilial",
                table: "Funcionarios",
                column: "IdFilial");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_IdCliente",
                table: "Telefones",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_IdFilial",
                table: "Telefones",
                column: "IdFilial");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_IdFuncionario",
                table: "Telefones",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_IdFilial",
                table: "Veiculos",
                column: "IdFilial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alugueis");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Devolucoes");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Filiais");
        }
    }
}
