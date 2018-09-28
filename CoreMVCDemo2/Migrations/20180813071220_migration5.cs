using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreMVCDemo2.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubjectMapping",
                table: "StudentSubjectMapping");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjectMapping_StudentId",
                table: "StudentSubjectMapping");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentSubjectMapping");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubjectMapping",
                table: "StudentSubjectMapping",
                columns: new[] { "StudentId", "SubjectId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubjectMapping",
                table: "StudentSubjectMapping");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "StudentSubjectMapping",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubjectMapping",
                table: "StudentSubjectMapping",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMapping_StudentId",
                table: "StudentSubjectMapping",
                column: "StudentId");
        }
    }
}
