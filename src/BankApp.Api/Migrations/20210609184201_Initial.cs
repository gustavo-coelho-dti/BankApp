using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankApp.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    IdConta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Saldo = table.Column<decimal>(type: "MONEY", nullable: false),
                    TipoConta = table.Column<int>(type: "int", nullable: false),
                    EstaAtivo = table.Column<bool>(type: "bit", nullable: false),
                    IdCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.IdConta);
                    table.ForeignKey(
                        name: "FK_Contas_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contas_IdCliente",
                table: "Contas",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
