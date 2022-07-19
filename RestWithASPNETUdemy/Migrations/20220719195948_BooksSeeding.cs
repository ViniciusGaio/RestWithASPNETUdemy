﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestWithASPNETUdemy.Migrations
{
    public partial class BooksSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaunchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "LaunchDate", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Michael C. Feathers", new DateTime(2017, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, "Working effectively with legacy code" },
                    { 2, "Ralph Johnson, Erich Gamma, John Vlissides e Richard Helm", new DateTime(2017, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, "Design Patterns" },
                    { 3, "Robert C. Martin", new DateTime(2009, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.0, "Clean Code" },
                    { 4, "Crockford", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 67.0, "JavaScript" },
                    { 5, "Steve McConnell", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 58.0, "Code complete" },
                    { 6, "Martin Fowler e Kent Beck", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 88.0, "Refactoring" },
                    { 7, "Eric Freeman, Elisabeth Freeman, Kathy Sierra, Bert Bates", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0, "Head First Design Patterns" },
                    { 8, "Eric Evans", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 92.0, "Domain Driven Design" },
                    { 9, "Brian Goetz e Tim Peierls", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 80.0, "Java Concurrency in Practice" },
                    { 10, "Susan Cain", new DateTime(2017, 11, 7, 15, 9, 1, 674, DateTimeKind.Unspecified), 123.0, "O poder dos quietos" },
                    { 11, "Roger S. Pressman", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.0, "Engenharia de Software: uma abordagem profissional" },
                    { 12, "Viktor Mayer-Schonberger e Kenneth Kukier", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 54.0, "Big Data: como extrair volume, variedade, velocidade e valor da avalanche de informação cotidiana" },
                    { 13, "Richard Hunter e George Westerman", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 95.0, "O verdadeiro valor de TI" },
                    { 14, "Marc J. Schiller", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, "Os 11 segredos de líderes de TI altamente influentes" },
                    { 15, "Aguinaldo Aragon Fernandes e Vladimir Ferraz de Abreu", new DateTime(2017, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 54.0, "Implantando a governança de TI" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
