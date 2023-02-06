using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesOrderManager.Api.Migrations
{
    public partial class InitialDBmodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "SubElements");

            migrationBuilder.AddColumn<string>(
                name: "ElementType",
                table: "SubElements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 1,
                column: "ElementType",
                value: "Doors");

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 2,
                column: "ElementType",
                value: "Window");

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 3,
                column: "ElementType",
                value: "Window");

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 4,
                column: "ElementType",
                value: "Window");

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 5,
                column: "ElementType",
                value: "Doors");

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 6,
                column: "ElementType",
                value: "Window");

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 7,
                column: "ElementType",
                value: "Window");

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 8,
                column: "ElementType",
                value: "Window");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElementType",
                table: "SubElements");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "SubElements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 2,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 3,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 4,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 6,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 7,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubElements",
                keyColumn: "SubElementId",
                keyValue: 8,
                column: "Type",
                value: 1);
        }
    }
}
