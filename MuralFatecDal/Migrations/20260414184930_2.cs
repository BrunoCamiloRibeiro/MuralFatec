using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuralFatecDal.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstituicaoId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_InstituicaoId",
                table: "Usuarios",
                column: "InstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Instituicoes_InstituicaoId",
                table: "Usuarios",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Instituicoes_InstituicaoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_InstituicaoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "InstituicaoId",
                table: "Usuarios");
        }
    }
}
