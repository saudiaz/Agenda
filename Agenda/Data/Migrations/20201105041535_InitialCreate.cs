using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompaniaTelefonicas",
                columns: table => new
                {
                    IDCompaniaTelefonica = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompania = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompaniaTelefonicas", x => x.IDCompaniaTelefonica);
                });

            migrationBuilder.CreateTable(
                name: "Perfils",
                columns: table => new
                {
                    IdPerfil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    NumeroContacto = table.Column<int>(nullable: false),
                    IDCompaniaTelefonica = table.Column<int>(nullable: false),
                    IdUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfils", x => x.IdPerfil);
                    table.ForeignKey(
                        name: "FK_Perfils_CompaniaTelefonicas_IDCompaniaTelefonica",
                        column: x => x.IDCompaniaTelefonica,
                        principalTable: "CompaniaTelefonicas",
                        principalColumn: "IDCompaniaTelefonica",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfils_AspNetUsers_IdUser",
                        column: x => x.IdUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perfils_IDCompaniaTelefonica",
                table: "Perfils",
                column: "IDCompaniaTelefonica",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Perfils_IdUser",
                table: "Perfils",
                column: "IdUser",
                unique: true,
                filter: "[IdUser] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Perfils");

            migrationBuilder.DropTable(
                name: "CompaniaTelefonicas");
        }
    }
}
