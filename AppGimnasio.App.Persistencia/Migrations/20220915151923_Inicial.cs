using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppGimnasio.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IngresosGimnasio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bloqueado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresosGimnasio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mensualidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorMensualidad = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bloqueado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensualidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ejercicio1 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Ejercicio2 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Ejercicio3 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Ejercicio4 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Ejercicio5 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Cardio = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Bloqueado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutinas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoDocIdentificacion = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    Bloqueado = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IngresoGimnasioId = table.Column<int>(type: "int", nullable: true),
                    MensualidadId = table.Column<int>(type: "int", nullable: true),
                    RutinaId = table.Column<int>(type: "int", nullable: true),
                    NumeroCuenta = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_IngresosGimnasio_IngresoGimnasioId",
                        column: x => x.IngresoGimnasioId,
                        principalTable: "IngresosGimnasio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Mensualidades_MensualidadId",
                        column: x => x.MensualidadId,
                        principalTable: "Mensualidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Rutinas_RutinaId",
                        column: x => x.RutinaId,
                        principalTable: "Rutinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IngresoGimnasioId",
                table: "Personas",
                column: "IngresoGimnasioId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MensualidadId",
                table: "Personas",
                column: "MensualidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_RutinaId",
                table: "Personas",
                column: "RutinaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "IngresosGimnasio");

            migrationBuilder.DropTable(
                name: "Mensualidades");

            migrationBuilder.DropTable(
                name: "Rutinas");
        }
    }
}
