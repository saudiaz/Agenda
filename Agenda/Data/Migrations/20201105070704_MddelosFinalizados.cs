using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda.Data.Migrations
{
    public partial class MddelosFinalizados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    IDContracto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    NumeroContacto = table.Column<int>(nullable: false),
                    IDCompaniaTelefonica = table.Column<int>(nullable: false),
                    Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.IDContracto);
                    table.ForeignKey(
                        name: "FK_Contactos_CompaniaTelefonicas_IDCompaniaTelefonica",
                        column: x => x.IDCompaniaTelefonica,
                        principalTable: "CompaniaTelefonicas",
                        principalColumn: "IDCompaniaTelefonica",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contactos_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_IDCompaniaTelefonica",
                table: "Contactos",
                column: "IDCompaniaTelefonica",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_Id",
                table: "Contactos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactos");
        }
    }
}
