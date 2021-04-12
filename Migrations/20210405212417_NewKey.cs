using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzz.Migrations
{
    public partial class NewKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Liczba",
                table: "Liczba");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Liczba",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Liczba",
                table: "Liczba",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Liczba",
                table: "Liczba");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Liczba");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Liczba",
                table: "Liczba",
                column: "Date");
        }
    }
}
