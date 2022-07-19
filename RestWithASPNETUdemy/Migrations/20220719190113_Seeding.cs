using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestWithASPNETUdemy.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Address", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 1, "Curitiba - PR", "João", "Male", "Vitor" },
                    { 2, "Anchiano - Italy", "Leonardo", "Male", "Da Vinci" },
                    { 3, "Porbandar - India", "Mahatma", "Male", "Gandhi" },
                    { 4, "Kentucky - USA", "Mohamed Ali", "Male", "Gandhi" },
                    { 5, "Mvezo - South Africa", "Nelson", "Male", "Mandela" },
                    { 6, "New England", "Vitoria", "Female", "Elizabeth" },
                    { 7, "São Paulo - Brasil", "Ayrton", "Male", "Senna" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
