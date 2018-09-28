using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreMVCDemo2.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMapping_StudentId",
                table: "StudentSubjectMapping",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjectMapping_SubjectId",
                table: "StudentSubjectMapping",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjectMapping_Student_StudentId",
                table: "StudentSubjectMapping",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjectMapping_Subject_SubjectId",
                table: "StudentSubjectMapping",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjectMapping_Student_StudentId",
                table: "StudentSubjectMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjectMapping_Subject_SubjectId",
                table: "StudentSubjectMapping");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjectMapping_StudentId",
                table: "StudentSubjectMapping");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjectMapping_SubjectId",
                table: "StudentSubjectMapping");
        }
    }
}
