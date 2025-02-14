﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRABALHO_volvo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caminhoes",
                columns: table => new
                {
                    CodCaminhao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quilometragem = table.Column<double>(type: "float", nullable: false),
                    DataFabricacao = table.Column<DateOnly>(type: "date", nullable: false),
                    CaminhaoAtivo = table.Column<bool>(type: "bit", nullable: false),
                    FkClientesClienteId = table.Column<int>(type: "int", nullable: false),
                    FkModelosCaminhoesModelosCaminhaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caminhoes", x => x.CodCaminhao);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    CodCargo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCargo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SalarioBase = table.Column<double>(type: "float", nullable: false),
                    PorcentagemComissao = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.CodCargo);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CodCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
<<<<<<<< HEAD:Migrations/20240202174011_CreateDatabase.cs
                    DocIndentificadorCliente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClienteAtivo = table.Column<bool>(type: "bit", nullable: false),
========
                    DocIdentificadorCliente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
>>>>>>>> cb1c4a445598c4c102b50ad09dadd4a7e27b4277:Migrations/20240202210408_CreateDatabase01.cs
                    EmailCliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumeroContatoCliente = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CodCliente);
                });

            migrationBuilder.CreateTable(
                name: "Concessionarias",
                columns: table => new
                {
                    CodConc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeConc = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
<<<<<<<< HEAD:Migrations/20240202174011_CreateDatabase.cs
========
                    CepConcessionaria = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
>>>>>>>> cb1c4a445598c4c102b50ad09dadd4a7e27b4277:Migrations/20240202210408_CreateDatabase01.cs
                    ConcessionariaAtivo = table.Column<bool>(type: "bit", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
<<<<<<<< HEAD:Migrations/20240202174011_CreateDatabase.cs
                    Numero = table.Column<int>(type: "int", maxLength: 30, nullable: false)
========
                    Numero = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
>>>>>>>> cb1c4a445598c4c102b50ad09dadd4a7e27b4277:Migrations/20240202210408_CreateDatabase01.cs
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concessionarias", x => x.CodConc);
                });

            migrationBuilder.CreateTable(
                name: "EstoqueCaminhao",
                columns: table => new
                {
                    CodCaminhaoEstoque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkModelosCaminhaoCodModelo = table.Column<int>(type: "int", nullable: false),
                    FkConcessionariasCodConc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueCaminhao", x => x.CodCaminhaoEstoque);
                });

            migrationBuilder.CreateTable(
                name: "EstoquePecas",
                columns: table => new
                {
                    CodPecaEstoque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataFabricacao = table.Column<DateOnly>(type: "date", nullable: false),
                    FkTipoPecasCodTipoPeca = table.Column<int>(type: "int", nullable: false),
                    FkConcessionariasCodConc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoquePecas", x => x.CodPecaEstoque);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    CodFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CpfFuncionario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FuncionarioAtivo = table.Column<bool>(type: "bit", nullable: false),
                    NumeroContatoFuncionario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FkCargosCodCargo = table.Column<int>(type: "int", nullable: false),
                    FkConcessionariasCodConc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.CodFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "ModelosCaminhoes",
                columns: table => new
                {
                    CodModelo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeModelo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ModelosAtivo = table.Column<bool>(type: "bit", nullable: false),
                    ValorModelosCaminhao = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelosCaminhoes", x => x.CodModelo);
                });

            migrationBuilder.CreateTable(
                name: "PecasModelos",
                columns: table => new
                {
                    CodPecasModelo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkModelosCaminhoesCodModelo = table.Column<int>(type: "int", nullable: false),
                    FkTipoPecasCodTipoPeca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PecasModelos", x => x.CodPecasModelo);
                });

            migrationBuilder.CreateTable(
                name: "ServicoManutencoes",
                columns: table => new
                {
                    CodManutencao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataManutencao = table.Column<DateOnly>(type: "date", nullable: false),
                    ValorServicoManutencao = table.Column<double>(type: "float", nullable: false),
                    QuilometragemCaminhao = table.Column<double>(type: "float", nullable: false),
                    DescricaoManutencao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FkFuncionariosCodFuncionario = table.Column<int>(type: "int", nullable: false),
                    FkCaminhaoEstoqueCodCaminhao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicoManutencoes", x => x.CodManutencao);
                });

            migrationBuilder.CreateTable(
                name: "ServicoTipoPecas",
                columns: table => new
                {
                    CodServicoTipoPeca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkCodManutencao = table.Column<int>(type: "int", nullable: false),
                    FkCodTipoPeca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicoTipoPecas", x => x.CodServicoTipoPeca);
                });

            migrationBuilder.CreateTable(
                name: "TipoPecas",
                columns: table => new
                {
                    CodTipoPeca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTipoPeca = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    PecaAtivo = table.Column<bool>(type: "bit", nullable: false),
                    ValorTipoPeca = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPecas", x => x.CodTipoPeca);
                });

            migrationBuilder.CreateTable(
                name: "VendaCaminhoes",
                columns: table => new
                {
                    CodVenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataVenda = table.Column<DateOnly>(type: "date", nullable: false),
                    FkClientesCodCliente = table.Column<int>(type: "int", nullable: false),
                    FkFuncionariosCodFuncionario = table.Column<int>(type: "int", nullable: false),
                    FkCaminhaoEstoqueCodCaminhaoEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaCaminhoes", x => x.CodVenda);
                });

            migrationBuilder.CreateIndex(
<<<<<<<< HEAD:Migrations/20240202174011_CreateDatabase.cs
                name: "IX_Clientes_DocIndentificadorCliente",
                table: "Clientes",
                column: "DocIndentificadorCliente",
========
                name: "IX_Clientes_DocIdentificadorCliente",
                table: "Clientes",
                column: "DocIdentificadorCliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Concessionarias_CepConcessionaria",
                table: "Concessionarias",
                column: "CepConcessionaria",
>>>>>>>> cb1c4a445598c4c102b50ad09dadd4a7e27b4277:Migrations/20240202210408_CreateDatabase01.cs
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_CpfFuncionario",
                table: "Funcionarios",
                column: "CpfFuncionario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caminhoes");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Concessionarias");

            migrationBuilder.DropTable(
                name: "EstoqueCaminhao");

            migrationBuilder.DropTable(
                name: "EstoquePecas");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "ModelosCaminhoes");

            migrationBuilder.DropTable(
                name: "PecasModelos");

            migrationBuilder.DropTable(
                name: "ServicoManutencoes");

            migrationBuilder.DropTable(
                name: "ServicoTipoPecas");

            migrationBuilder.DropTable(
                name: "TipoPecas");

            migrationBuilder.DropTable(
                name: "VendaCaminhoes");
        }
    }
}
