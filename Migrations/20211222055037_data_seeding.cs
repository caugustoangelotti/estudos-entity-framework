using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gtauto_api.Migrations
{
    public partial class data_seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alugueis",
                keyColumn: "IdAluguel",
                keyValue: 1,
                column: "DataAluguel",
                value: new DateTime(2021, 12, 22, 1, 50, 36, 862, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Alugueis",
                keyColumn: "IdAluguel",
                keyValue: 2,
                column: "DataAluguel",
                value: new DateTime(2021, 12, 22, 1, 50, 36, 863, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Alugueis",
                keyColumn: "IdAluguel",
                keyValue: 3,
                column: "DataAluguel",
                value: new DateTime(2021, 12, 22, 1, 50, 36, 863, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "IdCliente",
                keyValue: 1,
                column: "DataNascimento",
                value: new DateTime(1960, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "IdCliente",
                keyValue: 2,
                column: "DataNascimento",
                value: new DateTime(1997, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Devolucoes",
                keyColumn: "IdDevolucao",
                keyValue: 1,
                column: "DataDevolucao",
                value: new DateTime(2021, 12, 22, 1, 50, 36, 863, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Devolucoes",
                keyColumn: "IdDevolucao",
                keyValue: 2,
                column: "DataDevolucao",
                value: new DateTime(2021, 12, 22, 1, 50, 36, 863, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "IdFuncionario",
                keyValue: 1,
                column: "DataNascimento",
                value: new DateTime(1975, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "IdFuncionario",
                keyValue: 2,
                column: "DataNascimento",
                value: new DateTime(1979, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alugueis",
                keyColumn: "IdAluguel",
                keyValue: 1,
                column: "DataAluguel",
                value: new DateTime(2021, 12, 17, 22, 52, 31, 993, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Alugueis",
                keyColumn: "IdAluguel",
                keyValue: 2,
                column: "DataAluguel",
                value: new DateTime(2021, 12, 17, 22, 52, 31, 994, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Alugueis",
                keyColumn: "IdAluguel",
                keyValue: 3,
                column: "DataAluguel",
                value: new DateTime(2021, 12, 17, 22, 52, 31, 994, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "IdCliente",
                keyValue: 1,
                column: "DataNascimento",
                value: new DateTime(1965, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "IdCliente",
                keyValue: 2,
                column: "DataNascimento",
                value: new DateTime(1960, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Devolucoes",
                keyColumn: "IdDevolucao",
                keyValue: 1,
                column: "DataDevolucao",
                value: new DateTime(2021, 12, 17, 22, 52, 31, 994, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Devolucoes",
                keyColumn: "IdDevolucao",
                keyValue: 2,
                column: "DataDevolucao",
                value: new DateTime(2021, 12, 17, 22, 52, 31, 994, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "IdFuncionario",
                keyValue: 1,
                column: "DataNascimento",
                value: new DateTime(1997, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "IdFuncionario",
                keyValue: 2,
                column: "DataNascimento",
                value: new DateTime(1968, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
