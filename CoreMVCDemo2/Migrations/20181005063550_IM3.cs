using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMVCDemo2.Migrations
{
    public partial class IM3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Student",
                newName: "Address2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address2",
                table: "Student",
                newName: "Address");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Student",
                nullable: false,
                defaultValue: 0);
        }
    }
}
