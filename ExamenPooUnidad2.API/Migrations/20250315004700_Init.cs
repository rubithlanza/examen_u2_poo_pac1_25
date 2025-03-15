using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenPooUnidad2.API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    nombre = table.Column<string>(type: "TEXT", nullable: false),
                    apellido = table.Column<string>(type: "TEXT", nullable: false),
                    documento = table.Column<string>(type: "TEXT", nullable: false),
                    fecha_contratacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    departamento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    puesto_trabajo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    salario = table.Column<int>(type: "INTEGER", nullable: false),
                    activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "planilla",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    periodo = table.Column<string>(type: "TEXT", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    fecha_pago = table.Column<DateTime>(type: "TEXT", nullable: false),
                    estado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planilla", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "detalle_planilla",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    planilla_id = table.Column<Guid>(type: "TEXT", nullable: true),
                    empleado_id = table.Column<Guid>(type: "TEXT", nullable: true),
                    salario_base = table.Column<decimal>(type: "TEXT", nullable: false),
                    horas_extras = table.Column<decimal>(type: "TEXT", nullable: false),
                    monto_horas_extras = table.Column<decimal>(type: "TEXT", nullable: false),
                    bonificaciones = table.Column<decimal>(type: "TEXT", nullable: false),
                    deduciones = table.Column<decimal>(type: "TEXT", nullable: false),
                    salario_neto = table.Column<decimal>(type: "TEXT", nullable: false),
                    comentarios = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_planilla", x => x.id);
                    table.ForeignKey(
                        name: "FK_detalle_planilla_empleados_empleado_id",
                        column: x => x.empleado_id,
                        principalTable: "empleados",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_detalle_planilla_planilla_planilla_id",
                        column: x => x.planilla_id,
                        principalTable: "planilla",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalle_planilla_empleado_id",
                table: "detalle_planilla",
                column: "empleado_id");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_planilla_planilla_id",
                table: "detalle_planilla",
                column: "planilla_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalle_planilla");

            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "planilla");
        }
    }
}
