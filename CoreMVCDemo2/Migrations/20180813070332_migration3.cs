using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreMVCDemo2.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Student_StudentId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_StudentId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Subject");

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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<long>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjectMapping", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubjectMapping");

            migrationBuilder.DropColumn(
                name: "Weightage",
                table: "Subject");

            migrationBuilder.AddColumn<long>(
                name: "StudentId",
                table: "Subject",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_StudentId",
                table: "Subject",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Student_StudentId",
                table: "Subject",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
