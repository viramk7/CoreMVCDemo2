using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMVCDemo2.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubjectMapping");

            migrationBuilder.DropColumn(
                name: "Weightage",
                table: "Subject");

            migrationBuilder.RenameColumn(
                name: "SubjectName",
                table: "Subject",
                newName: "ClassName");

            migrationBuilder.AddColumn<int>(
                name: "ClassRoomId",
                table: "Student",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassRoomId",
                table: "Student",
                column: "ClassRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Subject_ClassRoomId",
                table: "Student",
                column: "ClassRoomId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Subject_ClassRoomId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_ClassRoomId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ClassRoomId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "ClassName",
                table: "Subject",
                newName: "SubjectName");

            migrationBuilder.AddColumn<double>(
                name: "Weightage",
                table: "Subject",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "StudentSubjectMapping",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<long>(nullable: true),
                    SubjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjectMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentSubjectMapping_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubjectMapping_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMapping_StudentId",
                table: "StudentSubjectMapping",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMapping_SubjectId",
                table: "StudentSubjectMapping",
                column: "SubjectId");
        }
    }
}
