using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABONAP.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sucursales_Empresas_EmpresaId",
                table: "Sucursales");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Sucursales");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Sucursales",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sucursales_Empresas_EmpresaId",
                table: "Sucursales",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sucursales_Empresas_EmpresaId",
                table: "Sucursales");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Sucursales",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Sucursales",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Sucursales_Empresas_EmpresaId",
                table: "Sucursales",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");
        }
    }
}
