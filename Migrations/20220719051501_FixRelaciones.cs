using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABONAP.Migrations
{
    public partial class FixRelaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Personas_PersonaId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Sucursales_SucursalId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_TipoDocumentos_TipoDocumentoId",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Personas_PersonaId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Sucursales_SucursalId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Clientes_ClienteId",
                table: "Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Sucursales_SucursalId",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "IdSucursal",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdSucursal",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdTipoDocumento",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "IdSucursal",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                table: "Prestamos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Prestamos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                table: "Empleados",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "Empleados",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoDocumentoId",
                table: "Documentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Personas_PersonaId",
                table: "Clientes",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Sucursales_SucursalId",
                table: "Clientes",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_TipoDocumentos_TipoDocumentoId",
                table: "Documentos",
                column: "TipoDocumentoId",
                principalTable: "TipoDocumentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Personas_PersonaId",
                table: "Empleados",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Sucursales_SucursalId",
                table: "Empleados",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Clientes_ClienteId",
                table: "Prestamos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Sucursales_SucursalId",
                table: "Prestamos",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Personas_PersonaId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Sucursales_SucursalId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_TipoDocumentos_TipoDocumentoId",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Personas_PersonaId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Sucursales_SucursalId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Clientes_ClienteId",
                table: "Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Sucursales_SucursalId",
                table: "Prestamos");

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                table: "Prestamos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Prestamos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Prestamos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSucursal",
                table: "Prestamos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                table: "Empleados",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "Empleados",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "IdPersona",
                table: "Empleados",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSucursal",
                table: "Empleados",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TipoDocumentoId",
                table: "Documentos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoDocumento",
                table: "Documentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                table: "Clientes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "PersonaId",
                table: "Clientes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "IdPersona",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSucursal",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Personas_PersonaId",
                table: "Clientes",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Sucursales_SucursalId",
                table: "Clientes",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_TipoDocumentos_TipoDocumentoId",
                table: "Documentos",
                column: "TipoDocumentoId",
                principalTable: "TipoDocumentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Personas_PersonaId",
                table: "Empleados",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Sucursales_SucursalId",
                table: "Empleados",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Clientes_ClienteId",
                table: "Prestamos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Sucursales_SucursalId",
                table: "Prestamos",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id");
        }
    }
}
